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
    public partial class UserControl_CustomerDGV : UserControl
    {
        public UserControl_CustomerDGV()
        {
            InitializeComponent();
        }

        SQLiteConnection conn = new SQLiteConnection("Data Source=BewerbungDB.db");

        public void DGV_Customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserControl_CustomerDGV_Load(object sender, EventArgs e)
        {
            Show_Customer_Data();
        }

        private void Show_Customer_Data ()
        {
            conn.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM Kunden", conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds,"info");
            DGV_Customer.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void btn_CustomerAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            string stm = "INSERT INTO Kunden (Name, Nachname, EMail, Adresse) VALUES('" + tb_CustomerName.Text + "','" + tb_CustomerLastname.Text + "','" + tb_CustomerMail.Text + "','" + tb_CustomerAdress.Text + "')";
            SQLiteCommand cmd = new SQLiteCommand(stm, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Show_Customer_Data();
        }

        private void btn_CustomerDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            string stm = "DELETE FROM Kunden WHERE ID = '" + tb_CustomerID.Text + "' ";
            SQLiteCommand cmd = new SQLiteCommand(stm, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Show_Customer_Data();
        }

        private void btn_CustomerUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
