using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Stock_Manager
{
    public partial class NewItem : Form
    {
        SqlConnection con1 = new SqlConnection("Data Source=MSI\\TESTSERVER;Initial Catalog=Stock_Manager;Integrated Security=True");
        SqlCommand cmd1;
        SqlDataReader dr1;

        



        public NewItem()
        {
            InitializeComponent();
            btnSubmit.Enabled = false;


        }

        private void btnToDashboard_Click(object sender, EventArgs e)
        {
            Hide();
            Dashboard.toDashboard();
        }




        private void btnClear_Click(object sender, EventArgs e)
        {
            inputCode.Text = string.Empty;
            inputName.Text = string.Empty;
            inputQty.Text = string.Empty;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

           

            try
            {
                

                SqlCommand cmd2 = new SqlCommand("select * from inventory where stockCode=@stockcode ", con1);
                cmd2.Parameters.AddWithValue("@stockcode", inputCode.Text);
                con1.Open();
                
                dr1 = cmd2.ExecuteReader();
                
                if (dr1.HasRows==false)
                {
                    con1.Close();
                    StockItem Item = new StockItem(inputCode.Text, inputName.Text, int.Parse(inputQty.Text));

                    string stockItemJSON = JsonSerializer.Serialize(Item);





                    cmd1 = new SqlCommand("INSERT INTO inventory ( stockCode, itemName, itemQty, itemObject) VALUES (@stockcode, @itemname, @itemqty,@itemobject)", con1);

                    cmd1.Parameters.AddWithValue("@stockcode", Item.StockCode);
                    cmd1.Parameters.AddWithValue("@itemname", Item.StockName);
                    cmd1.Parameters.AddWithValue("@itemqty", Item.ItemQuantity);
                    cmd1.Parameters.AddWithValue("@itemobject", stockItemJSON);

                    con1.Open();

                    int rowsAffected = cmd1.ExecuteNonQuery();
                    con1.Close();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Item Added to Stock. ");
                    }
                    else
                    {
                        MessageBox.Show("Couldn't Add item to Stock. ");
                    }
                    
                }
                else
                {
                    con1.Close() ;
                    
                    throw new Exception("Stock Code Already Exists. Stock Code must be unique. ");
                }
                con1.Close();


            }






            catch (Exception ex)
            {

                MessageBox.Show("An Error occured, Please re-check your entries. \n\n\n" + ex.Message);
                inputCode.Text = string.Empty;
                inputName.Text = string.Empty;
                inputQty.Text = string.Empty;


            }

            


        }

        //Validations 
        private void check1()
        {
            bool validName = false;
            bool validCode = false;
            bool validQty = false;
            bool check1pass = false;

            

            if (0 < inputName.TextLength && 50 > inputName.TextLength) { validName = true; } else { validName = false; }
            if (0 < inputCode.TextLength && 50 > inputCode.TextLength ) { validCode = true; } else { validCode = false; }
            if (0 <= inputQty.TextLength && 50 > inputQty.TextLength && int.TryParse(inputQty.Text, out int result) && int.Parse(inputQty.Text) > 0) { validQty = true; } else { validQty = false; }

            if (validName == true && validCode == true && validQty == true) { check1pass = true; } else { check1pass = false; }

            if (check1pass == true) { btnSubmit.Enabled = true; } else { btnSubmit.Enabled = false; }


        }

        private void inputCode_TextChanged(object sender, EventArgs e) { check1(); }
        private void inputName_TextChanged(object sender, EventArgs e) { check1(); }
        private void inputQty_TextChanged(object sender, EventArgs e) { check1(); }
















    }



}