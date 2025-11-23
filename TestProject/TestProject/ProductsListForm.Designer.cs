namespace TestProject
{
    partial class ProductsListForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddProductButton = new Button();
            EditProductButton = new Button();
            DeleteProductButton = new Button();
            RefreshProductButton = new Button();
            ProductsSearchTextBox = new TextBox();
            ProductsDataGridView = new DataGridView();
            NameColumn = new DataGridViewTextBoxColumn();
            IdColumn = new DataGridViewTextBoxColumn();
            CategoryColumn = new DataGridViewTextBoxColumn();
            QuantityColumn = new DataGridViewTextBoxColumn();
            PriceColumn = new DataGridViewTextBoxColumn();
            LastUpdatedColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // AddProductButton
            // 
            AddProductButton.Location = new Point(10, 323);
            AddProductButton.Margin = new Padding(2);
            AddProductButton.Name = "AddProductButton";
            AddProductButton.Size = new Size(90, 27);
            AddProductButton.TabIndex = 0;
            AddProductButton.Text = "Add";
            AddProductButton.UseVisualStyleBackColor = true;
            AddProductButton.MouseClick += AddProductButton_MouseClick;
            // 
            // EditProductButton
            // 
            EditProductButton.Location = new Point(189, 323);
            EditProductButton.Margin = new Padding(2);
            EditProductButton.Name = "EditProductButton";
            EditProductButton.RightToLeft = RightToLeft.Yes;
            EditProductButton.Size = new Size(90, 27);
            EditProductButton.TabIndex = 1;
            EditProductButton.Text = "Edit";
            EditProductButton.UseVisualStyleBackColor = true;
            EditProductButton.MouseClick += EditProductButton_MouseClick;
            // 
            // DeleteProductButton
            // 
            DeleteProductButton.Location = new Point(541, 323);
            DeleteProductButton.Margin = new Padding(2);
            DeleteProductButton.Name = "DeleteProductButton";
            DeleteProductButton.Size = new Size(90, 27);
            DeleteProductButton.TabIndex = 2;
            DeleteProductButton.Text = "Delete";
            DeleteProductButton.UseVisualStyleBackColor = true;
            DeleteProductButton.MouseClick += DeleteProductButton_MouseClick;
            // 
            // RefreshProductButton
            // 
            RefreshProductButton.Location = new Point(377, 323);
            RefreshProductButton.Margin = new Padding(2);
            RefreshProductButton.Name = "RefreshProductButton";
            RefreshProductButton.Size = new Size(90, 27);
            RefreshProductButton.TabIndex = 3;
            RefreshProductButton.Text = "Refresh";
            RefreshProductButton.UseVisualStyleBackColor = true;
            RefreshProductButton.MouseClick += RefreshProductButtonMouseClick;
            // 
            // ProductsSearchTextBox
            // 
            ProductsSearchTextBox.Location = new Point(18, 10);
            ProductsSearchTextBox.Margin = new Padding(2);
            ProductsSearchTextBox.Name = "ProductsSearchTextBox";
            ProductsSearchTextBox.Size = new Size(188, 27);
            ProductsSearchTextBox.TabIndex = 4;
            ProductsSearchTextBox.TextChanged += ProductsSearchTextBox_TextChanged;
            // 
            // ProductsDataGridView
            // 
            ProductsDataGridView.AllowUserToAddRows = false;
            ProductsDataGridView.AllowUserToDeleteRows = false;
            ProductsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, IdColumn, CategoryColumn, QuantityColumn, PriceColumn, LastUpdatedColumn });
            ProductsDataGridView.Location = new Point(18, 48);
            ProductsDataGridView.Margin = new Padding(2);
            ProductsDataGridView.Name = "ProductsDataGridView";
            ProductsDataGridView.RowHeadersVisible = false;
            ProductsDataGridView.RowHeadersWidth = 62;
            ProductsDataGridView.Size = new Size(605, 254);
            ProductsDataGridView.TabIndex = 6;
            // 
            // NameColumn
            // 
            NameColumn.DataPropertyName = "Name";
            NameColumn.HeaderText = "Name";
            NameColumn.MinimumWidth = 8;
            NameColumn.Name = "NameColumn";
            NameColumn.Width = 150;
            // 
            // IdColumn
            // 
            IdColumn.DataPropertyName = "ProductId";
            IdColumn.HeaderText = "Column1";
            IdColumn.MinimumWidth = 8;
            IdColumn.Name = "IdColumn";
            IdColumn.ReadOnly = true;
            IdColumn.Visible = false;
            IdColumn.Width = 150;
            // 
            // CategoryColumn
            // 
            CategoryColumn.DataPropertyName = "Category";
            CategoryColumn.HeaderText = "Category";
            CategoryColumn.MinimumWidth = 8;
            CategoryColumn.Name = "CategoryColumn";
            CategoryColumn.Width = 150;
            // 
            // QuantityColumn
            // 
            QuantityColumn.DataPropertyName = "Quantity";
            QuantityColumn.HeaderText = "Quantity";
            QuantityColumn.MinimumWidth = 8;
            QuantityColumn.Name = "QuantityColumn";
            QuantityColumn.Width = 150;
            // 
            // PriceColumn
            // 
            PriceColumn.DataPropertyName = "Price";
            PriceColumn.HeaderText = "Price";
            PriceColumn.MinimumWidth = 8;
            PriceColumn.Name = "PriceColumn";
            PriceColumn.Width = 150;
            // 
            // LastUpdatedColumn
            // 
            LastUpdatedColumn.DataPropertyName = "LastUpdated";
            LastUpdatedColumn.HeaderText = "Last Updated";
            LastUpdatedColumn.MinimumWidth = 8;
            LastUpdatedColumn.Name = "LastUpdatedColumn";
            LastUpdatedColumn.ReadOnly = true;
            LastUpdatedColumn.Width = 150;
            // 
            // ProductsListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(ProductsDataGridView);
            Controls.Add(ProductsSearchTextBox);
            Controls.Add(RefreshProductButton);
            Controls.Add(DeleteProductButton);
            Controls.Add(EditProductButton);
            Controls.Add(AddProductButton);
            Margin = new Padding(2);
            Name = "ProductsListForm";
            Text = "Products editor";
            Load += ProductsEditForm_Load;
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddProductButton;
        private Button EditProductButton;
        private Button DeleteProductButton;
        private Button RefreshProductButton;
        private TextBox ProductsSearchTextBox;
        private DataGridView ProductsDataGridView;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn CategoryColumn;
        private DataGridViewTextBoxColumn QuantityColumn;
        private DataGridViewTextBoxColumn PriceColumn;
        private DataGridViewTextBoxColumn LastUpdatedColumn;
    }
}
