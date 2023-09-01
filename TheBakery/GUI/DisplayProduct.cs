using System.Drawing;
using System.Windows.Forms;
using TheBakery.DataAccessLayer;

namespace TheBakery.GUI
{

        /// <summary>
        /// this class stands for the creationof the "boxes" in the display
        /// it infroms about the price, descreption, name, prep time, potions.
        /// it is also supposed to hold servural other options that are not active at the moment
        /// such as a piture palce holder that puts a piture into the dispaly box
        /// </summary>
    internal class DisplayProduct : Control
    {
        private Product _product;

        public Product _Product
        {
            get { return _product; }
            set
            {
                ProductName.Text = value.Name;
                ProductPrice.Text = value.Price;
                ProductDescription.Text = value.Description;
            }
        }

        public DisplayProduct()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Visible = true;
            this.Size = new Size(200, 200);
            this.BackColor = Color.LightBlue;

            this.ProductName = new Label();
            this.ProductPrice = new Label();
            this.ProductDescription = new Label();

            //
            // Product Name
            //
            this.ProductName.Width = this.Width;
            this.ProductName.TextAlign = ContentAlignment.MiddleCenter;
            this.ProductName.Location = new Point(this.Width / 2 - this.ProductName.Width / 2, 190 - this.ProductName.Height - this.ProductPrice.Height - this.ProductDescription.Height);

            //
            // Product Price
            //
            this.ProductPrice.Width = this.Width;
            this.ProductPrice.TextAlign = ContentAlignment.MiddleCenter;
            this.ProductPrice.Location = new Point(this.Width / 2 - this.ProductPrice.Width / 2, 190 - this.ProductPrice.Height - this.ProductDescription.Height);

            //
            // Product Description
            //
            this.ProductDescription.Width = this.Width;
            this.ProductDescription.TextAlign = ContentAlignment.MiddleCenter;
            this.ProductDescription.Location = new Point(this.Width / 2 - this.ProductDescription.Width / 2, 190 - this.ProductDescription.Height);

            //
            // Product Panel
            //
            this.ProductPanel = new Panel();
            this.ProductPanel.BackColor = Color.White;
            this.ProductPanel.Size = new Size(190, 190);
            this.ProductPanel.Location = new Point(5, 5);
            this.ProductPanel.Visible = true;

            this.ProductPanel.Controls.Add(ProductPrice);
            this.ProductPanel.Controls.Add(ProductDescription);
            this.ProductPanel.Controls.Add(ProductName);
            this.Controls.Add(ProductPanel);
        }

        private Panel ProductPanel;
        private PictureBox ProductPicture;
        private Label ProductName;
        private Label ProductPrice;
        private Label ProductDescription;
        private Button Purchase;
    }
}
