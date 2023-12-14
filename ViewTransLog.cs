using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Manager
{
    public partial class ViewTransLog : Form
    {
        public ViewTransLog()
        {
            InitializeComponent();
        }

        private void btnToDashboard_Click(object sender, EventArgs e)
        {
            Hide();
            Dashboard.toDashboard();
        }
    }
}
