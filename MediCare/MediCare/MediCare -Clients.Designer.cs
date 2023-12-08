namespace MediCare
{
    partial class MediCare__Clients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.lnameSearchBox = new System.Windows.Forms.TextBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pFirstInputBox = new System.Windows.Forms.TextBox();
            this.pLastInputBox = new System.Windows.Forms.TextBox();
            this.pPhoneInputBox = new System.Windows.Forms.TextBox();
            this.pIdInputBox = new System.Windows.Forms.TextBox();
            this.pAddressInputBox = new System.Windows.Forms.TextBox();
            this.docIDComboBox = new System.Windows.Forms.ComboBox();
            this.providerComboBox = new System.Windows.Forms.ComboBox();
            this.addPatientButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.Patients = new System.Windows.Forms.GroupBox();
            this.showAllButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Patients.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(51, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(925, 210);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Search Last Name: ";
            // 
            // lnameSearchBox
            // 
            this.lnameSearchBox.Location = new System.Drawing.Point(206, 33);
            this.lnameSearchBox.Name = "lnameSearchBox";
            this.lnameSearchBox.Size = new System.Drawing.Size(173, 26);
            this.lnameSearchBox.TabIndex = 19;
            // 
            // filterButton
            // 
            this.filterButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.filterButton.Location = new System.Drawing.Point(399, 33);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(78, 26);
            this.filterButton.TabIndex = 20;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(490, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doctor ID: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Provider: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(246, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Identification #: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(694, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(490, 76);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Address:";
            // 
            // pFirstInputBox
            // 
            this.pFirstInputBox.Location = new System.Drawing.Point(97, 34);
            this.pFirstInputBox.Name = "pFirstInputBox";
            this.pFirstInputBox.Size = new System.Drawing.Size(142, 26);
            this.pFirstInputBox.TabIndex = 7;
            // 
            // pLastInputBox
            // 
            this.pLastInputBox.Location = new System.Drawing.Point(329, 34);
            this.pLastInputBox.Name = "pLastInputBox";
            this.pLastInputBox.Size = new System.Drawing.Size(148, 26);
            this.pLastInputBox.TabIndex = 8;
            // 
            // pPhoneInputBox
            // 
            this.pPhoneInputBox.Location = new System.Drawing.Point(802, 36);
            this.pPhoneInputBox.Name = "pPhoneInputBox";
            this.pPhoneInputBox.Size = new System.Drawing.Size(168, 26);
            this.pPhoneInputBox.TabIndex = 9;
            // 
            // pIdInputBox
            // 
            this.pIdInputBox.Location = new System.Drawing.Point(349, 68);
            this.pIdInputBox.Name = "pIdInputBox";
            this.pIdInputBox.Size = new System.Drawing.Size(128, 26);
            this.pIdInputBox.TabIndex = 11;
            // 
            // pAddressInputBox
            // 
            this.pAddressInputBox.Location = new System.Drawing.Point(556, 71);
            this.pAddressInputBox.Name = "pAddressInputBox";
            this.pAddressInputBox.Size = new System.Drawing.Size(414, 26);
            this.pAddressInputBox.TabIndex = 12;
            // 
            // docIDComboBox
            // 
            this.docIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.docIDComboBox.FormattingEnabled = true;
            this.docIDComboBox.Location = new System.Drawing.Point(565, 34);
            this.docIDComboBox.Name = "docIDComboBox";
            this.docIDComboBox.Size = new System.Drawing.Size(121, 28);
            this.docIDComboBox.TabIndex = 13;
            // 
            // providerComboBox
            // 
            this.providerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.providerComboBox.FormattingEnabled = true;
            this.providerComboBox.Location = new System.Drawing.Point(97, 66);
            this.providerComboBox.Name = "providerComboBox";
            this.providerComboBox.Size = new System.Drawing.Size(142, 28);
            this.providerComboBox.TabIndex = 14;
            // 
            // addPatientButton
            // 
            this.addPatientButton.ForeColor = System.Drawing.Color.Black;
            this.addPatientButton.Location = new System.Drawing.Point(697, 103);
            this.addPatientButton.Name = "addPatientButton";
            this.addPatientButton.Size = new System.Drawing.Size(80, 33);
            this.addPatientButton.TabIndex = 16;
            this.addPatientButton.Text = "Add";
            this.addPatientButton.UseVisualStyleBackColor = true;
            this.addPatientButton.Click += new System.EventHandler(this.addPatientButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.updateButton);
            this.groupBox1.Controls.Add(this.addPatientButton);
            this.groupBox1.Controls.Add(this.providerComboBox);
            this.groupBox1.Controls.Add(this.docIDComboBox);
            this.groupBox1.Controls.Add(this.pFirstInputBox);
            this.groupBox1.Controls.Add(this.pAddressInputBox);
            this.groupBox1.Controls.Add(this.pLastInputBox);
            this.groupBox1.Controls.Add(this.pIdInputBox);
            this.groupBox1.Controls.Add(this.pPhoneInputBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1017, 156);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Patient Information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // clearButton
            // 
            this.clearButton.ForeColor = System.Drawing.Color.Black;
            this.clearButton.Location = new System.Drawing.Point(899, 103);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(71, 33);
            this.clearButton.TabIndex = 18;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.ForeColor = System.Drawing.Color.Black;
            this.updateButton.Location = new System.Drawing.Point(802, 103);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(78, 33);
            this.updateButton.TabIndex = 17;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // Patients
            // 
            this.Patients.Controls.Add(this.showAllButton);
            this.Patients.Controls.Add(this.dataGridView1);
            this.Patients.Controls.Add(this.label9);
            this.Patients.Controls.Add(this.filterButton);
            this.Patients.Controls.Add(this.lnameSearchBox);
            this.Patients.Location = new System.Drawing.Point(3, 222);
            this.Patients.Name = "Patients";
            this.Patients.Size = new System.Drawing.Size(1017, 295);
            this.Patients.TabIndex = 22;
            this.Patients.TabStop = false;
            this.Patients.Text = "Patients";
            // 
            // showAllButton
            // 
            this.showAllButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.showAllButton.Location = new System.Drawing.Point(483, 33);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(87, 25);
            this.showAllButton.TabIndex = 21;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // MediCare__Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1024, 529);
            this.Controls.Add(this.Patients);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MediCare__Clients";
            this.ShowIcon = false;
            this.Text = "MediCare__Clients";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MediCare__Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Patients.ResumeLayout(false);
            this.Patients.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lnameSearchBox;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pFirstInputBox;
        private System.Windows.Forms.TextBox pLastInputBox;
        private System.Windows.Forms.TextBox pPhoneInputBox;
        private System.Windows.Forms.TextBox pIdInputBox;
        private System.Windows.Forms.TextBox pAddressInputBox;
        private System.Windows.Forms.ComboBox docIDComboBox;
        private System.Windows.Forms.ComboBox providerComboBox;
        private System.Windows.Forms.Button addPatientButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Patients;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.Label label8;

    }
}