namespace AdministratorClient
{
    partial class Form1
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
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.idPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientID_tb = new System.Windows.Forms.TextBox();
            this.pnc_tb = new System.Windows.Forms.TextBox();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.address_tb = new System.Windows.Forms.TextBox();
            this.birthDate_tb = new System.Windows.Forms.DateTimePicker();
            this.add_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.viewPatients_btn = new System.Windows.Forms.Button();
            this.viewS_btn = new System.Windows.Forms.Button();
            this.dataGridViewSchedules = new System.Windows.Forms.DataGridView();
            this.idPatientS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.idPatientS_tb = new System.Windows.Forms.TextBox();
            this.idDoctorS_tb = new System.Windows.Forms.TextBox();
            this.scheduleDateS_tb = new System.Windows.Forms.DateTimePicker();
            this.scheduleDateNew_tb = new System.Windows.Forms.DateTimePicker();
            this.scheduleDesc_tb = new System.Windows.Forms.TextBox();
            this.scheduleCheck_tb = new System.Windows.Forms.TextBox();
            this.addSchedule_btn = new System.Windows.Forms.Button();
            this.updateSchedule_btn = new System.Windows.Forms.Button();
            this.deleteSchedule_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPatients
            // 


            this.dataGridViewPatients.AllowUserToAddRows = false;
            this.dataGridViewPatients.AllowUserToDeleteRows = false;
            this.dataGridViewPatients.AllowUserToResizeColumns = false;
            this.dataGridViewPatients.AllowUserToResizeRows = false;
            this.dataGridViewPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPatient,
            this.cnp,
            this.name,
            this.birthDate,
            this.address});
            this.dataGridViewPatients.Location = new System.Drawing.Point(28, 22);
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.Size = new System.Drawing.Size(375, 168);
            this.dataGridViewPatients.TabIndex = 0;
            this.dataGridViewPatients.SelectionChanged += new System.EventHandler(this.dataGridViewPatients_SelectionChanged);

            this.idPatient.DataPropertyName = "idPatient";
            this.idPatient.HeaderText = "idPatient";
            this.idPatient.Name = "idPatient";
            this.idPatient.ReadOnly = true;

            this.name.DataPropertyName = "name";
            this.name.HeaderText = "name";
            this.name.Name = "name";
            this.name.ReadOnly = true;

            this.cnp.DataPropertyName = "cnp";
            this.cnp.HeaderText = "cnp";
            this.cnp.Name = "cnp";
            this.cnp.ReadOnly = true;

            this.birthDate.DataPropertyName = "birthDate";
            this.birthDate.HeaderText = "birthDate";
            this.birthDate.Name = "birthDate";
            this.birthDate.ReadOnly = true;

            this.address.DataPropertyName = "address";
            this.address.HeaderText = "address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // patientID_tb
            // 
            this.patientID_tb.Location = new System.Drawing.Point(493, 34);
            this.patientID_tb.Name = "patientID_tb";
            this.patientID_tb.Size = new System.Drawing.Size(100, 20);
            this.patientID_tb.TabIndex = 1;
            // 
            // pnc_tb
            // 
            this.pnc_tb.Location = new System.Drawing.Point(493, 86);
            this.pnc_tb.Name = "pnc_tb";
            this.pnc_tb.Size = new System.Drawing.Size(100, 20);
            this.pnc_tb.TabIndex = 2;
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(493, 60);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(100, 20);
            this.name_tb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Patient ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "PNC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Birthdate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Address";
            // 
            // address_tb
            // 
            this.address_tb.Location = new System.Drawing.Point(493, 150);
            this.address_tb.Name = "address_tb";
            this.address_tb.Size = new System.Drawing.Size(100, 20);
            this.address_tb.TabIndex = 9;
            // 
            // birthDate_tb
            // 
            this.birthDate_tb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDate_tb.Location = new System.Drawing.Point(493, 120);
            this.birthDate_tb.Name = "birthDate_tb";
            this.birthDate_tb.Size = new System.Drawing.Size(100, 20);
            this.birthDate_tb.TabIndex = 10;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(651, 50);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(87, 23);
            this.add_btn.TabIndex = 11;
            this.add_btn.Text = "Add patient";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.addPatient_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(651, 83);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(87, 23);
            this.update_btn.TabIndex = 12;
            this.update_btn.Text = "Update patient";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.updatePatient_Click);
            //
            // view patients
            //
            this.viewPatients_btn.Location = new System.Drawing.Point(651, 116);
            this.viewPatients_btn.Name = "viewPatients_btn";
            this.viewPatients_btn.Size = new System.Drawing.Size(87, 23);
            this.viewPatients_btn.TabIndex = 12;
            this.viewPatients_btn.Text = "View patients";
            this.viewPatients_btn.UseVisualStyleBackColor = true;
            this.viewPatients_btn.Click += new System.EventHandler(this.view_btnClick);

            // 
            // dataGridViewSchedules
            // 
            this.dataGridViewSchedules.AllowUserToAddRows = false;
            this.dataGridViewSchedules.AllowUserToDeleteRows = false;
            this.dataGridViewSchedules.AllowUserToResizeColumns = false;
            this.dataGridViewSchedules.AllowUserToResizeRows = false;
            this.dataGridViewSchedules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSchedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPatientS,
            this.idDoctor,
            this.scheduleDate,
            this.description});
            this.dataGridViewSchedules.Location = new System.Drawing.Point(28, 276);
            this.dataGridViewSchedules.Name = "dataGridViewSchedules";
            this.dataGridViewSchedules.Size = new System.Drawing.Size(361, 186);
            this.dataGridViewSchedules.TabIndex = 0;
            this.dataGridViewSchedules.SelectionChanged += new System.EventHandler(this.dataGridViewSchedules_SelectionChanged);

            this.idPatientS.DataPropertyName = "idPatient";
            this.idPatientS.HeaderText = "idPatient";
            this.idPatientS.Name = "idPatient";
            this.idPatientS.ReadOnly = true;

            this.idDoctor.DataPropertyName = "idDoctor";
            this.idDoctor.HeaderText = "idDoctor";
            this.idDoctor.Name = "idDoctor";
            this.idDoctor.ReadOnly = true;

            this.scheduleDate.DataPropertyName = "scheduleDate";
            this.scheduleDate.HeaderText = "scheduleDate";
            this.scheduleDate.Name = "scheduleDate";
            this.scheduleDate.ReadOnly = true;

            this.description.DataPropertyName = "description";
            this.description.HeaderText = "description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Patient ID";
            // 
            // label7
            //  
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(428, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Doctor ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(424, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Schedule date";

            //
            //label 10
            //
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(424, 370);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Description";

            //
            //label 10
            //
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(424, 405);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Checkin";
            // 
            // idPatientS_tb
            // 
            this.idPatientS_tb.Location = new System.Drawing.Point(502, 276);
            this.idPatientS_tb.Name = "idPatientS_tb";
            this.idPatientS_tb.Size = new System.Drawing.Size(100, 20);
            this.idPatientS_tb.TabIndex = 17;
            // 
            // idDoctorS_tb
            // 
            this.idDoctorS_tb.Location = new System.Drawing.Point(502, 302);
            this.idDoctorS_tb.Name = "idDoctorS_tb";
            this.idDoctorS_tb.Size = new System.Drawing.Size(100, 20);
            this.idDoctorS_tb.TabIndex = 18;
            // 
            // scheduleDateS_tb
            // 
            this.scheduleDateS_tb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.scheduleDateS_tb.Location = new System.Drawing.Point(502, 331);
            this.scheduleDateS_tb.Name = "scheduleDateS_tb";
            this.scheduleDateS_tb.Size = new System.Drawing.Size(100, 20);
            this.scheduleDateS_tb.TabIndex = 19;


            this.scheduleDesc_tb.Location = new System.Drawing.Point(502, 371);
            this.scheduleDesc_tb.Name = "scheduleDesc_tb";
            this.scheduleDesc_tb.Size = new System.Drawing.Size(100, 20);
            this.scheduleDesc_tb.TabIndex = 19;

            this.scheduleCheck_tb.Location = new System.Drawing.Point(502, 411);
            this.scheduleCheck_tb.Name = "scheduleCheck_tb";
            this.scheduleCheck_tb.Size = new System.Drawing.Size(100, 20);
            this.scheduleCheck_tb.TabIndex = 19;

            // 
            // addSchedule_btn
            // 
            this.addSchedule_btn.Location = new System.Drawing.Point(651, 276);
            this.addSchedule_btn.Name = "addSchedule_btn";
            this.addSchedule_btn.Size = new System.Drawing.Size(105, 23);
            this.addSchedule_btn.TabIndex = 20;
            this.addSchedule_btn.Text = "Add schedule";
            this.addSchedule_btn.UseVisualStyleBackColor = true;
            this.addSchedule_btn.Click += new System.EventHandler(this.addSchedule_Click);
            // 
            // updateSchedule_btn
            // 
            this.updateSchedule_btn.Location = new System.Drawing.Point(651, 305);
            this.updateSchedule_btn.Name = "updateSchedule_btn";
            this.updateSchedule_btn.Size = new System.Drawing.Size(105, 23);
            this.updateSchedule_btn.TabIndex = 21;
            this.updateSchedule_btn.Text = "Update schedule";
            this.updateSchedule_btn.UseVisualStyleBackColor = true;
            this.updateSchedule_btn.Click += new System.EventHandler(this.updateSchedule_Click);

            this.viewS_btn.Location = new System.Drawing.Point(651, 365);
            this.viewS_btn.Name = "ViewSchedule_btn";
            this.viewS_btn.Size = new System.Drawing.Size(105, 23);
            this.viewS_btn.TabIndex = 21;
            this.viewS_btn.Text = "View schedules";
            this.viewS_btn.UseVisualStyleBackColor = true;
            this.viewS_btn.Click += new System.EventHandler(this.viewS_btnClick);
            // 
            // deleteSchedule_btn
            // 
            this.deleteSchedule_btn.Location = new System.Drawing.Point(651, 334);
            this.deleteSchedule_btn.Name = "deleteSchedule_btn";
            this.deleteSchedule_btn.Size = new System.Drawing.Size(105, 23);
            this.deleteSchedule_btn.TabIndex = 22;
            this.deleteSchedule_btn.Text = "Delete schedule";
            this.deleteSchedule_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 489);
            this.Controls.Add(this.deleteSchedule_btn);
            this.Controls.Add(this.updateSchedule_btn);
            this.Controls.Add(this.addSchedule_btn);
            this.Controls.Add(this.scheduleDateS_tb);
            this.Controls.Add(this.scheduleDateNew_tb);
            this.Controls.Add(this.idDoctorS_tb);
            this.Controls.Add(this.idPatientS_tb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewPatients);

            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.viewPatients_btn);
            this.Controls.Add(this.birthDate_tb);
            this.Controls.Add(this.address_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.pnc_tb);
            this.Controls.Add(this.patientID_tb);
            this.Controls.Add(this.dataGridViewSchedules);
            this.Controls.Add(this.viewS_btn);
            this.Controls.Add(this.scheduleDesc_tb);
            this.Controls.Add(this.scheduleCheck_tb);
            this.Controls.Add(this.idPatientS_tb);
            this.Controls.Add(this.idDoctorS_tb);
            this.Controls.Add(this.scheduleDateS_tb);
            this.Controls.Add(this.addSchedule_btn);
            this.Controls.Add(this.updateSchedule_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnp;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.TextBox patientID_tb;
        private System.Windows.Forms.TextBox pnc_tb;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        
        private System.Windows.Forms.TextBox address_tb;
        private System.Windows.Forms.DateTimePicker birthDate_tb;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button viewPatients_btn;
        private System.Windows.Forms.Button viewS_btn;
        private System.Windows.Forms.DataGridView dataGridViewSchedules;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPatientS;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn check;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox idPatientS_tb;
        private System.Windows.Forms.TextBox idDoctorS_tb;
        private System.Windows.Forms.DateTimePicker scheduleDateS_tb;
        private System.Windows.Forms.DateTimePicker scheduleDateNew_tb;
        private System.Windows.Forms.TextBox scheduleDesc_tb;
        private System.Windows.Forms.TextBox scheduleCheck_tb;
        private System.Windows.Forms.Button addSchedule_btn;
        private System.Windows.Forms.Button updateSchedule_btn;
        private System.Windows.Forms.Button deleteSchedule_btn;
    }
}

