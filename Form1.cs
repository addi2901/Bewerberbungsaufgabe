using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Bewerber_CH_CIT
{
    public partial class Form1 : Form
    {
        //string Path = "BewerbungDB.db";
        //string cs = @"URI=file" + Application.StartupPath + "\\BewerbungDB.db";

        SQLiteConnection con; 
        SQLiteCommand cmd;
        SQLiteDataReader dr; 

        SQLiteConnection conn = new SQLiteConnection("Data Source=BewerbungDB.db");

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //userControl_Customer1.Hide();
            //userControl_Product1.Hide();
            userControl_ProductDGV1.Hide();
            //userControl_Invoice1.Hide();
            userControl_InvoiceDGV1.Hide();
        }

        //private void setConn()
        //{
        //    con = new SQLiteConnection("Data Source=Datenbank.db");
        //}

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            //Hide other User controls
            //userControl_Invoice1.Hide();
            userControl_InvoiceDGV1.Hide();
            //userControl_Product1.Hide();
            //userControl_Product1.Hide();
            //Show current User control
            //userControl_Customer1.Show();
            //userControl_Customer1.BringToFront();
            userControl_CustomerDGV1.Show();
            userControl_CustomerDGV1.BringToFront();
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            //Hide other User controls
            //userControl_Invoice1.Hide();
            userControl_InvoiceDGV1.Hide();
            //userControl_Customer1.Hide();
            userControl_CustomerDGV1.Hide();
            //Show current User control
            //userControl_Product1.Show();
            //userControl_Product1.BringToFront();
            userControl_ProductDGV1.Show();
            userControl_ProductDGV1.BringToFront();
        }

        private void btn_Invoice_Click(object sender, EventArgs e)
        {
            //Hide other User controls
            //userControl_Product1.Hide();
            userControl_ProductDGV1.Hide();
            //userControl_Customer1.Hide();
            userControl_CustomerDGV1.Hide();
            //Show current User control
            //userControl_Invoice1.Show();
            //userControl_Invoice1.BringToFront();
            userControl_InvoiceDGV1.Show();
            userControl_InvoiceDGV1.BringToFront();
        }




    }
}
