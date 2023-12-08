using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Globalization;

namespace MediCare
{ 

    public partial class MediCare__Manager_Tools : Form
    {
        public MySqlConnection connection;
        string[] title = {"Doctor", "Nurse", "Manager", "Office Staff" };
        string[] wage = { "85.00", "55.00", "35.00", "15.50" };
        List<int> empNumbers = new List<int>();
      //  int doctorCount = 100;
      //  int nurseCount = 200;
      //  int managerCount = 300;
      //  int officeCount = 400;
        int count;
        string phone = "";
        string sin = "";
        string start_date = "";
        string end_date = "";
        bool check = true;
        String Employee = "Employee";
        string Provider = "Provider";
        string Patient = "Patient";
    
        public MediCare__Manager_Tools(MySqlConnection connection)
        {
            this.connection = connection;
            InitializeComponent();
            for (int i = 0; i < title.Length; i++)
            {
                titleComboBox.Items.Add(title[i]);
            }
        }

        private void getEmpIDSelection()
        {
            string query2 = "Select EmployeeID from Employee where Employee.Title = @a";

            if (connection != null)
            {
                MySqlCommand cmd = new MySqlCommand(query2, connection);
                cmd.Parameters.Add("@a", MySqlDbType.String).Value = titleComboBox.Text;
                MySqlDataReader dataReader = cmd.ExecuteReader();
                empNumbers.Clear();
                int eNum;
                while (dataReader.Read())
                {
     
                    eNum = int.Parse(dataReader["EmployeeID"].ToString());
                    empNumbers.Add(eNum);
                }
                dataReader.Close();

                foreach (int x in empNumbers)
                {
                    count = empNumbers.Max();
                    count++;
                    assignEmpIDBox.Text = count.ToString();
                }

                DateTime now = DateTime.Today;
                startDateBox.Text = now.ToShortDateString();
                int t = titleComboBox.SelectedIndex;
                wageBox.Text = wage[t];
            }
        }

        private void titleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            getEmpIDSelection();
        }

         private Boolean IsLetters(string value, string data)
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c))
                {
                    MessageBox.Show(data + " has to be all letters.");
                    return false;
                }
            }

            return true;
        }

        private Boolean check_phone(string data)
        {
            string subdata = "";
            phone = "";
            for (int i = 0; i < data.Length; i++)
            {
                int n;
                bool isNumeric = int.TryParse(data[i] + "", out n);
                if (isNumeric)
                {
                    subdata += data[i];
                }  
            }
            if(subdata.Length !=10)
            {
                MessageBox.Show("Phone number length is incorrect.");
                return true;
            }
            else
            {
                int j= 0;
                for (int i = 0; i < 12; i++)
                { 
                    if(i <= 2)
                    {
                        phone += subdata[j];
                        j++;
                    }
                    if( i == 3)
                    {
                        phone += "-";
                    }
                    if(i > 3 && i <=6)
                    {
                        phone += subdata[j];
                        j++;
                    }
                    if (i == 7)
                    {
                        phone += "-";
                    }
                    if(i > 7)
                    {
                        phone += subdata[j];
                        j++;
                    }
                }
                //MessageBox.Show(phone);
                    return false;
            }
        }

        private Boolean check_if_empty(string temp, string data)
        {
            string temp2 = temp.Trim();
             if (String.IsNullOrEmpty(temp2))
            {
                MessageBox.Show(data + " field is empty.");
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool check_sin(string data)
        {
            string subdata = "";
            sin = "";
            for (int i = 0; i < data.Length; i++)
            {
                int n;
                bool isNumeric = int.TryParse(data[i] + "", out n);
                if (isNumeric)
                {
                    subdata += data[i];
                }
            }
            if (subdata.Length != 9)
            {
                MessageBox.Show("Sin number length is incorrect.");
                return true;
            }
            else
            {
                int j = 0;
                for (int i = 0; i < 11; i++)
                {
                    if (i <= 2)
                    {
                        sin += subdata[j];
                        j++;
                    }
                    if (i == 3)
                    {
                        sin += "-";
                    }
                    if (i > 3 && i <= 6)
                    {
                        sin += subdata[j];
                        j++;
                    }
                    if (i == 7)
                    {
                        sin += "-";
                    }
                    if (i > 7)
                    {
                        sin += subdata[j];
                        j++;
                    }
                }
                //MessageBox.Show(sin);
                return false;
            }
        }

        private bool check_if_unique(string column, string table, string name, string box)
        {
            string query3 = "Select " +column + " from " + table;
            if (connection != null)
            {
                MySqlCommand cmd = new MySqlCommand(query3, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                string temp;
                while (dataReader.Read())
                {
                    temp = dataReader[column].ToString();
                    if (temp == box)
                    {
                        MessageBox.Show(name + " number already exists.");
                        dataReader.Close();
                        return true;
                    }
                }
                dataReader.Close();
            }
            return false;
        }

        private bool check_wge()
        {
            Regex rg2 = new Regex(@"([0-9]{2})[.]([0-9]{2})");
            Regex rg3 = new Regex(@"([0-9]{3})[.]([0-9]{2})");
            // MatchCollection m = rg.Matches(phoneBox.Text);
            if (rg2.IsMatch(wageBox.Text) == true || rg3.IsMatch(wageBox.Text) == true)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Wage format is incorrect.");
                return false;
            }
        }

        private bool check_date(string date, string data)
        {
            string subdata = "";
            string getdate = "";
            start_date = "";
            end_date = "";
            for (int i = 0; i < date.Length; i++)
            {
                int n;
                bool isNumeric = int.TryParse(date[i] + "", out n);
                if (isNumeric)
                {
                    subdata += date[i];
                }
            }
            if (subdata.Length != 8)
            {
                MessageBox.Show(data + " is incorrect.");
                return true;
            }
            else
            {
                int j = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (i <= 3)
                    {
                        getdate += subdata[j];
                        j++;
                    }
                    if (i == 4)
                    {
                        getdate += "-";
                    }
                    if (i > 4 && i <= 6)
                    {
                        getdate += subdata[j];
                        j++;
                    }
                    if (i == 7)
                    {
                        getdate += "-";
                    }
                    if (i > 7)
                    {
                        getdate += subdata[j];
                        j++;
                    }
                }

                if (data == "Start Date")
                {
                    if (CheckifValidDate(getdate, data))
                    {
                        start_date = getdate;
                    }
                }
                else
                {
                    if (CheckifValidDate(getdate, data))
                    {
                        end_date = getdate;
                    }
                }
                return false;
            }

        }

        protected bool CheckifValidDate(string date, string data)
        {
            DateTime Temp;


            if (DateTime.TryParse(date, out Temp) == true)
                return true;
            else
            {
                MessageBox.Show(data + " is not valid.");
                check = false;
                return false;
            }
        }

        private void addEmpButton_Click(object sender, EventArgs e)
        {
             check = true;
            //check to see first name and last name is not empty
            //check format for SIN, Phone Number, Wage, and Date
            //make program remember counter
            if (check_if_empty(titleComboBox.Text, "Title"))
            {
                check = false;
            }
            if (check_if_empty(fnameBox.Text, "First Name") || !IsLetters(fnameBox.Text.Trim(), "First Name"))
            {
                check = false;
            }
            if (check_if_empty(lnameBox.Text, "Last Name") || !IsLetters(lnameBox.Text.Trim(), "Last Name"))
            {
                check = false;
            }
            if (check_if_empty(sinBox.Text, "Sin") || check_sin(sinBox.Text) || check_if_unique("SIN", "Employee", "Sin", sinBox.Text))
            {
                check = false;
            }
            if (check_if_empty(wageBox.Text, "Wage") || !check_wge())
            {
                check = false;
            }
            if (check_if_empty(startDateBox.Text, "Start Date") || check_date(startDateBox.Text, "Start Date"))
            {
                check = false;
            }
            if ((endDateBox.Text.Trim() != ""))
            {
                if (check_date(endDateBox.Text, "End Date"))
                {
                    check = false;
                }
            }
            if (check_if_empty(addressBox.Text, "Address"))
            {
                check = false;
            }
            if (check_if_empty(phoneBox.Text, "Phone") || check_phone(phoneBox.Text) || check_if_unique("Phone", "Employee", "Phone", phoneBox.Text))
            {
                check = false;
            }

            if (check == true)
            {
                /*string query = "INSERT INTO Employee (Title, EmployeeID, First_Name, Last_Name, SIN, Wage, StartDate, EndDate, Address, Phone) " +
                               "VALUES (@a, @b, @c, @d, @e, @f, @g, @h, @i, @j)";
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;*/

                string nameOfProcedure = "AddEmployee";
                MySqlCommand cmd = new MySqlCommand(nameOfProcedure, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Title", titleComboBox.Text);
                cmd.Parameters.AddWithValue("@EmpID", assignEmpIDBox.Text);
                cmd.Parameters.AddWithValue("@FName", fnameBox.Text);
                cmd.Parameters.AddWithValue("@LName", lnameBox.Text);
                cmd.Parameters.AddWithValue("@SIN", sinBox.Text);
                cmd.Parameters.AddWithValue("@Wage", wageBox.Text);
                cmd.Parameters.AddWithValue("@StartDate", startDateBox.Text);
                if (String.IsNullOrEmpty(endDateBox.Text))
                {
                    cmd.Parameters.AddWithValue("@EndDate", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@EndDate", endDateBox.Text);
                }
                cmd.Parameters.AddWithValue("@Address", addressBox.Text);
                cmd.Parameters.AddWithValue("@Phone", phoneBox.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Employee has been added, Thank You.");
                populateGrid(Employee);
                clearEmployeeButtons();
            }
        }

        private void clearEmployeeButtons()
        {
            assignEmpIDBox.Text = "";
            titleComboBox.Items.Clear();
            fnameBox.Text = "";
            lnameBox.Text = "";
            sinBox.Text = "";
            wageBox.Text = "";
            startDateBox.Text = "";
            endDateBox.Text = "";
            addressBox.Text = "";
            phoneBox.Text = "";
        }

        private void addProviderButton_Click(object sender, EventArgs e)
        {
            if (providerNameBox.Text.Trim() == "")
            {
                MessageBox.Show("Please add a provider name");
            }
            else
            {
                string nameOfProcedure = "AddProvider";
                MySqlCommand cmd = new MySqlCommand(nameOfProcedure, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@aProvider", providerNameBox.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Provider has been added, Thank You.");
                populateGrid(Provider);
                providerNameBox.Text = "";
            }
        }

        private void viewProviderButton_Click(object sender, EventArgs e)
        {
            populateGrid(Provider);
        }


        private void populateGrid(string procedure)
        {
            if (connection != null)
            {
                string nameOfProcedure = procedure;
                MySqlCommand cmd = new MySqlCommand(nameOfProcedure, connection);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    displayGridView(cmd);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Cannot display at the moment. Please contact your service provider");
            }
        }

        private void displayGridView(MySqlCommand cmd)
        {
            MySqlDataAdapter mcd = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            mcd.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }



        private void viewEmpButton_Click(object sender, EventArgs e)
        {
            populateGrid(Employee);
        }

        private void viewPatientButton_Click(object sender, EventArgs e)
        {

            populateGrid(Patient);
        }

        private void viewProviderButton_Click_1(object sender, EventArgs e)
        {
            populateGrid(Provider);
        }

        private void MediCare__Manager_Tools_Load(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
