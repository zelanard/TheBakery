using System;
using System.Drawing;
using System.Windows.Forms;
using TheBakery.DataAccessLayer;
using TheBakery.GUI;
using TheBakery.LogicLayer;

namespace TheBakery
{
    public partial class TheBakery : Form
    {
        /// <summary>
        /// What is within this class is what creates
        /// and controls the looks and actions of an interactive GUI
        /// The one that controls this interactive GUI
        /// is also the one that can decide what comes into it
        /// the createion of the lists more or less just taking in the new infromtion and dispalying it
        /// </summary>
        public TheBakery()
        {
            InitializeComponent();
            PopulateCategories();
        }

        private void PopulateCategories()
        {
            string[] items = Logic.GetCategories();
            this.listBox1.Items.Clear();
            foreach (string item in items)
            {
                this.listBox1.Items.Add(item);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ListBox lb)
            {
                GetProducts(lb.SelectedIndex+1);
            }
        }

        private void GetProducts(int categoryId)
        {
            this.displayPanel.Controls.Clear();
            Product[] product = Logic.GetProducts(categoryId);
            int X = 5;
            int Y = 5;
            foreach (Product productItem in product)
            {
                DisplayProduct displayProduct = new DisplayProduct();
                displayProduct._Product = productItem;
                displayProduct.Location = new Point(X, Y);

                this.displayPanel.Controls.Add(displayProduct);
                X += 205;
            }
        }
    }
}
