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
    public partial class update_book : Form
    {
        int id { get; set; }
        public update_book(int id_con)
        {
            InitializeComponent();
            id = id_con;
            SQLiteConnection con = new SQLiteConnection("data source=library.db");
            con.Open();

            string sql = "SELECT * FROM books WHERE id_books=" + id;
            SQLiteCommand cmd=new SQLiteCommand(sql, con);

      

            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                while(reader.Read())
                {
                    update_name_book.Text=reader.GetString("name");
                    update_avtor_book.Text = reader.GetString("author");
                    update_year_book.Value = int.Parse(reader.GetString("year"));
                }
            }
        }

        private void update_button_book_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("data source=library.db");
            con.Open();
            string sql = "UPDATE books SET name='"+update_name_book.Text+"', author='"+update_avtor_book.Text+"', year='"+update_year_book.Value.ToString()+"' WHERE id_books="+id;

            SQLiteCommand cmd=new SQLiteCommand(sql,con);
            cmd.ExecuteNonQuery();

            this.DialogResult =DialogResult.OK;
            con.Close();
            this.Close();
        }
    }
}
