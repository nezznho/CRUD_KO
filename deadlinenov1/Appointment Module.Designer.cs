namespace deadlinenov1
{
    partial class Appointment_Module
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
            btnreturn = new Button();
            btndelete = new Button();
            btnupdate = new Button();
            btnadd = new Button();
            txtReason = new TextBox();
            txtDoctor = new TextBox();
            txtPatient = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnreturn
            // 
            btnreturn.BackColor = Color.LightSteelBlue;
            btnreturn.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnreturn.Location = new Point(1073, 552);
            btnreturn.Name = "btnreturn";
            btnreturn.Size = new Size(131, 57);
            btnreturn.TabIndex = 11;
            btnreturn.Text = "Return";
            btnreturn.UseVisualStyleBackColor = false;
            btnreturn.Click += btnreturn_Click;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.LightSteelBlue;
            btndelete.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndelete.Location = new Point(906, 552);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(131, 57);
            btndelete.TabIndex = 10;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = Color.LightSteelBlue;
            btnupdate.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupdate.Location = new Point(1073, 427);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(131, 57);
            btnupdate.TabIndex = 9;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btnupdate_Click;
            // 
            // btnadd
            // 
            btnadd.BackColor = Color.LightSteelBlue;
            btnadd.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnadd.Location = new Point(906, 427);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(131, 57);
            btnadd.TabIndex = 8;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += button1_Click;
            // 
            // txtReason
            // 
            txtReason.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtReason.Location = new Point(521, 238);
            txtReason.Multiline = true;
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(270, 41);
            txtReason.TabIndex = 15;
            // 
            // txtDoctor
            // 
            txtDoctor.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDoctor.Location = new Point(116, 227);
            txtDoctor.Multiline = true;
            txtDoctor.Name = "txtDoctor";
            txtDoctor.Size = new Size(212, 41);
            txtDoctor.TabIndex = 13;
            // 
            // txtPatient
            // 
            txtPatient.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPatient.Location = new Point(116, 139);
            txtPatient.Multiline = true;
            txtPatient.Name = "txtPatient";
            txtPatient.Size = new Size(212, 41);
            txtPatient.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(521, 139);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(316, 31);
            dateTimePicker1.TabIndex = 16;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 285);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(835, 324);
            dataGridView1.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LavenderBlush;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(116, 107);
            label3.Name = "label3";
            label3.Size = new Size(100, 29);
            label3.TabIndex = 18;
            label3.Text = "Patient:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LavenderBlush;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(116, 195);
            label1.Name = "label1";
            label1.Size = new Size(97, 29);
            label1.TabIndex = 19;
            label1.Text = "Doctor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Lavender;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(521, 206);
            label2.Name = "label2";
            label2.Size = new Size(106, 29);
            label2.TabIndex = 20;
            label2.Text = "Reason:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Lavender;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(521, 107);
            label4.Name = "label4";
            label4.Size = new Size(71, 29);
            label4.TabIndex = 21;
            label4.Text = "Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Lavender;
            label5.Font = new Font("Arial Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(436, 24);
            label5.Name = "label5";
            label5.Size = new Size(307, 56);
            label5.TabIndex = 22;
            label5.Text = "Appointment";
            // 
            // Appointment_Module
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.hehhe;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1328, 685);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtReason);
            Controls.Add(txtDoctor);
            Controls.Add(txtPatient);
            Controls.Add(btnreturn);
            Controls.Add(btndelete);
            Controls.Add(btnupdate);
            Controls.Add(btnadd);
            Name = "Appointment_Module";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doctor";
            Load += Appointment_Module_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnreturn;
        private Button btndelete;
        private Button btnupdate;
        private Button btnadd;
        private TextBox txtReason;
        private TextBox txtDoctor;
        private TextBox txtPatient;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
    }
}