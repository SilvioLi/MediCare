namespace MediCare
{
    partial class MediCare__Payment
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.activeButton = new System.Windows.Forms.Button();
            this.paidAptButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.vmcPay = new System.Windows.Forms.Button();
            this.debitPay = new System.Windows.Forms.Button();
            this.cashPay = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.thirdCost = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.spPercent = new System.Windows.Forms.TextBox();
            this.patPercent = new System.Windows.Forms.TextBox();
            this.addPaymentButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.secondCost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.percent1box = new System.Windows.Forms.TextBox();
            this.percent2box = new System.Windows.Forms.TextBox();
            this.tax2check = new System.Windows.Forms.CheckBox();
            this.tax1check = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.firstCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.docIDlabel = new System.Windows.Forms.Label();
            this.pFname = new System.Windows.Forms.Label();
            this.pLname = new System.Windows.Forms.Label();
            this.pIdLabel = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(259, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 181);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patient\'s Purchase History";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(432, 148);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.activeButton);
            this.groupBox1.Controls.Add(this.paidAptButton);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(20, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 289);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scheduled Appointments";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.Location = new System.Drawing.Point(6, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(678, 242);
            this.dataGridView1.TabIndex = 0;
            // 
            // activeButton
            // 
            this.activeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeButton.Location = new System.Drawing.Point(495, 16);
            this.activeButton.Name = "activeButton";
            this.activeButton.Size = new System.Drawing.Size(100, 30);
            this.activeButton.TabIndex = 43;
            this.activeButton.Text = "Show Active";
            this.activeButton.UseVisualStyleBackColor = true;
            this.activeButton.Click += new System.EventHandler(this.activeButton_Click);
            // 
            // paidAptButton
            // 
            this.paidAptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidAptButton.Location = new System.Drawing.Point(591, 16);
            this.paidAptButton.Name = "paidAptButton";
            this.paidAptButton.Size = new System.Drawing.Size(93, 30);
            this.paidAptButton.TabIndex = 42;
            this.paidAptButton.Text = "Show Paid";
            this.paidAptButton.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(6, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(290, 16);
            this.label16.TabIndex = 41;
            this.label16.Text = "Click on appointment to begin payment process";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(804, 337);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 13);
            this.label15.TabIndex = 74;
            this.label15.Text = "Billed to Service Provider:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(846, 363);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 73;
            this.label14.Text = "Billed to Patient: ";
            // 
            // vmcPay
            // 
            this.vmcPay.Location = new System.Drawing.Point(826, 464);
            this.vmcPay.Name = "vmcPay";
            this.vmcPay.Size = new System.Drawing.Size(72, 23);
            this.vmcPay.TabIndex = 72;
            this.vmcPay.Text = "VISA/MC";
            this.vmcPay.UseVisualStyleBackColor = true;
            // 
            // debitPay
            // 
            this.debitPay.Location = new System.Drawing.Point(919, 464);
            this.debitPay.Name = "debitPay";
            this.debitPay.Size = new System.Drawing.Size(59, 23);
            this.debitPay.TabIndex = 71;
            this.debitPay.Text = "Debit";
            this.debitPay.UseVisualStyleBackColor = true;
            // 
            // cashPay
            // 
            this.cashPay.Location = new System.Drawing.Point(740, 464);
            this.cashPay.Name = "cashPay";
            this.cashPay.Size = new System.Drawing.Size(65, 23);
            this.cashPay.TabIndex = 70;
            this.cashPay.Text = "Cash";
            this.cashPay.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(881, 408);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 18);
            this.label13.TabIndex = 69;
            this.label13.Text = "$";
            // 
            // thirdCost
            // 
            this.thirdCost.Enabled = false;
            this.thirdCost.Location = new System.Drawing.Point(903, 410);
            this.thirdCost.Name = "thirdCost";
            this.thirdCost.Size = new System.Drawing.Size(74, 20);
            this.thirdCost.TabIndex = 68;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(721, 413);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 13);
            this.label12.TabIndex = 67;
            this.label12.Text = "Patient Pays.....................";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(983, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 18);
            this.label10.TabIndex = 66;
            this.label10.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(983, 360);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 18);
            this.label11.TabIndex = 65;
            this.label11.Text = "%";
            // 
            // spPercent
            // 
            this.spPercent.Location = new System.Drawing.Point(935, 337);
            this.spPercent.Name = "spPercent";
            this.spPercent.Size = new System.Drawing.Size(42, 20);
            this.spPercent.TabIndex = 64;
            this.spPercent.Text = "50";
            this.spPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // patPercent
            // 
            this.patPercent.Location = new System.Drawing.Point(935, 363);
            this.patPercent.Name = "patPercent";
            this.patPercent.Size = new System.Drawing.Size(42, 20);
            this.patPercent.TabIndex = 63;
            this.patPercent.Text = "50";
            this.patPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // addPaymentButton
            // 
            this.addPaymentButton.Location = new System.Drawing.Point(884, 292);
            this.addPaymentButton.Name = "addPaymentButton";
            this.addPaymentButton.Size = new System.Drawing.Size(94, 23);
            this.addPaymentButton.TabIndex = 62;
            this.addPaymentButton.Text = "Add Payment";
            this.addPaymentButton.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(881, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 18);
            this.label9.TabIndex = 61;
            this.label9.Text = "$";
            // 
            // secondCost
            // 
            this.secondCost.Enabled = false;
            this.secondCost.Location = new System.Drawing.Point(903, 254);
            this.secondCost.Name = "secondCost";
            this.secondCost.Size = new System.Drawing.Size(74, 20);
            this.secondCost.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(721, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Total.............................";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(983, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 18);
            this.label7.TabIndex = 58;
            this.label7.Text = "%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(983, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 18);
            this.label6.TabIndex = 57;
            this.label6.Text = "%";
            // 
            // percent1box
            // 
            this.percent1box.Location = new System.Drawing.Point(935, 190);
            this.percent1box.Name = "percent1box";
            this.percent1box.Size = new System.Drawing.Size(42, 20);
            this.percent1box.TabIndex = 56;
            this.percent1box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // percent2box
            // 
            this.percent2box.Location = new System.Drawing.Point(935, 213);
            this.percent2box.Name = "percent2box";
            this.percent2box.Size = new System.Drawing.Size(42, 20);
            this.percent2box.TabIndex = 55;
            this.percent2box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tax2check
            // 
            this.tax2check.AutoSize = true;
            this.tax2check.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tax2check.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tax2check.Location = new System.Drawing.Point(876, 216);
            this.tax2check.Name = "tax2check";
            this.tax2check.Size = new System.Drawing.Size(56, 17);
            this.tax2check.TabIndex = 54;
            this.tax2check.Text = "Tax 2:";
            this.tax2check.UseVisualStyleBackColor = true;
            // 
            // tax1check
            // 
            this.tax1check.AutoSize = true;
            this.tax1check.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tax1check.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tax1check.Location = new System.Drawing.Point(876, 193);
            this.tax1check.Name = "tax1check";
            this.tax1check.Size = new System.Drawing.Size(56, 17);
            this.tax1check.TabIndex = 53;
            this.tax1check.Text = "Tax 1:";
            this.tax1check.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(881, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 18);
            this.label5.TabIndex = 52;
            this.label5.Text = "$";
            // 
            // firstCost
            // 
            this.firstCost.AcceptsReturn = true;
            this.firstCost.Location = new System.Drawing.Point(903, 167);
            this.firstCost.Name = "firstCost";
            this.firstCost.Size = new System.Drawing.Size(74, 20);
            this.firstCost.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(721, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Appointment Cost.........";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(915, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Doctor ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(726, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Patient #:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(724, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 30);
            this.label1.TabIndex = 47;
            this.label1.Text = "Medi-Care Billing Process";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.date.Location = new System.Drawing.Point(949, 98);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(0, 13);
            this.date.TabIndex = 46;
            // 
            // docIDlabel
            // 
            this.docIDlabel.AutoSize = true;
            this.docIDlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.docIDlabel.Location = new System.Drawing.Point(977, 133);
            this.docIDlabel.Name = "docIDlabel";
            this.docIDlabel.Size = new System.Drawing.Size(0, 13);
            this.docIDlabel.TabIndex = 45;
            // 
            // pFname
            // 
            this.pFname.AutoSize = true;
            this.pFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pFname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pFname.Location = new System.Drawing.Point(726, 133);
            this.pFname.Name = "pFname";
            this.pFname.Size = new System.Drawing.Size(0, 16);
            this.pFname.TabIndex = 44;
            // 
            // pLname
            // 
            this.pLname.AutoSize = true;
            this.pLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pLname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pLname.Location = new System.Drawing.Point(726, 120);
            this.pLname.Name = "pLname";
            this.pLname.Size = new System.Drawing.Size(0, 16);
            this.pLname.TabIndex = 43;
            // 
            // pIdLabel
            // 
            this.pIdLabel.AutoSize = true;
            this.pIdLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pIdLabel.Location = new System.Drawing.Point(785, 98);
            this.pIdLabel.Name = "pIdLabel";
            this.pIdLabel.Size = new System.Drawing.Size(0, 13);
            this.pIdLabel.TabIndex = 42;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(20, 34);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 41;
            // 
            // MediCare__Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1024, 529);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.vmcPay);
            this.Controls.Add(this.debitPay);
            this.Controls.Add(this.cashPay);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.thirdCost);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.spPercent);
            this.Controls.Add(this.patPercent);
            this.Controls.Add(this.addPaymentButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.secondCost);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.percent1box);
            this.Controls.Add(this.percent2box);
            this.Controls.Add(this.tax2check);
            this.Controls.Add(this.tax1check);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.firstCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.docIDlabel);
            this.Controls.Add(this.pFname);
            this.Controls.Add(this.pLname);
            this.Controls.Add(this.pIdLabel);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "MediCare__Payment";
            this.Text = "MediCare__Payment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button activeButton;
        private System.Windows.Forms.Button paidAptButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button vmcPay;
        private System.Windows.Forms.Button debitPay;
        private System.Windows.Forms.Button cashPay;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox thirdCost;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox spPercent;
        private System.Windows.Forms.TextBox patPercent;
        private System.Windows.Forms.Button addPaymentButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox secondCost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox percent1box;
        private System.Windows.Forms.TextBox percent2box;
        private System.Windows.Forms.CheckBox tax2check;
        private System.Windows.Forms.CheckBox tax1check;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox firstCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label docIDlabel;
        private System.Windows.Forms.Label pFname;
        private System.Windows.Forms.Label pLname;
        private System.Windows.Forms.Label pIdLabel;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}