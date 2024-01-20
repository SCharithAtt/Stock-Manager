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
    public partial class StockLevels : Form
    {
        SqlConnection con1 = new SqlConnection("Data Source=MSI\\TESTSERVER;Initial Catalog=Stock_Manager;Integrated Security=True");
        SqlConnection con2 = new SqlConnection("Data Source=MSI\\TESTSERVER;Initial Catalog=Stock_Manager;Integrated Security=True");
        public StockLevels()
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
            
                con2.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM inventory", con2);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                dgvStockLevels.DataSource = dt;
                con2.Close();
            
        }
    }
}

