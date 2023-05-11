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
    public partial class add_book1 : Form
    {
        public add_book1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void save_button_book_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("data source=library.db");
            con.Open();
            string sql = "INSERT INTO books (name, author, year) VALUES ('" + add_name_book.Text + "', '" + add_avtor_book.Text + "','" + add_year_book.Value.ToString() + "')";


            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();

            this.DialogResult = DialogResult.OK;
            con.Close();
            this.Close();
        }
    }
}
