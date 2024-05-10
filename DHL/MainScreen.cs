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
using System.IO;
using System.Runtime.CompilerServices;

namespace DHL
{
    public partial class MainScreen : Form
    {
        SQLiteConnection myConn = new SQLiteConnection("Data Source=DHL.db;Version=3;");
        SQLiteCommand cmd = new SQLiteCommand();
        SQLiteDataAdapter da = new SQLiteDataAdapter();
        DataSet DataSet= new DataSet();
        DataTable dt;
        public MainScreen()
        {
            InitializeComponent();
        }

        private void shippernametxtbox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void gmlbl_Click(object sender, EventArgs e)
        {

        }

        private void refNolbl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void enveloperadiobtn_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void boxradiobtn_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void pckgweightnumUD_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void shipperaddytxtbox_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void naetxtbox_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void nametxtbox2_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void newShippingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isEnvelope = enveloperadiobtn.Checked;
            bool isBox = boxradiobtn.Checked;
            myConn.Open();
            cmd.Connection = myConn;
            cmd.CommandText = @"INSERT INTO Orders (RefNum, ShipperName, PckgType, PckgWeight, ShipperAdress, Destination, ConsigneeName1, ConsigneeName2)
                        VALUES (@ShipperName, @RefNum, @PckgType, @PckgWeight, @ShipperAdress, @Destination, @ConsigneeName1, @ConsigneeName2)";
            cmd.Parameters.AddWithValue("@RefNum", Refnumtxtbox.Text);
            cmd.Parameters.AddWithValue("ShipperName", shippernametxtbox.Text);
            cmd.Parameters.AddWithValue("PckgType", isEnvelope ? "Envelope" : (isBox ? "Box" : ""));
            cmd.Parameters.AddWithValue("PckgWeight", pckgweightnumUD.Value);
            cmd.Parameters.AddWithValue("ShipperAdress", shipperaddytxtbox.Text);
            cmd.Parameters.AddWithValue("Destination", comboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("ConsigneeName1", naetxtbox.Text);
            cmd.Parameters.AddWithValue("ConsigneeName2", nametxtbox2.Text);
            cmd.ExecuteNonQuery();
            myConn.Close();
            var writer = new StreamWriter("userLog.txt");
            writer.WriteLine($"DateTime.Now.ToString(\"dd/MM/yyyy h:mm:ss tt\")}} {{user}} {{action}} {{page}}");
            writer.Close();


        }

        private void updateExistingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string refNum = Refnumtxtbox.Text;
            bool isEnvelope = enveloperadiobtn.Checked;
            bool isBox = boxradiobtn.Checked;
            if (refNum != null)
            {
                myConn.Open();
                cmd.Connection = myConn;
                cmd.CommandText = @"UPDATE Orders SET ShipperName = @ShipperName, PckgType = @PckgType, PckgWeight = @PckgWeight, ShipperAdress = @ShipperAdress, Destination = @Destination, ConsigneeName1 = @ConsigneeName1, ConsigneeName2 = @ConsigneeName2 WHERE RefNum = @RefNum";
                cmd.Parameters.AddWithValue("@ShipperName", shippernametxtbox.Text);
                cmd.Parameters.AddWithValue("@PckgType", isEnvelope ? "Envelope" : (isBox ? "Box" : ""));
                cmd.Parameters.AddWithValue("@PckgWeight", pckgweightnumUD.Value);
                cmd.Parameters.AddWithValue("@ShipperAdress", shipperaddytxtbox.Text);
                cmd.Parameters.AddWithValue("@Destination", comboBox1.SelectedItem?.ToString());
                cmd.Parameters.AddWithValue("@ConsigneeName1", naetxtbox.Text);
                cmd.Parameters.AddWithValue("@ConsigneeName2", nametxtbox2.Text);
                cmd.Parameters.AddWithValue("@RefNum", refNum);
                cmd.ExecuteNonQuery();
                myConn.Close();

            }

        }

        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string refNum = Refnumtxtbox.Text;
            if (refNum != null)
            {
                DialogResult ms = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ms == DialogResult.Yes)
                {
                    myConn.Open();
                    cmd.Connection = myConn;
                    cmd.CommandText = @"DELETE FROM Orders WHERE RefNum = @RefNum";
                    cmd.Parameters.AddWithValue("@RefNum", refNum);
                    cmd.ExecuteNonQuery();
                    myConn.Close();


                    MessageBox.Show("Record deleted successfully.");
                }
            }
            string actionDate = DateTime.Now.ToString();
            var writer = new StreamWriter("userLog.txt");
            string result = actionDate + " | shahd ";
        }

        private void seachtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string searchKeyword = seachtxtbox.Text;
            SearchResult results = new SearchResult();

            myConn.Open();
            cmd.Connection = myConn;
            cmd.CommandText = "SELECT * FROM Orders WHERE ShipperName LIKE '%' || @SearchKeyword || '%'";
            cmd.Parameters.AddWithValue("@SearchKeyword", searchKeyword);
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            myConn.Close();

            results.newsearchDGV.DataSource = dt;

            results.Show();
            var writer = new StreamWriter("userLog.txt");
            writer.WriteLine($"DateTime.Now.ToString(\"dd/MM/yyyy h:mm:ss tt\")}} {{user}} {{action}} {{page}}");
            writer.Close();

        }
    }
}
