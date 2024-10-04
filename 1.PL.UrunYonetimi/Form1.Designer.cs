namespace _1.PL.UrunYonetimi
{
    partial class Form1
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
            txtName = new TextBox();
            txtPrice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            grpProdutcs = new GroupBox();
            dgvProduct = new DataGridView();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            grpProdutcs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(109, 21);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 23);
            txtName.TabIndex = 0;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(109, 53);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 23);
            txtPrice.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 29);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 2;
            label1.Text = "Product Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 61);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 3;
            label2.Text = "Product Price :";
            // 
            // grpProdutcs
            // 
            grpProdutcs.Controls.Add(dgvProduct);
            grpProdutcs.Controls.Add(btnUpdate);
            grpProdutcs.Controls.Add(txtPrice);
            grpProdutcs.Controls.Add(btnDelete);
            grpProdutcs.Controls.Add(txtName);
            grpProdutcs.Controls.Add(btnAdd);
            grpProdutcs.Controls.Add(label1);
            grpProdutcs.Controls.Add(label2);
            grpProdutcs.Location = new Point(60, 33);
            grpProdutcs.Name = "grpProdutcs";
            grpProdutcs.Size = new Size(274, 405);
            grpProdutcs.TabIndex = 4;
            grpProdutcs.TabStop = false;
            grpProdutcs.Text = "Product Screen";
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(19, 151);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            dgvProduct.Size = new Size(240, 232);
            dgvProduct.TabIndex = 8;
            dgvProduct.CellClick += dgvProduct_CellClick;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(184, 96);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(103, 96);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(22, 96);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpProdutcs);
            Name = "Form1";
            Text = "Form1";
            grpProdutcs.ResumeLayout(false);
            grpProdutcs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtName;
        private TextBox txtPrice;
        private Label label1;
        private Label label2;
        private GroupBox grpProdutcs;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView dgvProduct;
    }
}
