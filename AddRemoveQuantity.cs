using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Manager
{
    
    public partial class AddRemoveQuantity : Form
    {
        SqlCommand cmd1;
        SqlCommand cmd2;
        SqlDataReader dr1;
        
        public AddRemoveQuantity()
        {
            InitializeComponent();
            updateList();

        }

        private void btnToDashboard_Click(object sender, EventArgs e)
        {

            Hide();
            Dashboard.toDashboard();
        }

        private void btnSubmit1_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection("Data Source=MSI\\TESTSERVER;Initial Catalog=Stock_Manager;Integrated Security=True");

            try
            {
               //open and close connections, This is missing
                if (selectAdd.Checked == true) 
                {
                    cmd1 = new SqlCommand("select itemQty from inventory where stockCode=@stockcode and itemName=@itemName ", con1);
                    cmd1.Parameters.AddWithValue("@stockcode", inputCode.Text);
                    cmd1.Parameters.AddWithValue("@itemName", inputName.Text);
                    con1.Open();
                    object result = cmd1.ExecuteScalar();
                    con1.Close();
                    int itemQty;
                    // Check if the result is not null before converting to int
                    if (result != null)
                    {
                        
                        itemQty = Convert.ToInt32(result);
                        
                    }
                    else
                    {
                        // Handle the case where the result is null
                        throw new Exception("Please Re-Check Entries");
                    }



                    StockItem item = new StockItem(inputCode.Text,inputName.Text, itemQty );
                    item.AddItem(Convert.ToInt32(textQty.Text));

                    cmd2 = new SqlCommand("UPDATE inventory SET itemQty = @quantity WHERE stockCode=@code and itemName=@name", con1);
                    cmd2.Parameters.AddWithValue("@code", item.StockCode);
                    cmd2.Parameters.AddWithValue("@name", item.StockName);
                    cmd2.Parameters.AddWithValue("@quantity", item.ItemQuantity);
                    con1.Open();
                    int rowsAffected = cmd2.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Inventory Updated");
                        con1.Close() ;
                    }
                    else
                    {
                        MessageBox.Show("Failed to Update Inventory. Please try again");
                        con1.Close();
                    }


                }
                else if(selectRemove.Checked == true) 
                {

                    cmd1 = new SqlCommand("select itemQty from inventory where stockCode=@stockcode and itemName=@itemName ", con1);
                    cmd1.Parameters.AddWithValue("@stockcode", inputCode.Text);
                    cmd1.Parameters.AddWithValue("@itemName", inputName.Text);
                    con1.Open();
                    object result = cmd1.ExecuteScalar();
                    con1.Close();
                    int itemQty;
                    // Check if the result is not null before converting to int
                    if (result != null)
                    {

                        itemQty = Convert.ToInt32(result);

                    }
                    else
                    {
                        // Handle the case where the result is null
                        throw new Exception("Please Re-Check Entries");
                    }

                    StockItem item = new StockItem(inputCode.Text, inputName.Text, itemQty);
                    item.RemoveItem(Convert.ToInt32(textQty.Text));

                    cmd2 = new SqlCommand("UPDATE inventory SET itemQty = @quantity WHERE stockCode=@code and itemName=@name", con1);
                    cmd2.Parameters.AddWithValue("@code", item.StockCode);
                    cmd2.Parameters.AddWithValue("@name", item.StockName);
                    cmd2.Parameters.AddWithValue("@quantity", item.ItemQuantity);
                    con1.Open();
                    int rowsAffected = cmd2.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Inventory Updated");
                        con1.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to Update Inventory. Please try again");
                        con1.Close();
                    }

                }
                else { throw new Exception("Action not selected, please select the action you want to perform."); }
            }
            catch(Exception ex){ MessageBox.Show(ex.Message); }










        }



        //validations
       

     private void inputCode_TextChanged(object sender, EventArgs e) {  }
       private void inputName_TextChanged(object sender, EventArgs e) { }
        private void inputQty_TextChanged(object sender, EventArgs e) {  }

        

       private void selectRemove_CheckedChanged(object sender, EventArgs e) {   }

        private void selectAdd_CheckedChanged(object sender, EventArgs e) { }

     

        private void inputName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        // private void inputCode_TextChanged(object sender, EventArgs e) { check2(); }
        // private void inputName_TextChanged(object sender, EventArgs e) { check2(); }
        // private void inputQty_TextChanged(object sender, EventArgs e) { check2(); }


        private void updateList()
        {
            SqlConnection con1 = new SqlConnection("Data Source=MSI\\TESTSERVER;Initial Catalog=Stock_Manager;Integrated Security=True");


            List<string> itemNameList = new List<string>();
            List<string> itemCodeList= new List<string>();

            using (con1)
            {
                con1.Open();

                
                SqlCommand command = new SqlCommand("SELECT itemName FROM inventory", con1);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string itemName = reader["itemName"].ToString();
                        itemNameList.Add(itemName);
                    }
                }


                SqlCommand cmd2 = new SqlCommand("SELECT stockCode FROM inventory", con1);

                using (SqlDataReader reader = cmd2.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string itemCode = reader["stockCode"].ToString();
                        itemCodeList.Add(itemCode);
                    }
                }


                con1.Close();
            }
            
            foreach (string itemName in itemNameList)
            {
                inputName.Items.Add(itemName);
            }

            foreach (string itemCode in itemCodeList)
            {
                inputCode.AutoCompleteCustomSource.Add(itemCode);
            }
            





        }





    }
}  
