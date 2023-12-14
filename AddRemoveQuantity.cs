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
        SqlConnection con1 = new SqlConnection("Data Source=MSI\\TESTSERVER;Initial Catalog=Stock_Manager;Integrated Security=True");
        SqlCommand cmd1;
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
           try
           {
               //open and close connections, This is missing
                if (selectAdd.Checked == true) 
                {
                    SqlCommand cmd3 = new SqlCommand(" select itemObject from inventory where itemName='"+inputName.Text+"' and stockCode='"+inputCode.Text+"' ", con1);
                  con1.Open();
                    using(SqlDataReader reader = cmd3.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            StockItem item = JsonSerializer.Deserialize<StockItem>(reader["itemObject"].ToString());
                            item.AddItem(item, int.Parse(textQty.Text));
                            int newQty = item.ItemQuantity;
                            string itemCode = item.StockCode;

                            string stockItemJSON = JsonSerializer.Serialize(item);





                            cmd1 = new SqlCommand("update inventory set itemQty=@itemqty   where stockCode=@stockcode ", con1);
                           SqlCommand cmd2 = new SqlCommand("update inventory set itemObject=@itemobject   where stockCode=@stockcode", con1);

                            
                            cmd1.Parameters.AddWithValue("@itemqty", item.ItemQuantity);
                            cmd2.Parameters.AddWithValue("@itemobject", stockItemJSON);
                            cmd1.Parameters.AddWithValue("@stockcode", item.StockCode);
                            cmd2.Parameters.AddWithValue("@stockcode", item.StockCode);

                            con1.Open();

                            int rowsAffected = cmd1.ExecuteNonQuery();
                            int rowsAffected1=cmd2.ExecuteNonQuery();
                            con1.Close();
                            if ((rowsAffected+rowsAffected1) == 2)
                            {
                                MessageBox.Show("Item Updated");
                            }
                            else
                            {
                                MessageBox.Show("Could'nt update item quantity. ");
                            }


                        }

                    }

                }
                else if(selectRemove.Checked == true) 
                { 
                
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
