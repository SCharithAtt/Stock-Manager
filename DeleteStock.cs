using System;
using System.Collections;
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
    public partial class DeleteStock : Form
    {
        SqlConnection con1 = new SqlConnection("Data Source=MSI\\TESTSERVER;Initial Catalog=Stock_Manager;Integrated Security=True");
        SqlCommand cmd1;
        public DeleteStock()
        {
            InitializeComponent();
            
        }

        private void btnToDashboard_Click(object sender, EventArgs e)
        {
            Hide();
            Dashboard.toDashboard();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (lbItems.SelectedIndex != -1)
            {
                // Get the selected item from the ListBox
                string selectedItem = lbItems.SelectedItem.ToString();

                // Extract the ID (or any unique identifier) from the selected item
     

                // Find the index of "Date:" and "-"
                int startIndex = selectedItem.IndexOf("Stock Code: ") + "Stock Code: ".Length;
                int endIndex = selectedItem.IndexOf(" |", startIndex);
                string id = selectedItem.Substring(startIndex, endIndex - startIndex).Trim();

                int startIndex1 = selectedItem.IndexOf("Item Name: ") + "Item Name: ".Length;
                int endIndex1 = selectedItem.IndexOf(" |", startIndex1);
                string name = selectedItem.Substring(startIndex1, endIndex1 - startIndex1).Trim();

                int startIndex2 = selectedItem.IndexOf("Quantity: ") + "Quantity: ".Length;
                int endIndex2 = selectedItem.IndexOf(" .", startIndex2);
                string qty = selectedItem.Substring(startIndex2, endIndex2 - startIndex2).Trim();

                StockItem item = new StockItem(id, name, Convert.ToInt32(qty));
                item.logDeletion();

                // Open the connection
                con1.Open();

                // Execute DELETE query
                using (SqlCommand command = new SqlCommand("DELETE FROM inventory WHERE stockCode = @Id", con1))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }

                
                con1.Close();

            }
            else
            {
                MessageBox.Show("Please select an entry to delete.");
            }

            //Logging Transaction Log Entry







            //End of Entry


            btnLoadItems_Click(sender, e);

            }

            private void btnLoadItems_Click(object sender, EventArgs e)
        {
            try {
                string query = "SELECT stockCode, itemName, itemQty FROM inventory";
                con1.Open();
                using (SqlCommand command = new SqlCommand(query, con1))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Clear existing items in the ListBox
                        lbItems.Items.Clear();

                        // Loop through the results and add each row to the ListBox
                        while (reader.Read())
                        {
                            // Assuming you have a "ID" column in your table
                            string stockCode = reader.GetString(0);

                            // Assuming you have a "Column1" and "Column2" in your table
                            string itemName = reader.GetString(1);
                            int itemQty = reader.GetInt32(2);

                            // Add the row to the ListBox
                            lbItems.Items.Add($"Stock Code: {stockCode} | Item Name: {itemName} | Available Quantity: {itemQty} .");
                        }
                    }
                }
                con1.Close();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            





        }
    }
}

