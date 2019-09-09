﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrmBL.Model;

namespace CrmUI {
    public partial class Catalog<T> : Form  where T: class {
       CrmContext db;
       DbSet<T> set;

        public Catalog(DbSet<T> set, CrmContext db) {
            InitializeComponent();
            this.db = db;
            this.set = set;
            set.Load();
            dataGridView.DataSource = set.Local.ToBindingList();
            
        }

        private void Catalog_Load(object sender, EventArgs e) {
            
        }

        private void addBtn_Click(object sender, EventArgs e) {
            if (typeof(T) ==typeof(Product)) {

            } else if(typeof(T) == typeof(Seller)) {
                
            } else if (typeof(T) == typeof(Customer)) {

            }
        }

        private void changeBtn_Click(object sender, EventArgs e) {
            var id =dataGridView.SelectedRows[0].Cells[0].Value;

            if (typeof(T) == typeof(Product)) {

                var product = set.Find(id) as Product;
                if (product != null) {
                    var form = new ProductForm(product);
                    if (form.ShowDialog() == DialogResult.OK) {
                        product = form.Product;
                        db.SaveChanges();
                    }
                }
            }
            else if(typeof(T) == typeof(Seller)) {
                var seller = set.Find(id) as Seller;
                if (seller != null) {
                    var form = new SellerForm(seller);
                    if (form.ShowDialog() == DialogResult.OK) {
                        seller = form.Seller;
                        db.SaveChanges();
                    }
                }
            } else if (typeof(T) == typeof(Customer)) {
                var customer = set.Find(id) as Customer;
                if (customer != null) {
                    var form = new CustomerForm(customer);
                    if (form.ShowDialog() == DialogResult.OK) {
                        customer = form.Customer;
                        db.SaveChanges();
                    }
                }
            }

        }

        private void Update(T item, Form form ) {
           
            }
        }

    }

