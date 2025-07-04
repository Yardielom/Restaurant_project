using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.models;
using WindowsFormsApp1.Utils;
using Microsoft.VisualBasic;
using WindowsFormsApp1.Forms;


namespace WindowsFormsApp1.Forms
{
    public partial class AdminForms : Form
    {
        private List<Dish> dishes = new List<Dish>();
        private Order currentOrder = new Order();
        private decimal deliveryCharge = 5.00m;
        private User loggedInUser;
        private User userAddress = new User();

        public AdminForms(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            this.Load += AdminForms_Load;
        }

        private void AdminForms_Load(object sender, EventArgs e)
        {
            LoadDishes();
            RenderDishes();
            deliveryChk.CheckedChanged += DeliveryOptionChanged;
            pickUp.CheckedChanged += DeliveryOptionChanged;
            grid.CellEndEdit += grid_CellEndEdit; 
        }

        private void LoadDishes()
        {
            dishes = DataStorage.LoadFromFile<Dish>("dishes.json") ?? new List<Dish>();
        }

        private void SaveDishes()
        {
            DataStorage.SaveToFile(dishes, "dishes.json");
        }

        private int GenerateOrderId()
        {
            var orders = DataStorage.LoadFromFile<Order>("orders.json") ?? new List<Order>();
            return (orders.Any() ? orders.Max(o => o.OrderId) : 0) + 1;
        }


        private void RenderDishes(List<Dish> filteredDishes = null)
        {
            flowLayoutPanelAdminDishes.Controls.Clear();
            var dishesToRender = filteredDishes ?? dishes;

            foreach (var dish in dishesToRender)
            {
                Panel panel = new Panel
                {
                    Width = 200,
                    Height = 280,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10)
                };

                PictureBox pic = new PictureBox
                {
                    Width = 180,
                    Height = 120,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Location = new Point(10, 10)
                };

                if (!string.IsNullOrEmpty(dish.ImagePath) && File.Exists(dish.ImagePath))
                {
                    pic.Image = Image.FromFile(dish.ImagePath);
                }

                Label lblName = new Label
                {
                    Text = dish.Name,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(10, 140)
                };

                Label lblPrice = new Label
                {
                    Text = $"${dish.Price:F2}",
                    AutoSize = true,
                    Location = new Point(10, 170)
                };

                panel.Controls.Add(pic);
                panel.Controls.Add(lblName);
                panel.Controls.Add(lblPrice);

                panel.Click += (s, e) => AddToOrder(dish);
                pic.Click += (s, e) => AddToOrder(dish);
                lblName.Click += (s, e) => AddToOrder(dish);
                lblPrice.Click += (s, e) => AddToOrder(dish);

                flowLayoutPanelAdminDishes.Controls.Add(panel);
            }
        }

        private void AddToOrder(Dish dish)
        {
            currentOrder.Dishes.Add(new Dish
            {
                Name = dish.Name,
                Price = dish.Price,
                ImagePath = dish.ImagePath
            });
            RefreshOrderDisplay();
        }


        private void RefreshOrderDisplay()
        {
            grid.Rows.Clear();

            var grouped = currentOrder.Dishes
                .GroupBy(d => d.Name)
                .Select(g => new
                {
                    Name = g.Key,
                    Quantity = g.Count(),
                    UnitPrice = g.First().Price,
                    TotalPrice = g.Sum(d => d.Price)
                });

            foreach (var item in grouped)
            {
                int rowIndex = grid.Rows.Add(item.Name, item.Quantity, $"${item.TotalPrice:F2}");
                grid.Rows[rowIndex].Cells["Prices"].Tag = item.UnitPrice;
            }

            decimal subtotal = currentOrder.Total;
            decimal finalTotal = subtotal;

            if (deliveryChk.Checked && !pickUp.Checked)
            {
                grid.Rows.Add("Delivery Fee", 1, $"${deliveryCharge:F2}");
                finalTotal += deliveryCharge;
            }

            total.Text = $"${finalTotal:F2}";
        }

        private void confirmOrder_Click(object sender, EventArgs e)
        {
            if (currentOrder.Dishes.Count == 0)
            {
                MessageBox.Show("No items in the order.");
                return;
            }

            if (deliveryChk.Checked && !pickUp.Checked)
            {
                if (string.IsNullOrWhiteSpace(loggedInUser.Address))
                {
                    MessageBox.Show("Please add a delivery address in your profile before selecting delivery.",
                                    "Missing Address", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                userAddress.Address = loggedInUser.Address;

                currentOrder.Dishes.Add(new Dish
                {
                    Name = "Delivery Fee",
                    Price = deliveryCharge
                });
            }

            currentOrder.OrderId = GenerateOrderId();
            currentOrder.Status = "Received";
            currentOrder.Username = loggedInUser.Username;
            currentOrder.Address = deliveryChk.Checked ? loggedInUser.Address : "Pickup";

            var orders = DataStorage.LoadFromFile<Order>("orders.json") ?? new List<Order>();
            orders.Add(currentOrder);
            DataStorage.SaveToFile(orders, "orders.json");


            MessageBox.Show("Order confirmed!");

            currentOrder = new Order();
            RefreshOrderDisplay();


            deliveryChk.Checked = false;
            pickUp.Checked = false;
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            menuDish form = new menuDish();
            if (form.ShowDialog() == DialogResult.OK)
            {
                dishes.Add(form.DishResult);
                SaveDishes();
                RenderDishes();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string inputName = Interaction.InputBox("Enter the name of the dish to edit:", "Edit Dish");
            if (string.IsNullOrWhiteSpace(inputName)) return;

            var dish = dishes.FirstOrDefault(d => d.Name.Equals(inputName, StringComparison.OrdinalIgnoreCase));
            if (dish == null)
            {
                MessageBox.Show("Dish not found.");
                return;
            }

            menuDish editForm = new menuDish(dish);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                int index = dishes.IndexOf(dish);
                dishes[index] = editForm.DishResult;
                SaveDishes();
                RenderDishes();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string inputName = Interaction.InputBox("Enter the name of the dish to delete:", "Delete Dish");
            if (string.IsNullOrWhiteSpace(inputName)) return;

            var dish = dishes.FirstOrDefault(d => d.Name.Equals(inputName, StringComparison.OrdinalIgnoreCase));
            if (dish == null)
            {
                MessageBox.Show("Dish not found.");
                return;
            }

            if (MessageBox.Show($"Delete '{dish.Name}'?", "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dishes.Remove(dish);
                SaveDishes();
                RenderDishes();
            }
        }

        private void cancelOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Cancel the current order?", "Confirm", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                deliveryChk.Checked = false;
                currentOrder = new Order();
                RefreshOrderDisplay();
            }
        }

        private void myProfile_Click(object sender, EventArgs e)
        {
            FormUser profileForm = new FormUser(loggedInUser);
            if (profileForm.ShowDialog() == DialogResult.OK)
            {
                loggedInUser = profileForm.UpdatedUser;

                var users = DataStorage.LoadFromFile<User>("user.json") ?? new List<User>();
                var existingUser = users.FirstOrDefault(u => u.Username == loggedInUser.Username);

                if (existingUser != null)
                {
                    existingUser.Address = loggedInUser.Address;
                    existingUser.Password = loggedInUser.Password;
                }
                else
                {
                    users.Add(loggedInUser);
                }

                DataStorage.SaveToFile(users, "user.json");
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string keyword = searchTxtBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                RenderDishes();
                return;
            }

            var filteredDishes = dishes
                .Where(d => d.Name != null && d.Name.ToLower().Contains(keyword.ToLower()))
                .ToList();

            RenderDishes(filteredDishes);
        }

        private void DeliveryOptionChanged(object sender, EventArgs e)
        {
            if (sender == deliveryChk && deliveryChk.Checked)
                pickUp.Checked = false;
            else if (sender == pickUp && pickUp.Checked)
                deliveryChk.Checked = false;

            RefreshOrderDisplay();
        }

        private void grid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.Columns[e.ColumnIndex].Name == "Quantity")
            {
                var row = grid.Rows[e.RowIndex];

                if (row.Cells["Quantity"].Value != null && row.Cells["Prices"].Tag != null)
                {
                    if (int.TryParse(row.Cells["Quantity"].Value.ToString(), out int quantity) &&
                        decimal.TryParse(row.Cells["Prices"].Tag.ToString(), out decimal unitPrice))
                    {
                        decimal newPrice = quantity * unitPrice;
                        row.Cells["Prices"].Value = $"${newPrice:0.00}";

                        string dishName = row.Cells["Items"].Value.ToString();

                        // Remove all existing dishes with this name
                        currentOrder.Dishes.RemoveAll(d => d.Name == dishName);

                        // Add dish instances equal to the quantity
                        var dishTemplate = dishes.FirstOrDefault(d => d.Name == dishName);
                        if (dishTemplate != null)
                        {
                            for (int i = 0; i < quantity; i++)
                            {
                                currentOrder.Dishes.Add(new Dish
                                {
                                    Name = dishTemplate.Name,
                                    Price = dishTemplate.Price,
                                    ImagePath = dishTemplate.ImagePath
                                });
                            }
                        }
                    }
                    else
                    {
                        row.Cells["Prices"].Value = "$0.00";
                    }
                }

                // Recalculate total:
                decimal newTotal = 0m;

                foreach (DataGridViewRow gridRow in grid.Rows)
                {
                    if (gridRow.Cells["Prices"].Value != null &&
                        decimal.TryParse(gridRow.Cells["Prices"].Value.ToString().Replace("$", ""), out decimal rowPrice))
                    {
                        newTotal += rowPrice;
                    }
                }

                if (deliveryChk.Checked && !pickUp.Checked)
                {
                    newTotal += deliveryCharge;
                }

                total.Text = $"${newTotal:0.00}";
            }
        }

        
    }
}
