namespace TestProject
{
    partial class ProductEditForm
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
            NameLabel = new Label();
            CategoryLabel = new Label();
            PriceLabel = new Label();
            QuantityLabel = new Label();
            NameTextBox = new TextBox();
            PriceTextBox = new TextBox();
            QuantityTextBox = new TextBox();
            CategoryTextBox = new TextBox();
            CancelButton = new Button();
            SaveButton = new Button();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(41, 15);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(59, 25);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Name";
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(16, 52);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(84, 25);
            CategoryLabel.TabIndex = 1;
            CategoryLabel.Text = "Category";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(41, 126);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(49, 25);
            PriceLabel.TabIndex = 2;
            PriceLabel.Text = "Price";
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.Location = new Point(16, 89);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(80, 25);
            QuantityLabel.TabIndex = 3;
            QuantityLabel.Text = "Quantity";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(106, 12);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(319, 31);
            NameTextBox.TabIndex = 5;
            NameTextBox.Validating += NameTextBox_Validating;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(106, 123);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(319, 31);
            PriceTextBox.TabIndex = 6;
            PriceTextBox.Validating += PriceTextBox_Validating;
            // 
            // QuantityTextBox
            // 
            QuantityTextBox.Location = new Point(106, 86);
            QuantityTextBox.Name = "QuantityTextBox";
            QuantityTextBox.Size = new Size(319, 31);
            QuantityTextBox.TabIndex = 7;
            QuantityTextBox.Validating += QuantityTextBoxValidating;
            // 
            // CategoryTextBox
            // 
            CategoryTextBox.Location = new Point(106, 49);
            CategoryTextBox.Name = "CategoryTextBox";
            CategoryTextBox.Size = new Size(319, 31);
            CategoryTextBox.TabIndex = 8;
            CategoryTextBox.Validating += CategoryTextBox_Validating;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(182, 192);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(112, 34);
            CancelButton.TabIndex = 9;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(357, 192);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(112, 34);
            SaveButton.TabIndex = 10;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // ProductEditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 249);
            Controls.Add(SaveButton);
            Controls.Add(CancelButton);
            Controls.Add(CategoryTextBox);
            Controls.Add(QuantityTextBox);
            Controls.Add(PriceTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(QuantityLabel);
            Controls.Add(PriceLabel);
            Controls.Add(CategoryLabel);
            Controls.Add(NameLabel);
            Name = "ProductEditForm";
            Text = "ProductEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLabel;
        private Label CategoryLabel;
        private Label PriceLabel;
        private Label QuantityLabel;
        private TextBox NameTextBox;
        private TextBox PriceTextBox;
        private TextBox QuantityTextBox;
        private TextBox CategoryTextBox;
        private Button CancelButton;
        private Button SaveButton;
    }
}