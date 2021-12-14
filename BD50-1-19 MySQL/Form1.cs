using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace BD50_1_19_MySQL
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
       
            LoadTable();
        }

        private void LoadTable()
        {
                MySqlConnection con = new MySqlConnection
           ("Server=127.0.0.1;Database=Yakovleva;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("SELECT *  FROM position ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
        }

        private void EditFormButton_Click(object sender, EventArgs e)
        {
            DoljnostEdit de = new DoljnostEdit();
            de.ShowDialog();
            LoadTable();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                DoljnostEdit de = new DoljnostEdit(id);
                de.ShowDialog();
                LoadTable();
            }
            catch (ArgumentOutOfRangeException) { }
            catch(InvalidCastException)
            {
                EditFormButton_Click(null,null);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
