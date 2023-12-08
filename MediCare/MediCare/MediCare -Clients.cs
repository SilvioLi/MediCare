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

namespace MediCare
{
    public partial class MediCare__Clients : Form
    {

        public MySqlConnection connection;
        List<String> empID = new List<string>();
        List<String> spList = new List<string>();
        private DataGridViewRow row;
        string Patient = "Patient";
        bool check = true;
        string phone = "";


        public MediCare__Clients(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            getProcedure("GetCompany", "CompanyName", spList);
            getProcedure("GetDoctorID", "EmployeeID", empID);
            setUpComboBox();
        }
  
        private void setUpComboBox()
        {
            foreach (var s in spList)
                providerComboBox.Items.Add(s);

            foreach (var e in empID)
                docIDComboBox.Items.Add(e);

        }

        private void getProcedure(string procedure, string name, List<string> a)
        {
            if (connection != null)
            {
                MySqlCommand cmd = new MySqlCommand(procedure, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataReader dataReader = cmd.ExecuteReader();
                empID.Clear();
                string e;
                while (dataReader.Read())
                {
                    e = dataReader[name].ToString();
                    a.Add(e);
                }
                dataReader.Close();
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
            if (subdata.Length != 10)
            {
                MessageBox.Show("Phone number length is incorrect.");
                return true;
            }
            else
            {
                int j = 0;
                for (int i = 0; i < 12; i++)
                {
                    if (i <= 2)
                    {
                        phone += subdata[j];
                        j++;
                    }
                    if (i == 3)
                    {
                        phone += "-";
                    }
                    if (i > 3 && i <= 6)
                    {
                        phone += subdata[j];
                        j++;
                    }
                    if (i == 7)
                    {
                        phone += "-";
                    }
                    if (i > 7)
                    {
                        phone += subdata[j];
                        j++;
                    }
                }
                //MessageBox.Show(phone);
                return false;
            }
        }

        private bool check_if_unique(string column, string table, string name, string box)
        {
            string query3 = "Select " + column + " from " + table;
            if (connection != null)
            {
                MySqlCommand cmd = new MySqlCommand(query3, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                string sintemp;
                while (dataReader.Read())
                {
                    sintemp = dataReader[column].ToString();
                    if (sintemp == box)
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
        private void addPatientButton_Click(object sender, EventArgs e)
        {
            check = true;
             if (check_if_empty(pFirstInputBox.Text, "First Name") || !IsLetters(pFirstInputBox.Text.Trim(), "First Name"))
            {
                check = false;
            }
            if (check_if_empty(pLastInputBox.Text, "Last Name") || !IsLetters(pLastInputBox.Text.Trim(), "Last Name"))
            {
                check = false;
            }
            if (check_if_empty(docIDComboBox.Text, "Doctor ID"))
            {
                check = false;
            }
            if (check_if_empty(pPhoneInputBox.Text, "Phone") || check_phone(pPhoneInputBox.Text) || check_if_unique("Phone", "Employee", "Phone", pPhoneInputBox.Text))
            {
                check = false;
            }
            if (check_if_empty(providerComboBox.Text, "Doctor ID"))
            {
                check = false;
            }
            if (check_if_empty(providerComboBox.Text, "Provider"))
            {
                check = false;
            }
            if (check_if_empty(pAddressInputBox.Text, "Address"))
            {
                check = false;
            }

            if (check == true)
            {
                try
                {
                    string nameOfProcedure = "AddPatient";
                    MySqlCommand cmd = new MySqlCommand(nameOfProcedure, connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FName", pFirstInputBox.Text);
                    cmd.Parameters.AddWithValue("@LName", pLastInputBox.Text);
                    cmd.Parameters.AddWithValue("@DocID", Int32.Parse(docIDComboBox.Text));
                    cmd.Parameters.AddWithValue("@Provider", providerComboBox.Text);
                    cmd.Parameters.AddWithValue("@ID", pIdInputBox.Text);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@Address", pAddressInputBox.Text);
                    cmd.Parameters["@FName"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@LName"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@DocID"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@Provider"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@ID"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@phone"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@Address"].Direction = ParameterDirection.Input;

                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Patient has been successfully added.");
                    populate(Patient);
                    clearClientButtons();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void populate(string procedure)
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


        private void populateGrid(String pass_query)
        {
            if (connection != null)
            {
                MySqlDataAdapter mcmd = new MySqlDataAdapter(pass_query, connection);
                DataSet ds = new DataSet();
                mcmd.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Cannot display at the moment. Please contact your service provider");
            }

        }
        private void filterButton_Click(object sender, EventArgs e)
        {
            if (connection != null)
            {
                if (lnameSearchBox.Text.Trim() == "")
                {
                    MessageBox.Show("Please input a last name");
                }
                else
                {
                    string nameOfProcedure = "FilterPatient";
                    MySqlCommand cmd = new MySqlCommand(nameOfProcedure, connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@LName", lnameSearchBox.Text);
                    cmd.Parameters["@LName"].Direction = ParameterDirection.Input;
                    displayGridView(cmd);
                }
            }
            else
            {
                MessageBox.Show("Please check connection.");
            }
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            populate(Patient); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                row = this.dataGridView1.Rows[e.RowIndex];
                pFirstInputBox.Text = row.Cells["FirstName"].Value.ToString();
                pLastInputBox.Text = row.Cells["LastName"].Value.ToString();
                docIDComboBox.Text = row.Cells["DoctorID"].Value.ToString();
                providerComboBox.Text = row.Cells["MedicalProvider"].Value.ToString();
                pIdInputBox.Text = row.Cells["Identification"].Value.ToString();
                pPhoneInputBox.Text = row.Cells["PhoneNumber"].Value.ToString();
                pAddressInputBox.Text = row.Cells["Address"].Value.ToString();
                label8.Text = row.Cells["PatientNumber"].Value.ToString();
            }
   

        }

        private void clearClientButtons()
        {
            pFirstInputBox.Text = "";
            pLastInputBox.Text = "";
            docIDComboBox.Items.Clear();
            providerComboBox.Text = "";
            pIdInputBox.Text = "";
            pPhoneInputBox.Text = "";
            pAddressInputBox.Text = ""; 

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearClientButtons();
        }
     
        private void updateButton_Click(object sender, EventArgs e)
        {
            check = true;
             if (check_if_empty(pFirstInputBox.Text, "First Name") || !IsLetters(pFirstInputBox.Text.Trim(), "First Name"))
            {
                check = false;
            }
            if (check_if_empty(pLastInputBox.Text, "Last Name") || !IsLetters(pLastInputBox.Text.Trim(), "Last Name"))
            {
                check = false;
            }
            if (check_if_empty(docIDComboBox.Text, "Doctor ID"))
            {
                check = false;
            }
            if (check_if_empty(pPhoneInputBox.Text, "Phone") || check_phone(pPhoneInputBox.Text) || check_if_unique("Phone", "Employee", "Phone", pPhoneInputBox.Text))
            {
                check = false;
            }
            if (check_if_empty(providerComboBox.Text, "Doctor ID"))
            {
                check = false;
            }
            if (check_if_empty(providerComboBox.Text, "Provider"))
            {
                check = false;
            }
            if (check_if_empty(pAddressInputBox.Text, "Address"))
            {
                check = false;
            }

            if (check == true)
            {
                string nameOfProcedure = "UpdatePatient";
                MySqlCommand cmd = new MySqlCommand(nameOfProcedure, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FName", pFirstInputBox.Text);
                cmd.Parameters.AddWithValue("@LName", pLastInputBox.Text);
                cmd.Parameters.AddWithValue("@DocID", Int32.Parse(docIDComboBox.Text));
                cmd.Parameters.AddWithValue("@Provider", providerComboBox.Text);
                cmd.Parameters.AddWithValue("@ID", pIdInputBox.Text);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Address", pAddressInputBox.Text);
                cmd.Parameters.AddWithValue("@PID", Int32.Parse(label8.Text));

                cmd.Parameters["@FName"].Direction = ParameterDirection.Input;
                cmd.Parameters["@LName"].Direction = ParameterDirection.Input;
                cmd.Parameters["@DocID"].Direction = ParameterDirection.Input;
                cmd.Parameters["@Provider"].Direction = ParameterDirection.Input;
                cmd.Parameters["@ID"].Direction = ParameterDirection.Input;
                cmd.Parameters["@phone"].Direction = ParameterDirection.Input;
                cmd.Parameters["@Address"].Direction = ParameterDirection.Input;
                cmd.Parameters["@PID"].Direction = ParameterDirection.Input;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient has been UPDATED.");
                populate(Patient);
                clearClientButtons();
                setUpComboBox();
            }
        }

        private void MediCare__Clients_Load(object sender, EventArgs e)
        {

        }



    }
}
