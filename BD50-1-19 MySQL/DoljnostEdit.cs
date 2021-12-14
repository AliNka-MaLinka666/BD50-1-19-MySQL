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
    public partial class DoljnostEdit : MaterialSkin.Controls.MaterialForm

{
        public DoljnostEdit()
        {
            InitializeComponent();
            LoadCombobox();
            insertButton.Visible = true;
        }
        int id;
        public DoljnostEdit(int _id)
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
            ("Select * from position where ID_position=" + id, con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        DoljNaim.Text = dt.Rows[0][1].ToString();
       

    }

    private void LoadCombobox()
    {

        MySqlConnection con = new MySqlConnection
       ("Server=127.0.0.1;Database=yakovleva;charset=utf8;Uid=root;Pwd=;SslMode=none");
        MySqlDataAdapter da = new MySqlDataAdapter
            ("Select * from Position", con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        firmsNaim.DataSource = dt;
        firmsNaim.DisplayMember = "Type_of_position";
        firmsNaim.ValueMember = "id_Position";
        //----------------------------------------------------//

      
        //----------------------------------------------------//


    }

    private void insertButton_Click(object sender, EventArgs e)
    {
        MySqlConnection con = new MySqlConnection
                   ("Server=127.0.0.1;Database=yakovleva;charset=utf8;Uid=root;Pwd=;SslMode=none");
        MySqlDataAdapter da = new MySqlDataAdapter
            ("INSERT INTO Position (Type_of_position) " +
            "values ('" + DoljNaim.Text  +"')", con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        Close();
    }

    private void updateButton_Click(object sender, EventArgs e)
    {
        MySqlConnection con = new MySqlConnection
                   (@"Server=127.0.0.1;Database=yakovleva;charset=utf8;Uid=root;Pwd=;SslMode=none");
        MySqlDataAdapter da = new MySqlDataAdapter
            ($@"update position 
                set Type_of_position='{DoljNaim.Text}',
                    Where id_position={id}", con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        Close();
    }

    private void deleteButton_Click(object sender, EventArgs e)
    {
        MySqlConnection con = new MySqlConnection
                               (@"Server=127.0.0.1;Database=yakovleva;charset=utf8;Uid=root;Pwd=;SslMode=none");
        MySqlDataAdapter da = new MySqlDataAdapter
            ($@"Delete From position 
                    Where id_position={id}", con);
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

    private void tshirtsNaim_TextChanged(object sender, EventArgs e)
    {

    }
}
}

