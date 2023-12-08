namespace MediCare
{
    partial class MediCare__Schedule
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
            this.label1 = new System.Windows.Forms.Label();
            this.displayDateLabel = new System.Windows.Forms.Label();
            this.prev_button = new System.Windows.Forms.Button();
            this.next_button = new System.Windows.Forms.Button();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.lnameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.startComboBox = new System.Windows.Forms.ComboBox();
            this.endComboBox = new System.Windows.Forms.ComboBox();
            this.patIDComboBox = new System.Windows.Forms.ComboBox();
            this.scheduleIt_Button = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label7 = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.docNumBox = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.Label();
            this.txtDoctorNote = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnAddNote = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.PID = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.Location = new System.Drawing.Point(13, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 242);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(297, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Day: ";
            // 
            // displayDateLabel
            // 
            this.displayDateLabel.AutoSize = true;
            this.displayDateLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayDateLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.displayDateLabel.Location = new System.Drawing.Point(314, 26);
            this.displayDateLabel.Name = "displayDateLabel";
            this.displayDateLabel.Size = new System.Drawing.Size(0, 25);
            this.displayDateLabel.TabIndex = 2;
            // 
            // prev_button
            // 
            this.prev_button.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prev_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.prev_button.Location = new System.Drawing.Point(221, 23);
            this.prev_button.Name = "prev_button";
            this.prev_button.Size = new System.Drawing.Size(70, 31);
            this.prev_button.TabIndex = 3;
            this.prev_button.Text = "<< prev";
            this.prev_button.UseVisualStyleBackColor = true;
            this.prev_button.Click += new System.EventHandler(this.prev_button_Click);
            // 
            // next_button
            // 
            this.next_button.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.next_button.Location = new System.Drawing.Point(468, 23);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(71, 31);
            this.next_button.TabIndex = 4;
            this.next_button.Text = "next >>";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // fnameBox
            // 
            this.fnameBox.Location = new System.Drawing.Point(886, 279);
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(121, 20);
            this.fnameBox.TabIndex = 5;
            // 
            // lnameBox
            // 
            this.lnameBox.Location = new System.Drawing.Point(886, 305);
            this.lnameBox.Name = "lnameBox";
            this.lnameBox.Size = new System.Drawing.Size(121, 20);
            this.lnameBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(786, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "First Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(786, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Last Name: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(792, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Patient ID: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(790, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Start Time: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(798, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "End Time: ";
            // 
            // startComboBox
            // 
            this.startComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startComboBox.FormattingEnabled = true;
            this.startComboBox.Location = new System.Drawing.Point(886, 384);
            this.startComboBox.Name = "startComboBox";
            this.startComboBox.Size = new System.Drawing.Size(121, 21);
            this.startComboBox.TabIndex = 15;
            this.startComboBox.SelectedIndexChanged += new System.EventHandler(this.startComboBox_SelectedIndexChanged);
            // 
            // endComboBox
            // 
            this.endComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endComboBox.FormattingEnabled = true;
            this.endComboBox.Location = new System.Drawing.Point(886, 411);
            this.endComboBox.Name = "endComboBox";
            this.endComboBox.Size = new System.Drawing.Size(121, 21);
            this.endComboBox.TabIndex = 16;
            this.endComboBox.SelectedIndexChanged += new System.EventHandler(this.endComboBox_SelectedIndexChanged);
            // 
            // patIDComboBox
            // 
            this.patIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patIDComboBox.FormattingEnabled = true;
            this.patIDComboBox.Location = new System.Drawing.Point(886, 331);
            this.patIDComboBox.Name = "patIDComboBox";
            this.patIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.patIDComboBox.TabIndex = 17;
            this.patIDComboBox.SelectedIndexChanged += new System.EventHandler(this.patIDComboBox_SelectedIndexChanged);
            this.patIDComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.patIDComboBox_MouseClick_1);
            // 
            // scheduleIt_Button
            // 
            this.scheduleIt_Button.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleIt_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.scheduleIt_Button.Location = new System.Drawing.Point(886, 447);
            this.scheduleIt_Button.Name = "scheduleIt_Button";
            this.scheduleIt_Button.Size = new System.Drawing.Size(121, 27);
            this.scheduleIt_Button.TabIndex = 18;
            this.scheduleIt_Button.Text = "Schedule It";
            this.scheduleIt_Button.UseVisualStyleBackColor = true;
            this.scheduleIt_Button.Click += new System.EventHandler(this.scheduleIt_Button_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(780, 60);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 19;
            this.monthCalendar1.TitleBackColor = System.Drawing.SystemColors.HotTrack;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(797, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Apt Date:  ";
            // 
            // dateBox
            // 
            this.dateBox.Enabled = false;
            this.dateBox.Location = new System.Drawing.Point(886, 253);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(121, 20);
            this.dateBox.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(810, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Doctor:";
            // 
            // docNumBox
            // 
            this.docNumBox.Location = new System.Drawing.Point(886, 358);
            this.docNumBox.Name = "docNumBox";
            this.docNumBox.Size = new System.Drawing.Size(121, 20);
            this.docNumBox.TabIndex = 23;
            // 
            // txtDay
            // 
            this.txtDay.AutoSize = true;
            this.txtDay.Font = new System.Drawing.Font("Franklin Gothic Book", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDay.ForeColor = System.Drawing.Color.Maroon;
            this.txtDay.Location = new System.Drawing.Point(343, 26);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(96, 26);
            this.txtDay.TabIndex = 24;
            this.txtDay.Text = "MAMAMA";
            // 
            // txtDoctorNote
            // 
            this.txtDoctorNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorNote.Location = new System.Drawing.Point(15, 26);
            this.txtDoctorNote.Multiline = true;
            this.txtDoctorNote.Name = "txtDoctorNote";
            this.txtDoctorNote.Size = new System.Drawing.Size(586, 150);
            this.txtDoctorNote.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.BtnAddNote);
            this.groupBox1.Controls.Add(this.txtDoctorNote);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.PID);
            this.groupBox1.Controls.Add(this.Date);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 197);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctor\'s Note";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(629, 149);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 27);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "Update File";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(625, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "Date:";
            // 
            // BtnAddNote
            // 
            this.BtnAddNote.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddNote.Location = new System.Drawing.Point(629, 116);
            this.BtnAddNote.Name = "BtnAddNote";
            this.BtnAddNote.Size = new System.Drawing.Size(100, 27);
            this.BtnAddNote.TabIndex = 28;
            this.BtnAddNote.Text = "Submit File";
            this.BtnAddNote.UseVisualStyleBackColor = true;
            this.BtnAddNote.Click += new System.EventHandler(this.BtnAddNote_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(625, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "Patient ID:";
            // 
            // PID
            // 
            this.PID.Enabled = false;
            this.PID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PID.Location = new System.Drawing.Point(628, 33);
            this.PID.Name = "PID";
            this.PID.Size = new System.Drawing.Size(100, 20);
            this.PID.TabIndex = 26;
            // 
            // Date
            // 
            this.Date.Enabled = false;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(628, 77);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(101, 20);
            this.Date.TabIndex = 27;
            // 
            // MediCare__Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1024, 529);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.docNumBox);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.scheduleIt_Button);
            this.Controls.Add(this.patIDComboBox);
            this.Controls.Add(this.endComboBox);
            this.Controls.Add(this.startComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lnameBox);
            this.Controls.Add(this.fnameBox);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.prev_button);
            this.Controls.Add(this.displayDateLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "MediCare__Schedule";
            this.ShowIcon = false;
            this.Text = "MediCare__Schedule";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MediCare__Schedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label displayDateLabel;
        private System.Windows.Forms.Button prev_button;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.TextBox fnameBox;
        private System.Windows.Forms.TextBox lnameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox startComboBox;
        private System.Windows.Forms.ComboBox endComboBox;
        private System.Windows.Forms.ComboBox patIDComboBox;
        private System.Windows.Forms.Button scheduleIt_Button;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox docNumBox;
        private System.Windows.Forms.Label txtDay;
        private System.Windows.Forms.TextBox txtDoctorNote;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnAddNote;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.TextBox PID;
        private System.Windows.Forms.Button btnUpdate;


    }
}