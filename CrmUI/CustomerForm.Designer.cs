﻿namespace CrmUI {
    partial class CustomerForm {
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
            this.nameCustomer = new System.Windows.Forms.TextBox();
            this.nameCustomerLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameCustomer
            // 
            this.nameCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameCustomer.Location = new System.Drawing.Point(117, 9);
            this.nameCustomer.Name = "nameCustomer";
            this.nameCustomer.Size = new System.Drawing.Size(253, 20);
            this.nameCustomer.TabIndex = 0;
            // 
            // nameCustomerLbl
            // 
            this.nameCustomerLbl.AutoSize = true;
            this.nameCustomerLbl.Location = new System.Drawing.Point(12, 9);
            this.nameCustomerLbl.Name = "nameCustomerLbl";
            this.nameCustomerLbl.Size = new System.Drawing.Size(72, 13);
            this.nameCustomerLbl.TabIndex = 1;
            this.nameCustomerLbl.Text = "Введите имя";
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
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 234);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameCustomerLbl);
            this.Controls.Add(this.nameCustomer);
            this.Name = "CustomerForm";
            this.Text = "Покупатель";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameCustomer;
        private System.Windows.Forms.Label nameCustomerLbl;
        private System.Windows.Forms.Button button1;
    }
}