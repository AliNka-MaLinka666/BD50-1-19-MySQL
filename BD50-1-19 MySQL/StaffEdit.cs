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
    public partial class StaffEdit : MaterialSkin.Controls.MaterialForm

    {
        public StaffEdit()
        {
            InitializeComponent();
            LoadCombobox();
            insertButton.Visible = true;
        }
        int id;
        public StaffEdit(int _id)
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
                ("Select * from staff where ID_staff=" + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            StaffNaim.Text = dt.Rows[0][1].ToString();


        }

        private void LoadCombobox()
        {

            MySqlConnection con = new MySqlConnection
           ("Server=127.0.0.1;Database=yakovleva;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("Select * from staff", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            StaffsNaim.DataSource = dt;
            StaffsNaim.DisplayMember = "Surname";
            StaffsNaim.ValueMember = "id_staff";
            //----------------------------------------------------//


            //----------------------------------------------------//


        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
                       ("Server=127.0.0.1;Database=yakovleva;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("INSERT INTO Staff (id_staff,Surname,Name,  Date_Of_Birth, Employment_Date, The_Salaru, Amount_of_children, Adress,Height) " +
                "values (('" + Name.Text + "', " +
                StaffNaim.Text + ", " +
                adress.SelectedValue + ",' " +
                Deti.SelectedValue + "', " +
                The_salaru.Value.ToString().Replace(",", ".") + ")", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
                       (@"Server=127.0.0.1;Database=yakovleva;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"update gender 
                set Name_Gender='{StaffNaim.Text}',
                    Where id_gender={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
                                   (@"Server=127.0.0.1;Database=yakovleva;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"Delete From gender 
                    Where id_gender={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void Patronomus_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

