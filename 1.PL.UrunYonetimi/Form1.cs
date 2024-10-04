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
            ProductModel productModel = new ProductModel();

            productModel.Name = txtName.Text;
            productModel.Price = Convert.ToInt32(txtPrice.Text);

            productManager.Create(productModel);
            ListAllProduct();
            MessageBox.Show("The product has successfully been added");

        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedProduct = (ProductModel)dgvProduct.SelectedRows[0].DataBoundItem;
        }
    }
}
