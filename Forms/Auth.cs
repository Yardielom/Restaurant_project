using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.models;
using WindowsFormsApp1.Utils;

namespace WindowsFormsApp1.Forms
{
    public partial class Auth : Form
    {
        private List<User> users = new List<User>();
        private const string UsersFileName = "users.json";  

        public Auth()
        {
            InitializeComponent();
        }

        private void SaveUsers()
        {
            DataStorage.SaveToFile(users, UsersFileName);
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            users = DataStorage.LoadFromFile<User>(UsersFileName);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password are required.");
                return;
            }

            foreach (var u in users)
            {
                if (u.Username == username)
                {
                    MessageBox.Show("User already exists.");
                    return;
                }
            }

            DialogResult result = MessageBox.Show(
                "Do you want to register as an Admin?\nClick 'Yes' for Admin, 'No' for Customer.",
                "Choose Role",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Cancel)
            {
                return;
            }

            string role = "user";
            if (result == DialogResult.Yes)
            {
                role = "admin";
            }

            User newUser = new User
            {
                Username = username,
                Password = password,
                Role = role
            };

            users.Add(newUser);
            SaveUsers();

            MessageBox.Show("User registered successfully as " + role + "!");

            if (role == "admin")
            {
                AdminForms adminForm = new AdminForms(newUser);
                adminForm.Show();
            }
            else
            {
                customerForm custForm = new customerForm(newUser);
                custForm.Show();
            }

            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            var user = users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                MessageBox.Show($"Login successful! Role: {user.Role}");

                if (user.Role == "admin")
                {
                    var adminForm = new AdminForms(user);
                    adminForm.Show();
                }
                else
                {
                    var customerForm = new customerForm(user); 
                    customerForm.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

    
    }
}

