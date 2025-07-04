using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApp1.models;

namespace WindowsFormsApp1.Forms
{
    public partial class menuDish : Form
    {
        private Dish editingDish;

        public menuDish()
        {
            InitializeComponent();
        }

        public menuDish(Dish dishToEdit) : this()
        {
            editingDish = dishToEdit;

            txtName.Text = editingDish.Name;
            txtPrice.Text = editingDish.Price.ToString();

            if (File.Exists(editingDish.ImagePath))
            {
              
                string tempFile = Path.GetTempFileName();
                File.Copy(editingDish.ImagePath, tempFile, true);

                using (var img = Image.FromFile(tempFile))
                {
                    pictureBoxPreview.Image = new Bitmap(img);
                }
                pictureBoxPreview.Tag = tempFile; 
            }
        }

        public Dish DishResult { get; private set; }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                string tempFile = Path.GetTempFileName();
                File.Copy(openFileDialog.FileName, tempFile, true);

                
                if (pictureBoxPreview.Image != null)
                {
                    pictureBoxPreview.Image.Dispose();
                    pictureBoxPreview.Image = null;
                }

                using (var img = Image.FromFile(tempFile))
                {
                    pictureBoxPreview.Image = new Bitmap(img);
                }

                pictureBoxPreview.Tag = tempFile; 
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string priceText = txtPrice.Text.Trim();
            string tempImagePath = pictureBoxPreview.Tag as string;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(priceText) || string.IsNullOrEmpty(tempImagePath))
            {
                MessageBox.Show("Please enter all fields and select an image.");
                return;
            }

            if (!decimal.TryParse(priceText, out decimal price))
            {
                MessageBox.Show("Invalid price.");
                return;
            }

            string imagesFolder = Path.Combine(Application.StartupPath, "Resources", "Images");
            Directory.CreateDirectory(imagesFolder);

            string fileName = $"{Guid.NewGuid()}.jpg"; 
            string newImagePath = Path.Combine(imagesFolder, fileName);

            try
            {
                File.Copy(tempImagePath, newImagePath, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not copy image: " + ex.Message);
                return;
            }

            string relativePath = Path.Combine("Resources", "Images", fileName);

            DishResult = editingDish ?? new Dish();
            DishResult.Name = name;
            DishResult.Price = price;
            DishResult.ImagePath = relativePath;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void menuDish_Load(object sender, EventArgs e) { }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; Close();
        }
    }
}
