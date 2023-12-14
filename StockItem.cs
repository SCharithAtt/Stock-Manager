using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Manager
{
    

    class StockItem
    {
        private string stockCode;
        private string stockName;
        private int itemQuantity;

        SqlConnection con1 = new SqlConnection("Data Source=MSI\\TESTSERVER;Initial Catalog=Stock_Manager;Integrated Security=True");
        SqlCommand cmd1;
        SqlDataReader dr1;

        public string StockName
        {
            get { return stockName; }
            set
            {
                if (value != null) { stockName = value; }
                else { throw new ArgumentException(); }

            }
        }
        public string StockCode
        {
            get { return stockCode; }
            set
            {
                if (value != null) { stockCode = value; }
                else { throw new ArgumentException(); }

            }
        }

        public int ItemQuantity
        {
            get { return itemQuantity; }
            set
            {
                if (value > 0) { itemQuantity = value; }
                else
                {
                    //method to delete object
                    throw new Exception("Item quantity must be more than 0.");
                }
            }
        }

        public StockItem(string StockCode, string StockName, int ItemQuantity) 
        { 
            this.StockCode = StockCode;
            this.StockName = StockName; 
            this.ItemQuantity = ItemQuantity;

            try 
            {

                cmd1 = new SqlCommand("INSERT INTO transactionlog (date_time, item_action, item_name, item_code,remaining_qty) VALUES (@dateTime, @itemAction, @itemName,@itemCode,@qtyRemaining)", con1);

                cmd1.Parameters.AddWithValue("@dateTime", DateTime.Now);
                cmd1.Parameters.AddWithValue("@itemAction", "Created new stock item");
                cmd1.Parameters.AddWithValue("@itemName", this.StockName);
                cmd1.Parameters.AddWithValue("@itemCode", this.stockCode);
                cmd1.Parameters.AddWithValue("@qtyRemaining", this.ItemQuantity);

                con1.Open();
                int rowsAffected = cmd1.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Transaction Log Entry Noted. ");
                    con1.Close();
                }
                else
                {
                    con1.Close();
                    MessageBox.Show("Couldn't Complete Transaction Log Entry" );
                    
                }
                con1.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message) ; }



        }

        public void AddItem(StockItem Name, int Quantity ) 
        { 
            this.ItemQuantity += Quantity;
        }
        public void RemoveItem(StockItem Name, int Quantity)
        {
            this.ItemQuantity -= Quantity;
        }









       






    }


}
