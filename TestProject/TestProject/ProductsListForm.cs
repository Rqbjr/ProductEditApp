using Azure.Core.GeoJson;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Linq;
namespace TestProject
{
    public partial class ProductsListForm : Form
    {
        public ProductsListForm()
        {
            InitializeComponent();
            ProductsDataGridView.AutoGenerateColumns = false;
        }

        private void RefreshProductButtonMouseClick(object sender, MouseEventArgs e)
        {
            RefreshProducts();
        }
        private void AddProductButton_MouseClick(object sender, MouseEventArgs e)
        {
            AddProduct();
        }
        private void EditProductButton_MouseClick(object sender, MouseEventArgs e)
        {
            EditProduct();
        }
        private void DeleteProductButton_MouseClick(object sender, MouseEventArgs e)
        {
            DeleteProduct();
        }
        private void ProductsSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            SetFilter();
        }
      
        private void SetFilter()
        {
            (ProductsDataGridView.DataSource as DataView).RowFilter = string.Format("Name like '{0}%'", ProductsSearchTextBox.Text);
        }

        private void DeleteProduct()
        {
            if (MessageBox.Show("Do you want to delete a product", "Product delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DeleteProduct((int)ProductsDataGridView.SelectedCells[0].OwningRow.Cells["IdColumn"].Value);
            }
            RefreshProducts();

        }

        private void EditProduct()
        {
            ProductEditForm form
                = new ProductEditForm(
                    (int)ProductsDataGridView.SelectedCells[0].OwningRow.Cells["IdColumn"].Value,
                    (string)ProductsDataGridView.SelectedCells[0].OwningRow.Cells["NameColumn"].Value,
                    (string)ProductsDataGridView.SelectedCells[0].OwningRow.Cells["CategoryColumn"].Value,
                    (int)ProductsDataGridView.SelectedCells[0].OwningRow.Cells["QuantityColumn"].Value,
                    (decimal)ProductsDataGridView.SelectedCells[0].OwningRow.Cells["PriceColumn"].Value);
            if (form.ShowDialog() == DialogResult.OK)
            {
                var data = form.GetData();

                UpdateProduct((int)data[0], (string)data[1], (string)data[2], (int)data[3], (decimal)data[4]);
            }
            RefreshProducts();
        }

        private void AddProduct()
        {
            ProductEditForm form = new ProductEditForm(0);
            if (form.ShowDialog() == DialogResult.OK)
            {
                var data = form.GetData();

                InsertProduct((string)data[1], (string)data[2], (int)data[3], (decimal)data[4]);
            }
            RefreshProducts();
        }

        private void RefreshProducts()
        {
            DataTable dt = GetProductList();
            DataView dv = new DataView(dt);
            ProductsDataGridView.DataSource = dv;
        }
        private DataTable GetProductList()
        {

            string sql = "SELECT ProductID, Name, Category, Quantity, Price, LastUpdated FROM dbo.Products";
            var dt = DBHelper.ExecuteSelectQuery(sql);
            return dt;
        }
        private int InsertProduct(string name, string category, int quantity, decimal price)
        {
            string sql = @"
                INSERT INTO Products (Name, Category, Quantity, Price, LastUpdated)
                VALUES (@name, @category, @quantity, @price, GETDATE());";

            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@name", name),
                new SqlParameter("@category", category),
                new SqlParameter("@quantity", quantity),
                new SqlParameter("@price", price)
            };

            return DBHelper.ExecuteWithParameters(sql, parameters);
        }
        private int UpdateProduct(int id, string name, string category, int quantity, decimal price)
        {
            string sql = @"
                UPDATE Products
                SET Name = @name,
                    Category = @category,
                    Quantity = @quantity,
                    Price = @price,
                    LastUpdated = GETDATE()
                WHERE ProductID = @id";

            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@id", id),
                new SqlParameter("@name", name),
                new SqlParameter("@category", category),
                new SqlParameter("@quantity", quantity),
                new SqlParameter("@price", price)
            };

            return DBHelper.ExecuteWithParameters(sql, parameters);
        }
        private int DeleteProduct(int id)
        {
            string sql = "DELETE FROM Products WHERE ProductID = @id";

            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@id", id)
            };

            return DBHelper.ExecuteWithParameters(sql, parameters);
        }

        private void ProductsEditForm_Load(object sender, EventArgs e)
        {
            DBHelper.ConnectionString = DBHelper.ReadConnectionStringFromFile("./config");
            RefreshProducts();
        }

         }
}
