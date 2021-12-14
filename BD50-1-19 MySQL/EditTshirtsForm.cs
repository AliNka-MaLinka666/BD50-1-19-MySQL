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
    public partial class EditTshirtsForm : MaterialSkin.Controls.MaterialForm
    {
        public EditTshirtsForm()
        {
            InitializeComponent();
            LoadCombobox();
            insertButton.Visible = true;
        }
        int id;
        public EditTshirtsForm(int _id)
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
          ("Server=127.0.0.1;Database=Tshirts;Uid=Cucumber;Pwd=1234;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("Select * from Tshirts where ID_T="+id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            tshirtsNaim.Text = dt.Rows[0][1].ToString();
            firmsNaim.SelectedValue = dt.Rows[0][2];
            colorsColor.SelectedValue = dt.Rows[0][3];
            sizesID_Size.SelectedValue= dt.Rows[0][4];
            tshirtsPrise.Value = Convert.ToDecimal(dt.Rows[0][5]);

        }

        private void LoadCombobox()
        {
            
            MySqlConnection con = new MySqlConnection
           ("Server=127.0.0.1;Database=yakovleva;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("Select * from position", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            firmsNaim.DataSource = dt;
            firmsNaim.DisplayMember = "Naim";
            firmsNaim.ValueMember = "ID_F";
            //----------------------------------------------------//

            MySqlConnection con1 = new MySqlConnection
           ("Server=127.0.0.1;Database=Tshirts;charset=utf8;Uid=Cucumber;Pwd=1234;SslMode=none");
            MySqlDataAdapter da1 = new MySqlDataAdapter
                ("Select * from Colors", con1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            colorsColor.DataSource = dt1;
            colorsColor.DisplayMember = "Color";
            colorsColor.ValueMember = "ID_C";
            //----------------------------------------------------//
            
            MySqlConnection con2 = new MySqlConnection
           ("Server=127.0.0.1;Database=Tshirts;charset=utf8;Uid=Cucumber;Pwd=1234;SslMode=none");
            MySqlDataAdapter da2 = new MySqlDataAdapter
                ("Select * from Sizes", con2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            sizesID_Size.DataSource = dt2;
            sizesID_Size.DisplayMember = "Sizes";
            sizesID_Size.ValueMember = "ID_S";
            
        }
        
        private void insertButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
                       ("Server=127.0.0.1;Database=Tshirts;charset=utf8;Uid=Cucumber;Pwd=1234;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("INSERT INTO Tshirts (Naim,ID_Firms,ID_Colors,ID_Sizes,Price) " +
                " values ('"+tshirtsNaim.Text+"', " +
                firmsNaim.SelectedValue+ ", " +
                colorsColor.SelectedValue+",' " +
                sizesID_Size.SelectedValue+"', " +
                tshirtsPrise.Value.ToString().Replace(",", ".") + ")", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
                       (@"Server=127.0.0.1;Database=Tshirts;charset=utf8;Uid=Cucumber;Pwd=1234;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"update Tshirts set 
                    Naim='{tshirtsNaim.Text}',
                    ID_Firms={firmsNaim.SelectedValue},
                    ID_Colors={colorsColor.SelectedValue},
                    ID_Sizes={sizesID_Size.SelectedValue},
                    Price={tshirtsPrise.Value.ToString().Replace(",", ".")} 
                    Where id_t={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
                                   (@"Server=127.0.0.1;Database=Tshirts;charset=utf8;Uid=Cucumber;Pwd=1234;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"Delete From tshirts 
                    Where id_t={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }
    }
}
