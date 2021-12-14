using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD50_1_19_MySQL
{
    public partial class PerfomanceEdit : MaterialSkin.Controls.MaterialForm

    {
        public PerfomanceEdit()
        {
            InitializeComponent();
            LoadCombobox();
            insertButton.Visible = true;
        }
        int id;
        public PerfomanceEdit(int _id)
        {
            InitializeComponent();
            LoadCombobox();
            id = _id;
            LoadString();
            updateButton.Visible = true;
            deleteButton.Visible = true;
        }


        private void LoadString()
        {
            MySqlConnection con = new MySqlConnection
          ("Server=127.0.0.1;Database=yakovleva;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("Select * from performance where ID_performance=" + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            PerfomanceVybor.Text = dt.Rows[0][1].ToString();


        }

        private void LoadCombobox()
        {

            MySqlConnection con = new MySqlConnection
           ("Server=127.0.0.1;Database=yakovleva;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("Select * from Performance", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
          perf.DataSource = dt;
          perf.DisplayMember = "Name";
          perf.ValueMember = "id_performance";
            //----------------------------------------------------//


            //----------------------------------------------------//


        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
                       ("Server=127.0.0.1;Database=yakovleva;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("INSERT INTO Performance (Name) " +
                "values ('" + perf.Text + "', " +
                colorsColor.SelectedValue + ",' " +
                sizesID_Size.SelectedValue + "', " +
                tshirtsPrise.Value.ToString().Replace(",", ".") + ")", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
                       (@"Server=127.0.0.1;Database=yakovleva;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"update performance 
                set Name='{PerfNaim.Text}',
                    Where id_performance={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
                                   (@"Server=127.0.0.1;Database=yakovleva;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"Delete From performance 
                    Where id_performance={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void updateButton_Click_1(object sender, EventArgs e)
        {

        }

        private void insertButton_Click_1(object sender, EventArgs e)
        {

        }

        private void tshirtsPrise_ValueChanged(object sender, EventArgs e)
        {

        }

        private void sizesID_Size_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void colorsColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void firmsNaim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

