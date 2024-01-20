using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Manager
{
    public partial class ViewTransLog : Form
    {
        SqlConnection con1 = new SqlConnection("Data Source=MSI\\TESTSERVER;Initial Catalog=Stock_Manager;Integrated Security=True");
        SqlConnection con2 = new SqlConnection("Data Source=MSI\\TESTSERVER;Initial Catalog=Stock_Manager;Integrated Security=True");
        public ViewTransLog()
        {
            InitializeComponent();
             
        }

        private void btnToDashboard_Click(object sender, EventArgs e)
        {
            Hide();
            Dashboard.toDashboard();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
           
           
                con1.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM transactionlog", con1);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                dgvTransLog.DataSource = dt;
                con1.Close();
            
        }
    }
}
