namespace CrmUI {
    partial class SellerForm {
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
            this.nameSeller = new System.Windows.Forms.TextBox();
            this.nameSellerLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameSeller
            // 
            this.nameSeller.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameSeller.Location = new System.Drawing.Point(117, 9);
            this.nameSeller.Name = "nameSeller";
            this.nameSeller.Size = new System.Drawing.Size(253, 20);
            this.nameSeller.TabIndex = 0;
            // 
            // nameSellerLbl
            // 
            this.nameSellerLbl.AutoSize = true;
            this.nameSellerLbl.Location = new System.Drawing.Point(12, 9);
            this.nameSellerLbl.Name = "nameSellerLbl";
            this.nameSellerLbl.Size = new System.Drawing.Size(72, 13);
            this.nameSellerLbl.TabIndex = 1;
            this.nameSellerLbl.Text = "Введите имя";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(335, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 234);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameSellerLbl);
            this.Controls.Add(this.nameSeller);
            this.Name = "SellerForm";
            this.Text = "Продавец";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameSeller;
        private System.Windows.Forms.Label nameSellerLbl;
        private System.Windows.Forms.Button button1;
    }
}