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

namespace Winformassemfind
{
    public partial class Form1 : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=winform_db;Uid=root;Pwd=108301;");
        string id, pw, name, phonenum;

        public Form1()
        {
            InitializeComponent();

            pictureBox1.Load(@"C:\Users\82105\source\repos\library.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Load(@"C:\Users\82105\source\repos\welcome.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void sign_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
           
            if (f2.ShowDialog() == DialogResult.OK)
            {
                label3.Text = "Membership Success. Login!";
            }
            else
            {
                label3.Text = "Log in or Sign in";
            }
            f2.Dispose();
        }

        private void log_Click(object sender, EventArgs e)
        {
            id = textBox1.Text;
            pw = textBox2.Text;

            try
            {
                connection.Open();

                string strSelect = "SELECT * from member where memid='" + id +"';";
                MySqlCommand cmd = new MySqlCommand(strSelect, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    if (rdr["pw"].ToString() == pw)
                    {
                        name = rdr["name"].ToString();
                        phonenum = rdr["phnum"].ToString();
                        first.Visible = false;
                        main.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password. Try again..");
                        textBox2.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Invalid ID. Try again..");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            connection.Close();

            listView2.GridLines = true;
            listView3.GridLines = true;
            listView1.GridLines = true;

            listView2.Columns.Add("USER ID", 150);
            listView2.Columns.Add("TITLE", 150);
            listView2.Columns.Add("AUTHOR", 150);
            listView2.Columns.Add("BOOK NUMBER", 150);

            listView3.Columns.Add("RENT / RETURN", 150);
            listView3.Columns.Add("TITLE", 150);
            listView3.Columns.Add("BOOK NUMBER", 150);
            listView3.Columns.Add("DATE", 150);

            listView1.Columns.Add("TITLE", 150);
            listView1.Columns.Add("AUTHOR", 150);
            listView1.Columns.Add("BOOK NUMBER", 150);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rentp.Visible = true;
            infop.Visible = false;
            returnp.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rentp.Visible = false;
            infop.Visible = false;
            returnp.Visible = true;

            connection.Open();
            listView2.View = View.Details;
            string sql = "Select * from rent";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader Reader = cmd.ExecuteReader();

            listView2.Items.Clear();

            while (Reader.Read())
            {
                ListViewItem lv = new ListViewItem(Reader.GetString(0));
                lv.SubItems.Add(Reader.GetString(1));
                lv.SubItems.Add(Reader.GetString(2)); 
                lv.SubItems.Add(Reader.GetString(3));
                listView2.Items.Add(lv);

            }
            Reader.Close();
            cmd.Dispose();
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rentp.Visible = false;
            infop.Visible = true;
            returnp.Visible = false;

            connection.Open();
            listView3.View = View.Details;
            string sql = "Select * from record";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader Reader = cmd.ExecuteReader();

            listView3.Items.Clear();

            while (Reader.Read())
            {
                if (Reader["userid"].ToString() == id)
                {
                    ListViewItem lv = new ListViewItem(Reader.GetString(0));
                    lv.SubItems.Add(Reader.GetString(1));
                    lv.SubItems.Add(Reader.GetString(2));
                    lv.SubItems.Add(Reader.GetString(3));
                    listView3.Items.Add(lv);
                }
            }
            Reader.Close();
            cmd.Dispose();
            connection.Close();
            
            info.Text = "ID : " + id + "\n\n" + "PW : " + pw + "\n\n" + "NAME : " + name + "\n\n" + "PHONE NUMBER : " + phonenum;
        }

        private void rent_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count!=0)
            {
                int pos = listView1.SelectedItems[0].Index;
                string title = listView1.Items[pos].SubItems[0].Text;
                string author = listView1.Items[pos].SubItems[1].Text;
                string num = listView1.Items[pos].SubItems[2].Text;

                string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                string deleteQuery = "DELETE FROM book WHERE booknum='" + num + "';";
                string insertQuery = "INSERT INTO rent VALUES('" + id + "','" + title + "','" + author + "','" + num + "');";
                string insertrecord = "INSERT INTO record VALUES('RENT','" + title + "','" + num + "','" + date + "','" + id + "');";

                connection.Open();
                MySqlCommand command = new MySqlCommand(insertQuery, connection);
                command.ExecuteNonQuery();

                command.CommandText = insertrecord;
                command.ExecuteNonQuery();

                command.CommandText = deleteQuery;
                command.ExecuteNonQuery();
                
                MessageBox.Show("RENT SUCCESS!");
                listView1.Items.RemoveAt(pos);

                command.Dispose();
                connection.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result1 = MessageBox.Show("Do you really want to leave?", "So sad..", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    connection.Open();

                    string delmem = "DELETE FROM member WHERE memid = '" + id + "';";
                    string insertbook = "INSERT INTO book SELECT title, author, booknum FROM rent WHERE userid = '" + id + "';";

                    MySqlCommand cmd = new MySqlCommand(insertbook, connection);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = delmem;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Bye..");
                    Application.Exit();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            connection.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.PasswordChar = default(char);
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            connection.Open();
            listView1.View = View.Details;
            string sql = "Select * from book";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader Reader = cmd.ExecuteReader();

            listView1.Items.Clear();
            
            while (Reader.Read())
            {
                ListViewItem lv = new ListViewItem(Reader.GetString(0));
                lv.SubItems.Add(Reader.GetString(1));
                lv.SubItems.Add(Reader.GetString(2));
                listView1.Items.Add(lv);
            }
            Reader.Close();
            cmd.Dispose();
            connection.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count != 0)
            {
                int pos = listView2.SelectedItems[0].Index;
                string title = listView2.Items[pos].SubItems[1].Text;
                string num = listView2.Items[pos].SubItems[3].Text;
                string author = listView2.Items[pos].SubItems[2].Text;

                string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                if (id == listView2.Items[pos].SubItems[0].Text)
                {
                    string deleteQuery = "DELETE FROM rent WHERE booknum='" + num + "';";
                    string insertQuery = "INSERT INTO book VALUES('" + title + "','" + author + "','" + num + "');";
                    string insertrecord = "INSERT INTO record VALUES('RETURN','" + title + "','" + num + "','" + date + "','" + id + "');";

                    connection.Open();
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);
                    command.ExecuteNonQuery();

                    command.CommandText = insertrecord;
                    command.ExecuteNonQuery();

                    command.CommandText = deleteQuery;
                    command.ExecuteNonQuery();

                    MessageBox.Show("RETURN SUCESS!");
                    listView2.Items.RemoveAt(pos);

                    command.Dispose();
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("It's not the book you borrowed..");
                }
            }
        }
    }
}
