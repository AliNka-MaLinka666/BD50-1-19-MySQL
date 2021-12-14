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
    public partial class Form4 : MaterialSkin.Controls.MaterialForm
    {
        public Form4()
        {
            InitializeComponent();

            LoadTable();
        }

        private void LoadTable()
        {
            MySqlConnection con = new MySqlConnection
       ("Server=127.0.0.1;Database=Yakovleva;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("SELECT *  FROM performance ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
        }

        private void EditFormButton_Click(object sender, EventArgs e)
        {
            PerfomanceEdit pere = new PerfomanceEdit();
            pere.ShowDialog();
            LoadTable();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                StaffEdit se = new StaffEdit();
                se.ShowDialog();
                LoadTable();
            }
            catch (ArgumentOutOfRangeException) { }
            catch (InvalidCastException)
            {
                EditFormButton_Click(null, null);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PerformanceButton1_Click(object sender, EventArgs e)
        {
            PerfomanceEdit pere = new PerfomanceEdit();
            pere.ShowDialog();
            LoadTable();
        }

        private void PerformanceButton1_Click_1(object sender, EventArgs e)
        {
            PerfomanceEdit pere = new PerfomanceEdit();
            pere.ShowDialog();
            LoadTable();
        }
    }
}
