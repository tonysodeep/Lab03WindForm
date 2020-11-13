using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProductOrder context = new ProductOrder();
            List<Product> products = context.Products.ToList();
            List<Order> orders = context.Orders.ToList();
            List<Invoice> invoices = context.Invoices.ToList();
            BindGrid(orders);
        }
        private void BindGrid(List<Order> orders)
        {
            dg_giao.Rows.Clear();
            foreach(var item in orders)
            {
                int j = 1;
                int index = dg_giao.Rows.Add();
                dg_giao.Rows[index].Cells[0].Value = j;
                dg_giao.Rows[index].Cells[1].Value = item.InvoiceNo;
                dg_giao.Rows[index].Cells[2].Value = item.Invoice.OrderDate;
                dg_giao.Rows[index].Cells[3].Value = item.Invoice.DeliveryDate;
                dg_giao.Rows[index].Cells[4].Value = item.Product.SellPrice;
                j++;
            }
        }
    }
}
