/** =========================================================
 Name:Omar Ahmad
 Operating System (Windows 8.1)
 Microsoft Visual Studio 2017
 CIS 169 C# 
M11: Write SQL Statement.
This program returns all rows, stored price in ascending order and also it returns only the rows with more than 100.
 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.
=========================================================== **/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Queries
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDBDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productDBDataSet.Product);

        }

        private void sortByPriceButton_Click(object sender, EventArgs e)
        {
            this.productTableAdapter.FillByPrice(this.productDBDataSet.Product);
        }

        private void unitsGreater100Button_Click(object sender, EventArgs e)
        {
            this.productTableAdapter.FillByUnits(this.productDBDataSet.Product);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.productTableAdapter.FillByUnits1(this.productDBDataSet.Product);
        }
    }
}
