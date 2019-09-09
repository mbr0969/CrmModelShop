namespace CrmUI {
    partial class ProductForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.nameProduct = new System.Windows.Forms.TextBox();
            this.nameProductLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.priceProduct = new System.Windows.Forms.NumericUpDown();
            this.priceProductLbl = new System.Windows.Forms.Label();
            this.countProduct = new System.Windows.Forms.NumericUpDown();
            this.countProductLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.priceProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // nameProduct
            // 
            this.nameProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameProduct.Location = new System.Drawing.Point(182, 9);
            this.nameProduct.Name = "nameProduct";
            this.nameProduct.Size = new System.Drawing.Size(270, 20);
            this.nameProduct.TabIndex = 0;
            // 
            // nameProductLbl
            // 
            this.nameProductLbl.AutoSize = true;
            this.nameProductLbl.Location = new System.Drawing.Point(12, 9);
            this.nameProductLbl.Name = "nameProductLbl";
            this.nameProductLbl.Size = new System.Drawing.Size(126, 13);
            this.nameProductLbl.TabIndex = 1;
            this.nameProductLbl.Text = "Введите наименование";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(362, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // priceProduct
            // 
            this.priceProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceProduct.DecimalPlaces = 2;
            this.priceProduct.Location = new System.Drawing.Point(182, 51);
            this.priceProduct.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.priceProduct.Name = "priceProduct";
            this.priceProduct.Size = new System.Drawing.Size(270, 20);
            this.priceProduct.TabIndex = 1;
            // 
            // priceProductLbl
            // 
            this.priceProductLbl.AutoSize = true;
            this.priceProductLbl.Location = new System.Drawing.Point(12, 58);
            this.priceProductLbl.Name = "priceProductLbl";
            this.priceProductLbl.Size = new System.Drawing.Size(106, 13);
            this.priceProductLbl.TabIndex = 4;
            this.priceProductLbl.Text = "Введите стоимость";
            // 
            // countProduct
            // 
            this.countProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countProduct.Location = new System.Drawing.Point(182, 106);
            this.countProduct.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.countProduct.Name = "countProduct";
            this.countProduct.Size = new System.Drawing.Size(270, 20);
            this.countProduct.TabIndex = 2;
            // 
            // countProductLbl
            // 
            this.countProductLbl.AutoSize = true;
            this.countProductLbl.Location = new System.Drawing.Point(12, 113);
            this.countProductLbl.Name = "countProductLbl";
            this.countProductLbl.Size = new System.Drawing.Size(110, 13);
            this.countProductLbl.TabIndex = 6;
            this.countProductLbl.Text = "Введите количество";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 234);
            this.Controls.Add(this.countProductLbl);
            this.Controls.Add(this.countProduct);
            this.Controls.Add(this.priceProductLbl);
            this.Controls.Add(this.priceProduct);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameProductLbl);
            this.Controls.Add(this.nameProduct);
            this.Name = "ProductForm";
            this.Text = "Товар";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.priceProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameProduct;
        private System.Windows.Forms.Label nameProductLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown priceProduct;
        private System.Windows.Forms.Label priceProductLbl;
        private System.Windows.Forms.NumericUpDown countProduct;
        private System.Windows.Forms.Label countProductLbl;
    }
}