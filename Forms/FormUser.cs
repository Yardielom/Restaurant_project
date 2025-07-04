    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using WindowsFormsApp1.models;
    using WindowsFormsApp1.Utils;

    namespace WindowsFormsApp1.Forms
    {
        public partial class FormUser : Form
        {
            private User loggedInUser;
            public User UpdatedUser => loggedInUser;
            private List<Order> orders;
            private HashSet<int> processedOrders = new HashSet<int>();

            public FormUser(User user)
            {
                InitializeComponent();
                loggedInUser = user;
                this.Load += FormUser_Load;
                this.Shown += FormUser_Shown;
            }

            private void FormUser_Load(object sender, EventArgs e)
            {
                textBoxUsername.Text = loggedInUser.Username;
                textBoxPassword.Text = loggedInUser.Password;
                textBoxAddress.Text = loggedInUser.Address;
                flowLayoutPanelOrders.AutoScroll = true;
                RenderPastOrders();
            }

            private void FormUser_Shown(object sender, EventArgs e)
            {
                ProcessNewOrders();
            }

            private void BtnReceipt_Click(object sender, EventArgs e)
            {
                if (sender is Button btn && btn.Tag is Order order)
                {
                    StringBuilder receipt = new StringBuilder();
                    receipt.AppendLine("====== RECEIPT ======");
                    receipt.AppendLine($"Order ID: {order.OrderId}");
                    receipt.AppendLine($"Username: {order.Username}");
                    receipt.AppendLine($"Address: {order.Address}");
                    receipt.AppendLine($"Status: {order.Status}");
                    receipt.AppendLine("-----------------------");

                    foreach (var dish in order.Dishes)
                    {
                        receipt.AppendLine($"{dish.Name} - {dish.Price:C}");
                    }

                    receipt.AppendLine("-----------------------");
                    receipt.AppendLine($"TOTAL: {order.Total:C}");

                    MessageBox.Show(receipt.ToString(), "Order Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }



            private void RenderPastOrders()
            {
                flowLayoutPanelOrders.Controls.Clear();
                var all = DataStorage.LoadFromFile<Order>("orders.json");
                orders = all.Where(o => o.Username == loggedInUser.Username).ToList();
                if (!orders.Any())
                {
                    flowLayoutPanelOrders.Controls.Add(new Label { Text = "No orders found.", AutoSize = true, Padding = new Padding(10) });
                    return;
                }
                foreach (var order in orders)
                {
                    var panel = CreateOrderPanel(order);
                    flowLayoutPanelOrders.Controls.Add(panel);
                    if (order.Status == "Received") processedOrders.Add(order.OrderId);
                }
            }

        private void ProcessNewOrders()
        {
            var latestOrder = orders
                .Where(o => o.Status == "Received")
                .OrderByDescending(o => o.OrderId)
                .FirstOrDefault();

            if (latestOrder != null && processedOrders.Contains(latestOrder.OrderId))
            {
                var panel = flowLayoutPanelOrders.Controls.OfType<Panel>()
                    .FirstOrDefault(p => (int)p.Tag == latestOrder.OrderId);
                if (panel != null)
                {
                    _ = ProcessNewOrderAsync(latestOrder, panel);
                }
            }
        }



        private Panel CreateOrderPanel(Order order)
            {
                var panel = new Panel
                {
                    Width = flowLayoutPanelOrders.ClientSize.Width - 20,
                    Height = 80,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(5),
                    Tag = order.OrderId
                };

                panel.Controls.Add(new Label { Text = $"Order #{order.OrderId}", Location = new Point(10, 10), AutoSize = true, Name = "lblId" });
                panel.Controls.Add(new Label { Text = $"Status: {order.Status}", Location = new Point(10, 30), AutoSize = true, Name = "lblStatus" });
                panel.Controls.Add(new Label { Text = $"Total: ${order.Total:F2}", Location = new Point(150, 30), AutoSize = true, Name = "lblTotal" });
                panel.Controls.Add(new Label { Text = $"Address: {order.Address}", Location = new Point(10, 50), AutoSize = true, Name = "lblAddress" });

                var btnReceipt = new Button
                {
                    Text = "View Receipt",
                    Size = new Size(100, 30),
                    Location = new Point(panel.Width - 120, 10),
                    Tag = order
                };
                btnReceipt.Click += BtnReceipt_Click;
                panel.Controls.Add(btnReceipt);

                return panel;
            }


        private async Task ProcessNewOrderAsync(Order order, Panel panel)
        {
            order.Status = "Accepted";
            UpdatePanelStatus(panel, order.Status);
            SaveOrderUpdate(order);
            await Task.Delay(10000);

            order.Status = "In Delivery";
            UpdatePanelStatus(panel, order.Status);
            SaveOrderUpdate(order);
            await Task.Delay(10000);

            order.Status = "Delivered";
            UpdatePanelStatus(panel, order.Status);
            SaveOrderUpdate(order);
        }

        private void UpdatePanelStatus(Panel panel, string status)
            {
                if (panel.InvokeRequired)
                {
                    panel.Invoke(new Action(() => UpdatePanelStatus(panel, status)));
                    return;
                }
                var lbl = panel.Controls.Find("lblStatus", false).FirstOrDefault() as Label;
                if (lbl != null) lbl.Text = $"Status: {status}";
            }

            private void SaveOrderUpdate(Order order)
            {
                var all = DataStorage.LoadFromFile<Order>("orders.json");
                var idx = all.FindIndex(o => o.OrderId == order.OrderId);
                if (idx >= 0)
                {
                    all[idx] = order;
                    DataStorage.SaveToFile(all, "orders.json");
                }
            }

            private void deleteAccount_Click(object sender, EventArgs e)
            {
                // Remove user and orders then go to the Auth form 
                var users = DataStorage.LoadFromFile<User>("users.json");
                users.RemoveAll(u => u.Username == loggedInUser.Username);
                DataStorage.SaveToFile(users, "users.json");
                var ordersList = DataStorage.LoadFromFile<Order>("orders.json");
                ordersList.RemoveAll(o => o.Username == loggedInUser.Username);
                DataStorage.SaveToFile(ordersList, "orders.json");
                var auth = new Auth(); auth.Show();
                foreach (Form f in Application.OpenForms.Cast<Form>().ToList()) if (!(f is Auth)) f.Close();
            }

            private void logOtBtn_Click(object sender, EventArgs e)
            {
                // Close menu forms then go to the Auth form
                var auth = new Auth(); auth.Show();
                foreach (Form f in Application.OpenForms.Cast<Form>().ToList()) if (!(f is Auth)) f.Close();
            }

            private void Save_Click(object sender, EventArgs e)
            {
                loggedInUser.Password = textBoxPassword.Text;
                loggedInUser.Address = textBoxAddress.Text;
                var users = DataStorage.LoadFromFile<User>("users.json") ?? new List<User>();
                var existingUser = users.FirstOrDefault(u => u.Username == loggedInUser.Username);
                if (existingUser != null)
                {
                    existingUser.Password = loggedInUser.Password;
                    existingUser.Address = loggedInUser.Address;
                }
                DataStorage.SaveToFile(users, "users.json");
                DialogResult = DialogResult.OK; Close();
            }

            private void Cancel_Click(object sender, EventArgs e)
            {
                DialogResult = DialogResult.Cancel; Close();
            }
        }
    }

