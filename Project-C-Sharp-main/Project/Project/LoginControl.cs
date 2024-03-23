using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project
{
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        
        {
            if(txtUsername.Text=="")
            {
                MessageBox.Show("Please Enter The Required Fields");
            }
            else if(textBox2.Text=="")
            {
                MessageBox.Show("Please Enter The Required Fields");
            }
            else
            {
                this.Hide();
            }
             
            string username = txtUsername.Text;
            string password = textBox2.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#database\UserDB.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "INSERT INTO UserTable values('"+username+"','"+password+"')";
            SqlCommand cmd = new SqlCommand(qry, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Records Inserted Sucessfully");
            }
            catch(SqlException qr)
            {
                Console.WriteLine("Error Generated. Details: " + qr.ToString());
            }
            finally
            {
                con.Close();
                Console.Read();
            }

            


        }
       
    }
}
