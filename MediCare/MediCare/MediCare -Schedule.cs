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
    public partial class MediCare__Schedule : Form
    {
        int startTime;
        int endTime;
        public MySqlConnection connection;
        DateTime selectedDate = DateTime.Today;
        private DataGridViewRow row;

        public MediCare__Schedule(MySqlConnection connection)
        {
            InitializeComponent();
            monthCalendar1.MaxSelectionCount = 1;
            GetTimeIntervals();
            endComboBox.Enabled = false;
            this.connection = connection;
            dateQuery(selectedDate);

        }


        private void MediCare__Schedule_Load(object sender, EventArgs e)
        {

            // populateGrid(queryPatient, connection);


        }

        private void dateQuery(DateTime day)
        {

            string queryAppointments = "SELECT * FROM Appointments WHERE AptDate = @a ORDER by DocID, StartTime";
            if (connection != null)
            {
                MySqlDataAdapter mcmd = new MySqlDataAdapter(queryAppointments, connection);
                mcmd.SelectCommand = new MySqlCommand(queryAppointments, connection);
                mcmd.SelectCommand.Parameters.AddWithValue("@a", day);
                DataSet ds = new DataSet();
                mcmd.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                txtDay.Text = day.ToShortDateString();
                dateBox.Text = day.ToShortDateString();
            }
            else
            {
                MessageBox.Show("Cannot connect to the database");
            }
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            selectedDate = selectedDate.AddDays(1);
            monthCalendar1.SetSelectionRange(monthCalendar1.SelectionRange.Start.AddDays(1), monthCalendar1.SelectionRange.Start.AddDays(1));
            dateQuery(selectedDate);
        }

        private void prev_button_Click(object sender, EventArgs e)
        {
            selectedDate = selectedDate.AddDays(-1);
            monthCalendar1.SetSelectionRange(monthCalendar1.SelectionRange.Start.AddDays(-1), monthCalendar1.SelectionRange.Start.AddDays(-1));
            dateQuery(selectedDate);
        }


        private void populateGrid(String pass_query, MySqlConnection connection)
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
        public void GetTimeIntervals()
        {

            List<string> timeIntervals = new List<string>();
            DateTime date = DateTime.MinValue.AddHours(6);
            DateTime endDate = DateTime.MinValue.AddHours(21).AddMinutes(15);

            while (date < endDate)
            {
                timeIntervals.Add(date.ToString("HH:mm"));
                date = date.AddMinutes(15);
            }

            foreach (var t in timeIntervals)
            {
                startComboBox.Items.Add(t);
            }

            while (date < endDate.AddHours(1))
            {
                timeIntervals.Add(date.ToString("HH:mm"));
                date = date.AddMinutes(15);
            }
            foreach (var t in timeIntervals)
            {
                endComboBox.Items.Add(t);
            }

        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateBox.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
            dateQuery(monthCalendar1.SelectionRange.Start);
        }

        private void startComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            endComboBox.Enabled = true;
        }
        private Boolean checkTimes()
        {
            startTime = startComboBox.SelectedIndex;
            endTime = endComboBox.SelectedIndex;
            if (startComboBox.SelectedIndex < endComboBox.SelectedIndex)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Appointment end time must be later than start time");
                return false;
            }
        }

        private void endComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkTimes())
            {
                //proceed to next step
            }
            else
            {
                //re enter
            }
        }


        private void scheduleIt_Button_Click(object sender, EventArgs e)
        {
            if (timeChecks())
            {

               /* string query = "INSERT INTO Appointments (PatientID, DocID, FirstName, LastName, StartTime, EndTime, AptDate) " +
                              "VALUES (@a, @b, @c, @d, @e, @f, @g)";
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;*/

                string nameOfProcedure = "AddAppointment";
                MySqlCommand cmd = new MySqlCommand(nameOfProcedure, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PID", Int32.Parse(patIDComboBox.Text));
                cmd.Parameters.AddWithValue("@DocID", docNumBox.Text);
                cmd.Parameters.AddWithValue("@FName", fnameBox.Text);
                cmd.Parameters.AddWithValue("@LName", lnameBox.Text);
                cmd.Parameters.AddWithValue("@Start", startComboBox.Text);
                cmd.Parameters.AddWithValue("@End", endComboBox.Text);
                cmd.Parameters.AddWithValue("@AptDate", dateBox.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Appointment has been booked");
                dateQuery(selectedDate);
                clearAppointmentButtons();
            }
           
        }
        private void clearAppointmentButtons()
        {
            dateBox.Text = "";
            fnameBox.Text = "";
            lnameBox.Text = "";
            patIDComboBox.Items.Clear();
            docNumBox.Text = "";
            startComboBox.Items.Clear();
            endComboBox.Items.Clear();
            endComboBox.Enabled = false;
        }

        private void patIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            string queryGetPatNumber = "Select DoctorID from Patient WHERE PatientNumber = @a";

            if (connection != null)
            {
                MySqlCommand cmd = new MySqlCommand(queryGetPatNumber, connection);
                cmd.CommandText = queryGetPatNumber;
                cmd.Parameters.AddWithValue("@a", patIDComboBox.Text);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                string docID = "";
                while (dataReader.Read())
                {
                    docID = dataReader["DoctorID"].ToString();

                }
                dataReader.Close();
                docNumBox.Text = docID;

            }
            else
            {
                MessageBox.Show("Sorry cannot retreive patient's Doctor ID.");
            }

        }

        private void patIDComboBox_MouseClick_1(object sender, MouseEventArgs e)
        {
            patIDComboBox.Items.Clear();
            string queryGetPatNumber = "Select PatientNumber from Patient WHERE FirstName = @a AND LastName = @b";
            if (connection != null)
            {
                MySqlCommand cmd = new MySqlCommand(queryGetPatNumber, connection);
                cmd.CommandText = queryGetPatNumber;
                cmd.Parameters.AddWithValue("@a", fnameBox.Text);
                cmd.Parameters.AddWithValue("@b", lnameBox.Text);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                List<int> patNumbers = new List<int>();
                int num;
                patNumbers.Clear();
                while (dataReader.Read())
                {
                    num = int.Parse(dataReader["PatientNumber"].ToString());
                    patNumbers.Add(num);
                }
                dataReader.Close();
                foreach (var n in patNumbers)
                    patIDComboBox.Items.Add(n);
            }
            else
            {
                MessageBox.Show("Sorry no patient matches that name");
            }


        }

        private Boolean timeChecks()
        {
            string queryGetPatNumber = "Select StartTime, EndTime from Appointments WHERE (DocID = @a AND AptDate = @b)";
            if (connection != null)
            {
                MySqlCommand cmd = new MySqlCommand(queryGetPatNumber, connection);
                cmd.CommandText = queryGetPatNumber;
                cmd.Parameters.AddWithValue("@a", docNumBox.Text);
                cmd.Parameters.AddWithValue("@b", dateBox.Text);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                DateTime sdate = new DateTime();
                DateTime edate = new DateTime();
                DateTime timeSelectedstart = Convert.ToDateTime(startComboBox.Text);
                DateTime timeSelectedend = Convert.ToDateTime(endComboBox.Text);
                while (dataReader.Read())
                {
                    sdate = Convert.ToDateTime(dataReader["StartTime"].ToString());
                    edate = Convert.ToDateTime(dataReader["EndTime"].ToString());

                    if (sdate < timeSelectedstart && timeSelectedstart < edate)
                    {
                        MessageBox.Show("This time slot is already filled. Please choose another time.");
                        dataReader.Close();
                        return false;
                        
                    }
                    else if (sdate < timeSelectedend && timeSelectedend < edate)
                    {
                        MessageBox.Show("This time slot is already filled. Please choose another time.");
                        dataReader.Close();
                        return false;
                    }
                    
                }
                dataReader.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Unable to check time slot availability, please contact your service provider");
                return false;
            }
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtDoctorNote.Text = "";
                PID.Text = "";
                Date.Text = "";
                row = this.dataGridView1.Rows[e.RowIndex];
                PID.Text = row.Cells["PatientID"].Value.ToString();
                DateTime temp = DateTime.Parse(row.Cells["AptDate"].Value.ToString());
                Date.Text = temp.ToShortDateString();
                try
                {
                    string getNote = "Select PatientID,Date,Notes from Visits WHERE PatientID = @a AND Date = @b";
                    MySqlCommand cmd = new MySqlCommand(getNote, connection);
                    cmd.CommandText = getNote;
                    cmd.Parameters.AddWithValue("@a", PID.Text);
                    cmd.Parameters.AddWithValue("@b", DateTime.Parse(Date.Text));
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    List<string> patNumbers = new List<string>();
                    string note;
                    while (dataReader.Read())
                    {
                        note = dataReader["Notes"].ToString();
                        txtDoctorNote.Text = note;
                    }
                    dataReader.Close();

                }
                catch (Exception ex)
                {
                    txtDoctorNote.Text = "";
                }
            }
   
        }

        private bool exist_note()
        {

            string queryGetPatNumber = "Select PatientID, from Patient WHERE FirstName = @a AND LastName = @b";
            if (connection != null)
            {
                MySqlCommand cmd = new MySqlCommand(queryGetPatNumber, connection);
                cmd.CommandText = queryGetPatNumber;
                cmd.Parameters.AddWithValue("@a", fnameBox.Text);
                cmd.Parameters.AddWithValue("@b", lnameBox.Text);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                List<int> patNumbers = new List<int>();
                int num;
                patNumbers.Clear();
                while (dataReader.Read())
                {
                    num = int.Parse(dataReader["PatientNumber"].ToString());
                    patNumbers.Add(num);
                }
                dataReader.Close();
                foreach (var n in patNumbers)
                    patIDComboBox.Items.Add(n);
            }

            return true;
        }

        private void BtnAddNote_Click(object sender, EventArgs e)
        {
            if (txtDoctorNote.Text == "")
            {
                MessageBox.Show("Please add a note");
            }
            else
            {
                string nameOfProcedure = "AddVisit";
                MySqlCommand cmd = new MySqlCommand(nameOfProcedure, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PID", Int32.Parse(PID.Text));
                cmd.Parameters.AddWithValue("@Date", Date.Text);
                cmd.Parameters.AddWithValue("@Notes", txtDoctorNote.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Note has been submitted");

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
                string updateNotes = "Update Visits SET Notes = @Note where PatientID = @PID and Date = @date";

                MySqlCommand cmd = new MySqlCommand(updateNotes, connection);
                cmd.CommandText = updateNotes;
                cmd.Parameters.AddWithValue("@PID", PID.Text);
                cmd.Parameters.AddWithValue("@date", DateTime.Parse(Date.Text));
                cmd.Parameters.AddWithValue("@Note", txtDoctorNote.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Note has been updated");
            
        }



    }
}
