using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class add_reader : Form
    {
        public add_reader()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("data source=library.db");
            con.Open();
            string sql = "INSERT INTO readers (last_name, first_name, patronimyc, phone) VALUES ('" + add_last_name.Text + "', '" + add_first_name.Text + "','" + add_patronymic.Text + "', '" + add_phone.Text + "')";

            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();

            this.DialogResult = DialogResult.OK;
            con.Close();
            this.Close();
        }
    }
}
