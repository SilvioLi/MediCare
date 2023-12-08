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
    public partial class MediCare__Payment : Form
    {
        public MySqlConnection connection;
        private DataGridViewRow row;
        private DataGridView r;
        double t1;
        double t2;
        double tax;
        double patientPays;
        double spPays;
        string spPaysMoney;
        string startTime;
        string paidState;
        String queryAppointments = "SELECT * FROM Appointments WHERE AptDate = @a AND Paid = '' ORDER by DocID, StartTime";
        String paidAppointments = "SELECT * FROM Appointments WHERE AptDate = @a AND Paid = 'Paid' ORDER by DocID, StartTime";
        bool clickable = true;
        double checkNum;
        string pID;

        public MediCare__Payment(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.ShowToday = true;
            addPaymentButton.Enabled = false;
            paymentButtons(false);
        }

        private void MediCare__Payment_Load(object sender, EventArgs e)
        {
            dateQuery(queryAppointments);

        }

        private void paymentButtons(bool state)
        {
            cashPay.Enabled = state;
            vmcPay.Enabled = state;
            debitPay.Enabled = state;
        }
        private void showPatientHistory()
        {
            String queryAppointments = "SELECT * FROM Payment WHERE PatientID = @a ORDER by Date";
            if (connection != null)
            {
                MySqlDataAdapter mcmd = new MySqlDataAdapter(queryAppointments, connection);
                mcmd.SelectCommand = new MySqlCommand(queryAppointments, connection);
                mcmd.SelectCommand.Parameters.AddWithValue("@a", pID);
                DataSet ds = new DataSet();
                mcmd.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Sorry no patient matches that name");
            }


        }

        private void dateQuery(string q)
        {
            string calenderDate = monthCalendar1.SelectionRange.Start.ToShortDateString();
            clickable = true;

            if (connection != null)
            {
                MySqlDataAdapter mcmd = new MySqlDataAdapter(q, connection);
                mcmd.SelectCommand = new MySqlCommand(q, connection);
                mcmd.SelectCommand.Parameters.AddWithValue("@a", calenderDate);
                DataSet ds = new DataSet();
                mcmd.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Sorry no patient matches that name");
            }


        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateQuery(queryAppointments);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (clickable == false)
                return;

            string getDate = "";

            if (e.RowIndex >= 0)
            {
                row = this.dataGridView1.Rows[e.RowIndex];
                pIdLabel.Text = row.Cells["PatientID"].Value.ToString();
                pLname.Text = row.Cells["LastName"].Value.ToString();
                pFname.Text = row.Cells["FirstName"].Value.ToString();
                getDate = row.Cells["AptDate"].Value.ToString();
                docIDlabel.Text = row.Cells["DocID"].Value.ToString();
                //////////////////////////////////////////////////////
                startTime = row.Cells["StartTime"].Value.ToString();
                paidState = row.Cells["Paid"].Value.ToString();
                date.Text = getDate.Substring(0, 10);
                pID = row.Cells["PatientID"].Value.ToString();

            }

            firstCost.Text = "50.00";
            percent1box.Text = "5";
            percent2box.Text = "7";
            spPercent.Text = "50";
            patPercent.Text = "50";
            tax1check.Checked = true;
            double secCost;
            secCost = double.Parse(firstCost.Text) + (double.Parse(firstCost.Text) * ((double.Parse(percent1box.Text)) / 100));
            secondCost.Text = secCost.ToString("#.##");
            addPaymentButton.Enabled = true;
            showPatientHistory();

        }
        private void calculateSecondCost()
        {
            try
            {

                double cost1 = 0;
                cost1 = double.Parse(firstCost.Text);
                double temp = 0;


                if (tax1check.Checked == true || tax2check.Checked == true)
                {
                    temp = 0;

                    if (tax1check.Checked == true && tax2check.Checked == true)
                    {
                        t1 = (double.Parse(percent1box.Text)) / 100;
                        t2 = (double.Parse(percent2box.Text)) / 100;
                        tax = (t1 + t2);
                    }
                    if (tax2check.Checked == true && tax1check.Checked == false)
                    {
                        t2 = (double.Parse(percent2box.Text)) / 100;
                        tax = t2;

                    }
                    if (tax1check.Checked == true && tax2check.Checked == false)
                    {
                        t1 = (double.Parse(percent1box.Text)) / 100;
                        tax = t1;

                    }

                    temp = Math.Round(cost1 + (cost1 * tax), 2);
                    secondCost.Text = temp.ToString("#.##");
                }
                else
                {
                    secondCost.Text = cost1.ToString("#.##");
                }
            }
            catch
            {
                MessageBox.Show("Please enter a positive number value");
            }

        }

        private void tax1check_CheckStateChanged(object sender, EventArgs e)
        {
            calculateSecondCost();
        }

        private void tax2check_CheckStateChanged(object sender, EventArgs e)
        {
            calculateSecondCost();
        }

        private void percent1box_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(percent1box.Text))
                return;
            else
            {
                calculateSecondCost();
            }
        }

        private void percent2box_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(percent2box.Text))
                return;
            else
            {
                calculateSecondCost();
            }
        }

        private void addPaymentButton_Click(object sender, EventArgs e)
        {
            addPayment();

        }
        private void addPayment()
        {
            try
            {
                patientPays = ((double.Parse(patPercent.Text)) / 100) * (double.Parse(secondCost.Text));
                spPays = ((double.Parse(spPercent.Text)) / 100) * (double.Parse(secondCost.Text));

                if (patientPays == 0)
                {
                    thirdCost.Text = "0.00";
                    spPaysMoney = spPays.ToString("#.##");
                }
                else if (spPays == 0)
                {
                    spPaysMoney = "0.00";
                    thirdCost.Text = patientPays.ToString("#.##");
                }
                else
                {
                    thirdCost.Text = patientPays.ToString("#.##");
                    spPaysMoney = spPays.ToString("#.##");
                }
                ///////////////////////////////////////////////////////////////////////////////////////////
                paymentButtons(true);
            }
            catch
            {
                MessageBox.Show("Please enter the percent amount for both payments. If none enter 0");
            }
        }

        private void spPercent_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(percent1box.Text))
                    return;
                else
                {
                    if (checkRange(spPercent.Text))
                    {
                        double difference = 100 - (double.Parse(spPercent.Text));
                        patPercent.Text = difference.ToString("#.##");
                        //  addPayment();

                    }
                }
            }
            catch
            {
                //  MessageBox.Show("Please enter a positive value between 0 and 100");
                thirdCost.Text = "";
                paymentButtons(false);
            }
        }

        private Boolean checkRange(string number)
        {
            checkNum = double.Parse(number);
            if (checkNum > 100 || checkNum < 0)
            {
                MessageBox.Show("Number must be between 0 and 100");
                spPercent.Text = "50";
                patPercent.Text = "50";
                return false;
            }
            else
                return true;
        }

        private void patPercent_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(percent2box.Text))
                    return;
                else
                {

                    if (checkRange(patPercent.Text))
                    {
                        double difference = 100 - (double.Parse(patPercent.Text));
                        spPercent.Text = difference.ToString("#.##");
                        //  addPayment();
                    }
                }
            }
            catch
            {
                //   MessageBox.Show("Please enter a positive value between 0 and 100");
                thirdCost.Text = "";
                paymentButtons(false);
            }
        }

        private void firstCost_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(firstCost.Text))
                    return;
                else
                {
                    calculateSecondCost();
                }
            }
            catch
            {
                MessageBox.Show("Please enter a positive number value");
            }
        }

        private string getProvider()
        {
            string getProviderQuery = "Select MedicalProvider from Patient WHERE PatientNumber = @a";
            MySqlCommand cmd = new MySqlCommand(getProviderQuery, connection);
            cmd.CommandText = getProviderQuery;
            cmd.Parameters.AddWithValue("@a", pIdLabel.Text);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            string spName = "";
            while (dataReader.Read())
            {
                spName = dataReader["MedicalProvider"].ToString();

            }
            dataReader.Close();
            return spName;
        }

        private void submitPayment()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(thirdCost.Text))
                    return;
                else
                {
                    // spPays = ((double.Parse(spPercent.Text)) / 100) * (double.Parse(secondCost.Text));

                    string submitPayQuery = "INSERT into Payment (PatientID, pFirstName, pLastName, DoctorID, Date, TotalAmount, Provider, BilledToSP, BilledToPat) " +
                          "VALUES (@a, @b, @c, @d, @e, @f, @g, @h, @i)";
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = submitPayQuery;
                    cmd.Parameters.AddWithValue("@a", pIdLabel.Text);
                    cmd.Parameters.AddWithValue("@b", pLname.Text);
                    cmd.Parameters.AddWithValue("@c", pFname.Text);
                    cmd.Parameters.AddWithValue("@d", docIDlabel.Text);
                    cmd.Parameters.AddWithValue("@e", date.Text);
                    cmd.Parameters.AddWithValue("@f", secondCost.Text);
                    cmd.Parameters.AddWithValue("@g", getProvider());
                    cmd.Parameters.AddWithValue("@h", spPaysMoney);
                    cmd.Parameters.AddWithValue("@i", thirdCost.Text);
                    cmd.ExecuteNonQuery();
                    updatePayment();
                }
            }
            catch
            {
                MessageBox.Show("This appointment cannot be settled, please try again");
            }

        }

        private void updatePayment()
        {
            string paidQuery = "UPDATE Appointments SET Paid = 'Paid'  WHERE (PatientID = @a AND AptDate = @b AND StartTime = @c)";
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = paidQuery;
            cmd.Parameters.AddWithValue("@a", pIdLabel.Text);
            cmd.Parameters.AddWithValue("@b", date.Text);
            cmd.Parameters.AddWithValue("@c", startTime);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Payment Successfull. Thank You.");
            dateQuery(queryAppointments);
            showPatientHistory();
            clearReceipt();

        }

        private void cashPay_Click(object sender, EventArgs e)
        {
            submitPayment();
        }

        private void paidAptButton_Click(object sender, EventArgs e)
        {
            clearReceipt();
            dateQuery(paidAppointments);
            clickable = false;
        }

        private void activeButton_Click(object sender, EventArgs e)
        {
            clearReceipt();
            dateQuery(queryAppointments);
        }

        private void vmcPay_Click(object sender, EventArgs e)
        {
            submitPayment();
        }

        private void debitPay_Click(object sender, EventArgs e)
        {
            submitPayment();
        }

        private void clearReceipt()
        {
            pIdLabel.Text = "";
            pFname.Text = "";
            pLname.Text = "";
            date.Text = "";
            docIDlabel.Text = "";
            firstCost.Text = "";
            secondCost.Text = "";
            spPercent.Text = "50";
            patPercent.Text = "50";
            percent1box.Text = "5";
            percent2box.Text = "7";
            thirdCost.Text = "";
        }

        private void thirdCost_TextChanged(object sender, EventArgs e)
        {
            return;
        }

    }
}
