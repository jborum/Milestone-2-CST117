/*
 * Inventory Form
 * This program was written by Jason Borum
 * Date: April 1, 2018
 * Course: CST117
 * Instructor: Dr. Brandon Bass
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Initialize variables
            string category;
            string name;
            string number;
            decimal price;

            // Get variable from form
            category = txtCategory.Text;
            name = txtName.Text;
            number = txtNumber.Text;
            price = Convert.ToDecimal(txtPrice.Text);
            Inventory item1 = new Inventory(category, name, number, price);
            MessageBox.Show(string.Format("The new item added is {0}, {1}, {2}, {3} and there are a total of {4} items", item1.Category, item1.Name, item1.Number, item1.Price, item1.Quantity));

        }
    }
}
