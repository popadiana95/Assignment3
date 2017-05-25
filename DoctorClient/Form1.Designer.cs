namespace DoctorClient
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
            this.dataGridViewHistory = new System.Windows.Forms.DataGridView();
            this.idPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPatient_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.view_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHistory
            // 
            this.dataGridViewHistory.AllowUserToAddRows = false;
            this.dataGridViewHistory.AllowUserToDeleteRows = false;
            this.dataGridViewHistory.AllowUserToResizeColumns = false;
            this.dataGridViewHistory.AllowUserToResizeRows = false;
            this.dataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPatient,
            this.idDoctor,
            this.scheduleDate,
            this.description});
            this.dataGridViewHistory.Location = new System.Drawing.Point(12, 35);
            this.dataGridViewHistory.MultiSelect = false;
            this.dataGridViewHistory.Name = "dataGridViewHistory";
            this.dataGridViewHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHistory.Size = new System.Drawing.Size(445, 254);
            this.dataGridViewHistory.TabIndex = 0;
            //             
                    // idPatient
            // 
            this.idPatient.DataPropertyName = "idPatient";
            this.idPatient.HeaderText = "idPatient";
            this.idPatient.Name = "idPatient";
            this.idPatient.ReadOnly = true;
            // 
            // idDoctor
            // 
            this.idDoctor.DataPropertyName = "idDoctor";
            this.idDoctor.HeaderText = "idDoctor";
            this.idDoctor.Name = "idDoctor";
            this.idDoctor.ReadOnly = true;
            // 
            // scheduleDate
            // 
            this.scheduleDate.DataPropertyName = "scheduleDate";
            this.scheduleDate.HeaderText = "scheduleDate";
            this.scheduleDate.Name = "scheduleDate";
            this.scheduleDate.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // idPatient_tb
            // 
            this.idPatient_tb.Location = new System.Drawing.Point(567, 105);
            this.idPatient_tb.Name = "idPatient_tb";
            this.idPatient_tb.Size = new System.Drawing.Size(100, 20);
            this.idPatient_tb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Patient ID";
            // 
            // view_btn
            // 
            this.view_btn.Location = new System.Drawing.Point(564, 178);
            this.view_btn.Name = "view_btn";
            this.view_btn.Size = new System.Drawing.Size(75, 23);
            this.view_btn.TabIndex = 3;
            this.view_btn.Text = "View";
            this.view_btn.UseVisualStyleBackColor = true;
            this.view_btn.Click += new System.EventHandler(this.view_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 445);
            this.Controls.Add(this.view_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idPatient_tb);
            this.Controls.Add(this.dataGridViewHistory);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHistory;
        private System.Windows.Forms.TextBox idPatient_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button view_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPatient;
    }
}

