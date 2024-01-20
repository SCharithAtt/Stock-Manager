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
        SqlCommand cmd2;
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


          
        }


        public void newItem()
        {
            try
            {
                cmd1 = new SqlCommand("INSERT INTO inventory ( stockCode, itemName,itemQty) VALUES (@itemCode,@itemName,@qtyRemaining)", con1);

                cmd1.Parameters.AddWithValue("@itemName", this.StockName);
                cmd1.Parameters.AddWithValue("@itemCode", this.stockCode);
                cmd1.Parameters.AddWithValue("@qtyRemaining", this.ItemQuantity);
                con1.Open();
                int rowsAffected1 = cmd1.ExecuteNonQuery();
                if (rowsAffected1 > 0)
                {
                    MessageBox.Show("Inventory Updated");
                    con1.Close();
                }
                else
                {
                    MessageBox.Show("Couldn't Complete Transaction Log Entry");
                    con1.Close();
                }
                con1.Close();

                cmd2 = new SqlCommand("INSERT INTO transactionlog (date_time, item_action, item_name, item_code,remaining_qty) VALUES (@dateTime, @itemAction, @itemName,@itemCode,@qtyRemaining)", con1);
                cmd2.Parameters.AddWithValue("@dateTime", DateTime.Now);
                cmd2.Parameters.AddWithValue("@itemAction", "Created new stock item");
                cmd2.Parameters.AddWithValue("@itemName", this.StockName);
                cmd2.Parameters.AddWithValue("@itemCode", this.stockCode);
                cmd2.Parameters.AddWithValue("@qtyRemaining", this.ItemQuantity);

                con1.Open();
                int rowsAffected2 = cmd2.ExecuteNonQuery();
                if (rowsAffected2>0)
                {
                    MessageBox.Show("Transaction Log Entry Noted. ");
                    con1.Close();
                }
                else
                {

                    con1.Close();
                    MessageBox.Show("Couldn't Complete Transaction Log Entry");

                }
                con1.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { con1.Close(); }
        }
            


        




        public void AddItem( int Quantity ) 
        { 
            this.ItemQuantity += Quantity;
            cmd1 = new SqlCommand("INSERT INTO transactionlog (date_time, item_action, item_name, item_code,remaining_qty) VALUES (@dateTime, @itemAction, @itemName,@itemCode,@qtyRemaining)", con1);
            cmd1.Parameters.AddWithValue("@dateTime", DateTime.Now);
            cmd1.Parameters.AddWithValue("@itemAction", "Added Quantity to existing Stock Item");
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
                MessageBox.Show("Couldn't Complete Transaction Log Entry");

            }


        }
        public void RemoveItem(int Quantity)
        {
            this.ItemQuantity -= Quantity;
            cmd1 = new SqlCommand("INSERT INTO transactionlog (date_time, item_action, item_name, item_code,remaining_qty) VALUES (@dateTime, @itemAction, @itemName,@itemCode,@qtyRemaining)", con1);
            cmd1.Parameters.AddWithValue("@dateTime", DateTime.Now);
            cmd1.Parameters.AddWithValue("@itemAction", "Removed Quantity from existing Stock Item");
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
                MessageBox.Show("Couldn't Complete Transaction Log Entry");

            }
            con1.Close() ;
        }


        public void logDeletion()
        {

            cmd1 = new SqlCommand("INSERT INTO transactionlog (date_time, item_action, item_name, item_code) VALUES (@dateTime, @itemAction, @itemName,@itemCode)", con1);
            cmd1.Parameters.AddWithValue("@dateTime", DateTime.Now);
            cmd1.Parameters.AddWithValue("@itemAction", "Deleted Stock Item");
            cmd1.Parameters.AddWithValue("@itemName", this.StockName);
            cmd1.Parameters.AddWithValue("@itemCode", this.stockCode);
            


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
                MessageBox.Show("Couldn't Complete Transaction Log Entry");

            }
            con1.Close();



        }













    }


}
