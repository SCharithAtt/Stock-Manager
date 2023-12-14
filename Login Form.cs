using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Manager
{

    public partial class loginForm : Form
    {
        SqlConnection con1 = new SqlConnection("Data Source=MSI\\TESTSERVER;Initial Catalog=Stock_Manager;Integrated Security=True");
        SqlCommand cmd1;
        SqlDataReader dr1;
        public loginForm()
        {
            InitializeComponent();

        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void usernameInput_Enter(object sender, EventArgs e)
        {
            
        }
        

        private void passwordInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordInput_Enter(object sender, EventArgs e)
        {
            passwordInput.Text = string.Empty;
            passwordInput.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try 
            {
                cmd1 = new SqlCommand("select * from loginCredentials where Username=@username and passcode=@password", con1);
                cmd1.Parameters.AddWithValue("@username", usernameInput.Text);
                cmd1.Parameters.AddWithValue("@password", passwordInput.Text);

                con1.Open();



                dr1 = cmd1.ExecuteReader();
                if (dr1.HasRows)
                {
                    Hide();
                    Dashboard.toDashboard();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials, Please try again..");
                }
            } 

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 

            finally 
            {
                con1.Close();
                
            }

           
            


        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

