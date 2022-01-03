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
    public partial class Form2 : Form
    {
        MySqlConnection connection =
        new MySqlConnection("Server=localhost;Database=winform_db;Uid=root;Pwd=108301;");

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Fill in the information");
            }
            else
            {
                string insertQuery = "INSERT INTO member(name,memid,pw,phnum) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "');";

                connection.Open();
                MySqlCommand command = new MySqlCommand(insertQuery, connection);

                try
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show("Signin Success");
                    }
                    else
                    {
                        this.DialogResult = DialogResult.Cancel;
                        MessageBox.Show("Sigin Failed");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                connection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string strSelect = "SELECT * from member where memid='" + textBox2.Text+"';";
                MySqlCommand cmd = new MySqlCommand(strSelect, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    label6.Text = "This ID already exists." + "\n" + "Please use a different ID.";
                    return;
                }
                textBox2.ReadOnly = true; //? 수정 안되게
                button1.Enabled = true;
                label6.Text = "usable ID";
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
                textBox3.PasswordChar = default(char);
            }
            else
            {
                textBox3.PasswordChar = '*';
            }
        }
    }
}
