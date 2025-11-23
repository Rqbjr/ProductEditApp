using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestProject
{
    public partial class ProductEditForm : Form
    {
        private int productId;
        private bool isSaving;
        public ProductEditForm(int id)
        {
            productId = id;
            InitializeComponent();
        }
        public ProductEditForm(int id, string Name, string Category, int Quantity, decimal Price)
        {
            InitializeComponent();
            productId = id;
            NameTextBox.Text = Name;
            CategoryTextBox.Text = Category;
            QuantityTextBox.Text = Quantity.ToString();
            PriceTextBox.Text = Price.ToString("N2");
        }

        private void QuantityTextBoxValidating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(QuantityTextBox.Text, out int value) && value >= 0)
            {
                e.Cancel = false;
            }
            else
            {
                MessageBox.Show("Quantity should be set to a non-negative number");
                e.Cancel = true;
            }

        }

        private void PriceTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (decimal.TryParse(PriceTextBox.Text, out decimal value) && value >= 0)
            {
                e.Cancel = false;
            }
            else
            {
                MessageBox.Show("Price should be set to a positive valuie");
                e.Cancel = true;
            }

        }

        internal object[] GetData()
        {
            return new object[5] { productId, NameTextBox.Text, CategoryTextBox.Text, int.Parse(QuantityTextBox.Text), decimal.Parse(PriceTextBox.Text) };
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            isSaving = true;

            if (this.ValidateChildren())
            {
                isSaving = false;
                DialogResult = DialogResult.OK;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void NameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (isSaving)
            {
                if (NameTextBox.Text == string.Empty)
                {
                    e.Cancel = true;
                    MessageBox.Show("Name shouldn't be empty");
                }
            }
        }

        private void CategoryTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (isSaving)
            {
                if (QuantityTextBox.Text == string.Empty)
                {
                    e.Cancel = true;
                    MessageBox.Show("Quanity  shouldn't be empty");
                }
            }
        }
    }
}
