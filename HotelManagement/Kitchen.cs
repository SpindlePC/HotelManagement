using MetroFramework.Forms;
using MetroFramework.Fonts;
using MetroFramework.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Hotel_Manager
{
    public partial class Kitchen : MetroForm
    {
        string cleaning, towel, surprise, queryString;
        int breakfast, lunch, dinner, foodBill;
        public Int32 primaryID;
        double totalBill;
        bool supply_status = false;

        SqlConnection connection = new SqlConnection(Hotel_Manager.Properties.Settings.Default.frontend_reservationConnectionString);
        SqlCommand query;
        SqlDataReader reader;
        
        public Kitchen()
        {
            InitializeComponent();

        }
        private void kitchen_Load(object sender, EventArgs e)
        {
            LoadForDataGridView();
            listBoxFromDataBase();
        }

        private void LoadForDataGridView()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Close();

                queryString = "Select ID, first_name, last_name, phone_number, room_type, room_floor, room_number, break_fast, lunch, dinner, cleaning, towel, s_surprise, supply_status, food_bill from reservation where check_in = '" + "True" + "' AND supply_status= '" + "False" + "'";
                query = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;
                    dataAdapter.Update(dataTable);
                    connection.Close();
                }
                catch (Exception)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Error loading data", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.None);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "SQL Connection is already open", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        private void resetEntries(Control controls)
        {
            foreach (Control control in controls.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                if (control.HasChildren)
                {
                    resetEntries(control);
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void FirstNameTextBox(object sender, EventArgs e)
        {

        }

        private void firstNameTextBox_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }

        private void listBoxFromDataBase()
        {

            
        }

        private void queueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Close();
                resetEntries(this);
                 //MessageBox.Show("ID+" + getQuerystring);
               
                query = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        string ID = reader["Id"].ToString();
                        string first_name = reader["first_name"].ToString();
                        string last_name = reader["last_name"].ToString();
                        string phone_number = reader["phone_number"].ToString();
                        string foodBillD = reader["food_bill"].ToString();
                        string total_bill = reader["total_bill"].ToString().Replace(" ", string.Empty);
                        string room_type = reader["room_type"].ToString();
                        string room_floor = reader["room_floor"].ToString();
                        string room_number = reader["room_number"].ToString();

                        string _cleaning = reader["cleaning"].ToString();
                        string _towel = reader["towel"].ToString();
                        string _surprise = reader["s_surprise"].ToString();



                        if (_cleaning == "True")
                        {
                            cleaning = "1";
                        }
                        else { cleaning = "0"; }

                        if (_towel == "True")
                        {
                            towel = "1";
                        }
                        else { towel = "0"; }
                        if (_surprise == "True")
                        {
                            surprise = "1";
                        }
                        else
                        {
                            surprise = "0";
                        }

                        string supply_status = reader["supply_status"].ToString();
                        string food_billD = reader["food_bill"].ToString();

                        string _breakfast = reader["break_fast"].ToString();
                        string _lunch = reader["lunch"].ToString();
                        string _dinner = reader["dinner"].ToString();

                        double Num;
                        bool isNum = double.TryParse(_lunch, out Num);
                        if (isNum)
                        {
                            lunch = Int32.Parse(_lunch);

                        }
                        else
                        {
                            lunch = 0;

                        }
                        isNum = double.TryParse(_breakfast, out Num);
                        if (isNum)
                        {
                            breakfast = Int32.Parse(_breakfast);
                       }
                        else
                        {
                            breakfast = 0;
                        }
                        isNum = double.TryParse(_dinner, out Num);
                        if (isNum)
                        {
                            dinner = Int32.Parse(_dinner);
                        }
                        else
                        {
                            dinner = 0;
                        }

                        if (supply_status == "True")
                        {
                        }
                        else
                        {
                        }

                        firstNameTextBox.Text = first_name;
                        lastNameTextBox.Text = last_name;
                        phoneNTextBox.Text = phone_number;
                        roomTypeTextBox.Text = room_type;
                        floorNTextBox.Text = room_floor;
                        totalBill = Convert.ToDouble(total_bill);
                        foodBill = Convert.ToInt32(foodBillD);
                        totalBill -= foodBill;
                        primaryID = Convert.ToInt32(ID);

                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("COMBOBOX Selection: + " + ex.Message);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "SQL Connection is already open.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            {
                Int32 getIDBack = 0;
                string query = "insert into reservation(first_name, last_name, phone_number) values('" + firstNameTextBox.Text +"', '" + lastNameTextBox.Text + "', '" + phoneNTextBox.Text + "')";
                query += "SELECT CAST(scope_identity() AS int)";
                SqlConnection connection = new SqlConnection(Hotel_Manager.Properties.Settings.Default.frontend_reservationConnectionString);

                SqlCommand query_table = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    getIDBack = (Int32)query_table.ExecuteScalar();

                    string userID = Convert.ToString(getIDBack);
                    MetroFramework.MetroMessageBox.Show(this, "Poprawnie wprowadzono dane do bazy danych. " + "\n\n" +
                        "Unikalny numer klienta to:" + "\n\n" +
                    "" + userID, "RAPORT" +
                    "", MessageBoxButtons.OK, MessageBoxIcon.Question);

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //ComboBoxItemsFromDataBase();
                LoadForDataGridView();
              //  reset_frontend();
              //  GetOccupiedRoom();
               // ReservedRoom();
                //getChecked();
            }
        }

            private void supplyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            supply_status = true;
        }
        private void kitchen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
    }
}
