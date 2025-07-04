namespace WindowsFormsApp1.Forms
{
    partial class FormUser
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
            this.UserName = new System.Windows.Forms.Label();
            this.pasWrd = new System.Windows.Forms.Label();
            this.adress = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.pastOrders = new System.Windows.Forms.Label();
            this.logOtBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.deleteAccount = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(77, 119);
            this.UserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(118, 34);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "USERNAME";
            // 
            // pasWrd
            // 
            this.pasWrd.AutoSize = true;
            this.pasWrd.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasWrd.Location = new System.Drawing.Point(77, 180);
            this.pasWrd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pasWrd.Name = "pasWrd";
            this.pasWrd.Size = new System.Drawing.Size(121, 34);
            this.pasWrd.TabIndex = 2;
            this.pasWrd.Text = "PASSWORD";
            // 
            // adress
            // 
            this.adress.AutoSize = true;
            this.adress.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adress.Location = new System.Drawing.Point(77, 244);
            this.adress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(86, 34);
            this.adress.TabIndex = 3;
            this.adress.Text = "ADRESS";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(82, 150);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(224, 20);
            this.textBoxUsername.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(82, 210);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(224, 20);
            this.textBoxPassword.TabIndex = 5;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(82, 274);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(224, 30);
            this.textBoxAddress.TabIndex = 6;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Orange;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(72, 343);
            this.Save.Margin = new System.Windows.Forms.Padding(2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(98, 35);
            this.Save.TabIndex = 7;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.MistyRose;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(206, 343);
            this.Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(100, 35);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poplar Std", 51.74999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 82);
            this.label1.TabIndex = 9;
            this.label1.Text = "MY PROFILE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 99);
            this.panel1.TabIndex = 10;
            // 
            // flowLayoutPanelOrders
            // 
            this.flowLayoutPanelOrders.Location = new System.Drawing.Point(362, 174);
            this.flowLayoutPanelOrders.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelOrders.Name = "flowLayoutPanelOrders";
            this.flowLayoutPanelOrders.Size = new System.Drawing.Size(384, 250);
            this.flowLayoutPanelOrders.TabIndex = 11;
            // 
            // pastOrders
            // 
            this.pastOrders.AutoSize = true;
            this.pastOrders.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pastOrders.Location = new System.Drawing.Point(356, 136);
            this.pastOrders.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pastOrders.Name = "pastOrders";
            this.pastOrders.Size = new System.Drawing.Size(140, 34);
            this.pastOrders.TabIndex = 12;
            this.pastOrders.Text = "PAST ORDERS";
            // 
            // logOtBtn
            // 
            this.logOtBtn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.logOut;
            this.logOtBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logOtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOtBtn.Location = new System.Drawing.Point(788, 119);
            this.logOtBtn.Name = "logOtBtn";
            this.logOtBtn.Size = new System.Drawing.Size(34, 31);
            this.logOtBtn.TabIndex = 13;
            this.logOtBtn.UseVisualStyleBackColor = true;
            this.logOtBtn.Click += new System.EventHandler(this.logOtBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.hd_morlinska;
            this.pictureBox1.Location = new System.Drawing.Point(361, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // deleteAccount
            // 
            this.deleteAccount.BackColor = System.Drawing.Color.MistyRose;
            this.deleteAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAccount.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAccount.Location = new System.Drawing.Point(667, 463);
            this.deleteAccount.Name = "deleteAccount";
            this.deleteAccount.Size = new System.Drawing.Size(156, 35);
            this.deleteAccount.TabIndex = 14;
            this.deleteAccount.Text = "X  Delete Account";
            this.deleteAccount.UseVisualStyleBackColor = false;
            this.deleteAccount.Click += new System.EventHandler(this.deleteAccount_Click);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 529);
            this.Controls.Add(this.deleteAccount);
            this.Controls.Add(this.logOtBtn);
            this.Controls.Add(this.pastOrders);
            this.Controls.Add(this.flowLayoutPanelOrders);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.pasWrd);
            this.Controls.Add(this.UserName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormUser";
            this.Text = "FormUser";
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label pasWrd;
        private System.Windows.Forms.Label adress;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOrders;
        private System.Windows.Forms.Label pastOrders;
        private System.Windows.Forms.Button logOtBtn;
        private System.Windows.Forms.Button deleteAccount;
    }
}