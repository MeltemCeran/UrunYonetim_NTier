using BLL.UrunYonetimi.Managers.Concrete;
using BLL.UrunYonetimi.Models;

namespace _1.PL.UrunYonetimi
{
    public partial class Form1 : Form
    {
        ProductModel selectedProduct;
        ProductManager productManager = new ProductManager();
        public void ListAllProduct()
        {
            dgvProduct.DataSource = productManager.GetAll();
        }

        public Form1()
        {
            InitializeComponent();
            ListAllProduct();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Please fill all the textboxes!");
                return;
            }
            ProductModel productModel = new ProductModel();
            productModel.Name = txtName.Text;
            productModel.Price = Convert.ToInt32(txtPrice.Text);

            productManager.Create(productModel);
            ListAllProduct();
            ClearTextBox();
            MessageBox.Show("The product has successfully been added");
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedProduct = (ProductModel)dgvProduct.SelectedRows[0].DataBoundItem;
            lblSelectedProduct.Text = selectedProduct.Name;

            txtName.Text = selectedProduct.Name;
            txtPrice.Text = selectedProduct.Price.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null)
            {
                productManager.Delete(selectedProduct);
                ListAllProduct();
                ClearTextBox();
                selectedProduct = null;
                lblSelectedProduct.Text = "Selected Product";
                MessageBox.Show("The product has succesfully been deleted!");
            }
            else
                MessageBox.Show("Please select a product to deleted!");
        }

        public void ClearTextBox()
        {
            txtName.Clear();
            txtPrice.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null)
            {
                selectedProduct.Name = txtName.Text;
                selectedProduct.Price = Convert.ToInt32(txtPrice.Text);
                productManager.Update(selectedProduct);
                ListAllProduct();
                ClearTextBox();
                selectedProduct = null;
                lblSelectedProduct.Text = "Selected Product";
                MessageBox.Show("The product has succesfully been updated!");
            }
            else
                MessageBox.Show("Please select a product to update!");
        }
    }
}
