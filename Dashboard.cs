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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnAddNewItem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            void toNewItem() 
            {
                Hide();
                NewItem newItem = new NewItem();
                newItem.Show();
            }
            toNewItem();
        }

        private void btnStockQnty_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            void toChangeQuantity()
            {
                Hide();
                AddRemoveQuantity changeQunatity = new AddRemoveQuantity();
                changeQunatity.Show();
            }
            toChangeQuantity();
        }

        private void btnDltItem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            void toDeleteItem()
            {
                Hide();
                DeleteStock deleteItem = new DeleteStock();
                deleteItem.Show();
            }
            toDeleteItem();
        }

        private void btnDisplayStock_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            void toDisplayStock()
            {
                Hide();
                StockLevels stockLevel = new StockLevels();
                stockLevel.Show();
            }
            toDisplayStock();
        }

        private void btnDisplayLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            void toTransLog()
            {
                Hide();
                ViewTransLog transLog = new ViewTransLog();
                transLog.Show();
            }
            toTransLog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
        }
        public static void toDashboard()
        {
           
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

    }
}
