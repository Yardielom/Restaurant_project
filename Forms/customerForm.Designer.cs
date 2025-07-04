namespace WindowsFormsApp1.Forms
{
    partial class customerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.allMenu = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.myProfile = new System.Windows.Forms.Button();
            this.panelOrderSummary = new System.Windows.Forms.Panel();
            this.pickUpChk = new System.Windows.Forms.CheckBox();
            this.deliveryChk = new System.Windows.Forms.CheckBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.Items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.total = new System.Windows.Forms.Label();
            this.orderTotal = new System.Windows.Forms.Label();
            this.confirmOrder = new System.Windows.Forms.Button();
            this.cancelOrder = new System.Windows.Forms.Button();
            this.orderTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanelCustomerDishes = new System.Windows.Forms.FlowLayoutPanel();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panelOrderSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Poplar Std", 62.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 99);
            this.label1.TabIndex = 0;
            this.label1.Text = "RESTAURANT";
            // 
            // allMenu
            // 
            this.allMenu.AutoSize = true;
            this.allMenu.BackColor = System.Drawing.Color.Orange;
            this.allMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.allMenu.Font = new System.Drawing.Font("Myanmar Text", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allMenu.Location = new System.Drawing.Point(18, 130);
            this.allMenu.Name = "allMenu";
            this.allMenu.Size = new System.Drawing.Size(184, 68);
            this.allMenu.TabIndex = 2;
            this.allMenu.Text = "All Items";
            this.allMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::WindowsFormsApp1.Properties.Resources.hd_morlinska;
            this.pictureBox7.Location = new System.Drawing.Point(340, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(71, 67);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 20;
            this.pictureBox7.TabStop = false;
            // 
            // myProfile
            // 
            this.myProfile.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.login;
            this.myProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.myProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myProfile.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myProfile.Location = new System.Drawing.Point(853, 29);
            this.myProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.myProfile.Name = "myProfile";
            this.myProfile.Size = new System.Drawing.Size(33, 31);
            this.myProfile.TabIndex = 40;
            this.myProfile.UseVisualStyleBackColor = true;
            this.myProfile.Click += new System.EventHandler(this.myProfile_Click);
            // 
            // panelOrderSummary
            // 
            this.panelOrderSummary.Controls.Add(this.pickUpChk);
            this.panelOrderSummary.Controls.Add(this.deliveryChk);
            this.panelOrderSummary.Controls.Add(this.grid);
            this.panelOrderSummary.Controls.Add(this.panel1);
            this.panelOrderSummary.Controls.Add(this.orderTitle);
            this.panelOrderSummary.Location = new System.Drawing.Point(608, 214);
            this.panelOrderSummary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelOrderSummary.Name = "panelOrderSummary";
            this.panelOrderSummary.Size = new System.Drawing.Size(307, 603);
            this.panelOrderSummary.TabIndex = 44;
            
            // 
            // pickUpChk
            // 
            this.pickUpChk.AutoSize = true;
            this.pickUpChk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pickUpChk.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickUpChk.Location = new System.Drawing.Point(169, 463);
            this.pickUpChk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pickUpChk.Name = "pickUpChk";
            this.pickUpChk.Size = new System.Drawing.Size(87, 33);
            this.pickUpChk.TabIndex = 9;
            this.pickUpChk.Text = "Pick Up";
            this.pickUpChk.UseVisualStyleBackColor = true;
            // 
            // deliveryChk
            // 
            this.deliveryChk.AutoSize = true;
            this.deliveryChk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deliveryChk.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryChk.Location = new System.Drawing.Point(48, 463);
            this.deliveryChk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deliveryChk.Name = "deliveryChk";
            this.deliveryChk.Size = new System.Drawing.Size(93, 33);
            this.deliveryChk.TabIndex = 8;
            this.deliveryChk.Text = "Delivery";
            this.deliveryChk.UseVisualStyleBackColor = true;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.BackgroundColor = System.Drawing.Color.White;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Items,
            this.Quantity,
            this.Prices});
            this.grid.Location = new System.Drawing.Point(19, 34);
            this.grid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grid.Name = "grid";
            this.grid.RowTemplate.Height = 24;
            this.grid.Size = new System.Drawing.Size(268, 421);
            this.grid.TabIndex = 5;
            // 
            // Items
            // 
            this.Items.HeaderText = "ITEM";
            this.Items.Name = "Items";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "QTY";
            this.Quantity.Name = "Quantity";
            // 
            // Prices
            // 
            this.Prices.HeaderText = "PRICE";
            this.Prices.Name = "Prices";
            this.Prices.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.total);
            this.panel1.Controls.Add(this.orderTotal);
            this.panel1.Controls.Add(this.confirmOrder);
            this.panel1.Controls.Add(this.cancelOrder);
            this.panel1.Location = new System.Drawing.Point(2, 500);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 100);
            this.panel1.TabIndex = 4;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(194, 7);
            this.total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(91, 48);
            this.total.TabIndex = 4;
            this.total.Text = "$37.5";
            // 
            // orderTotal
            // 
            this.orderTotal.AutoSize = true;
            this.orderTotal.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTotal.Location = new System.Drawing.Point(1, 7);
            this.orderTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderTotal.Name = "orderTotal";
            this.orderTotal.Size = new System.Drawing.Size(65, 34);
            this.orderTotal.TabIndex = 3;
            this.orderTotal.Text = "Total:";
            // 
            // confirmOrder
            // 
            this.confirmOrder.BackColor = System.Drawing.Color.Orange;
            this.confirmOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmOrder.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmOrder.Location = new System.Drawing.Point(2, 66);
            this.confirmOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confirmOrder.Name = "confirmOrder";
            this.confirmOrder.Size = new System.Drawing.Size(146, 32);
            this.confirmOrder.TabIndex = 1;
            this.confirmOrder.Text = "Confirm Order";
            this.confirmOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.confirmOrder.UseVisualStyleBackColor = false;
            this.confirmOrder.Click += new System.EventHandler(this.confirmOrder_Click);
            // 
            // cancelOrder
            // 
            this.cancelOrder.BackColor = System.Drawing.Color.MistyRose;
            this.cancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelOrder.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelOrder.ForeColor = System.Drawing.Color.Black;
            this.cancelOrder.Location = new System.Drawing.Point(153, 66);
            this.cancelOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelOrder.Name = "cancelOrder";
            this.cancelOrder.Size = new System.Drawing.Size(146, 32);
            this.cancelOrder.TabIndex = 2;
            this.cancelOrder.Text = "Cancel Order";
            this.cancelOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cancelOrder.UseVisualStyleBackColor = false;
            this.cancelOrder.Click += new System.EventHandler(this.cancelOrder_Click);
            // 
            // orderTitle
            // 
            this.orderTitle.AutoSize = true;
            this.orderTitle.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTitle.Location = new System.Drawing.Point(2, 2);
            this.orderTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderTitle.Name = "orderTitle";
            this.orderTitle.Size = new System.Drawing.Size(159, 37);
            this.orderTitle.TabIndex = 3;
            this.orderTitle.Text = "Current Order:";
            // 
            // flowLayoutPanelCustomerDishes
            // 
            this.flowLayoutPanelCustomerDishes.AutoScroll = true;
            this.flowLayoutPanelCustomerDishes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelCustomerDishes.Location = new System.Drawing.Point(27, 215);
            this.flowLayoutPanelCustomerDishes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanelCustomerDishes.Name = "flowLayoutPanelCustomerDishes";
            this.flowLayoutPanelCustomerDishes.Size = new System.Drawing.Size(569, 601);
            this.flowLayoutPanelCustomerDishes.TabIndex = 43;
            // 
            // SearchBtn
            // 
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(754, 29);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(61, 41);
            this.SearchBtn.TabIndex = 46;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Location = new System.Drawing.Point(585, 36);
            this.searchTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(165, 20);
            this.searchTxtBox.TabIndex = 45;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.myProfile);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.SearchBtn);
            this.panel2.Controls.Add(this.searchTxtBox);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Location = new System.Drawing.Point(9, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(956, 107);
            this.panel2.TabIndex = 47;
            // 
            // customerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 838);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelOrderSummary);
            this.Controls.Add(this.flowLayoutPanelCustomerDishes);
            this.Controls.Add(this.allMenu);
            this.Name = "customerForm";
            this.Text = "Forms";
            this.Load += new System.EventHandler(this.Forms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panelOrderSummary.ResumeLayout(false);
            this.panelOrderSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label allMenu;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button myProfile;
        private System.Windows.Forms.Panel panelOrderSummary;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Items;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prices;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label orderTotal;
        private System.Windows.Forms.Button confirmOrder;
        private System.Windows.Forms.Button cancelOrder;
        private System.Windows.Forms.Label orderTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCustomerDishes;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox pickUpChk;
        private System.Windows.Forms.CheckBox deliveryChk;
    }
}