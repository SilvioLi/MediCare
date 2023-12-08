using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediCare
{
    public partial class Form1 : Form
    {
        private DatabaseConnect dbconn;
        public MySqlConnection connection;

        ///////FORM NAMES//////////
        LogIn login;
        MediCare__Clients clients;
        MediCare__Schedule schedule;
        MediCare__Manager_Tools manager;
        MediCare__Payment payment;
        ///////FORM NAMES///////////

        public void CreateChildForm(Form childForm)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            childForm.MdiParent = this;
            childForm.Show();

        }

        public Form1()
        {
            InitializeComponent();
            menuStrip1.ForeColor = Color.White;
            scheduleToolStripMenuItem.Enabled = false;
            clientLookUpToolStripMenuItem.Enabled = false;
            managerToolsToolStripMenuItem.Enabled = false;
            paymentToolStripMenuItem.Enabled = false;
        }

        public void reset()
        {
            flowLayoutPanel1.Show();
            scheduleToolStripMenuItem.Enabled = true;
            clientLookUpToolStripMenuItem.Enabled = true;
            managerToolsToolStripMenuItem.Enabled = true;
            paymentToolStripMenuItem.Enabled = true;
            loginToolStripMenuItem.Text = "Log Out";
        }

        public void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            schedule = new MediCare__Schedule(connection);
            schedule.FormClosing += schedule_FormClosing;
            CreateChildForm(schedule);
            flowLayoutPanel1.Hide();
        }

        void schedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            flowLayoutPanel1.Show();
        }

        public void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loginToolStripMenuItem.Text == "Log Out")
            {
                MessageBox.Show("You have successfully logged off");
                scheduleToolStripMenuItem.Enabled = false;
                clientLookUpToolStripMenuItem.Enabled = false;
                managerToolsToolStripMenuItem.Enabled = false;
                paymentToolStripMenuItem.Enabled = false;
                if (this.ActiveMdiChild != null)
                {
                    this.ActiveMdiChild.Close();
                }
                loginToolStripMenuItem.Text = "Log In";
            }
            else
            {
                login = new LogIn();
                login.FormClosing += login_FormClosing;
                login.Show();
                login.MdiParent = this;
                flowLayoutPanel1.Hide();

            }
        }

        void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (login.valid == true)
            {
                reset();
                connect();
            }
            else
            {
                flowLayoutPanel1.Show();
            }
        }

        private void clientLookUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clients = new MediCare__Clients(connection);
            clients.FormClosing += clients_FormClosing;
            CreateChildForm(clients);
            flowLayoutPanel1.Hide();
        }

        void clients_FormClosing(object sender, FormClosingEventArgs e)
        {
            flowLayoutPanel1.Show();
        }

        private void managerToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manager = new MediCare__Manager_Tools(connection);
            manager.FormClosing += manager_FormClosing;
            CreateChildForm(manager);
            flowLayoutPanel1.Hide();
        }

        void manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            flowLayoutPanel1.Show();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            payment = new MediCare__Payment(connection);
            payment.FormClosing += payment_FormClosing;
            CreateChildForm(payment);
            flowLayoutPanel1.Hide();
        }

        void payment_FormClosing(object sender, FormClosingEventArgs e)
        {
            flowLayoutPanel1.Show();
        }

        ////////////////////////////////////
        //////END OF FORM CONNECTIONS///////
        ////////////////////////////////////

        private void connect()
        {
            dbconn = new DatabaseConnect("logOnInfo.txt");
            connection = new MySqlConnection(dbconn.ToString());
            connection.Open();
            if (connection == null)
            {
                MessageBox.Show("Sorry, there has been an error trying to connect to the database. Please contact your Service Provider");
            }
        }
    }
}