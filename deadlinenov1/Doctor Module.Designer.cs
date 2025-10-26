namespace deadlinenov1
{
    partial class Doctor_Module
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
            btnret = new Button();
            btndel = new Button();
            btnupd = new Button();
            btnAddd = new Button();
            txtAddressD = new TextBox();
            txtContactD = new TextBox();
            txtNamed = new TextBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnret
            // 
            btnret.BackColor = Color.LightSteelBlue;
            btnret.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnret.Location = new Point(1105, 490);
            btnret.Name = "btnret";
            btnret.Size = new Size(131, 57);
            btnret.TabIndex = 7;
            btnret.Text = "Return";
            btnret.UseVisualStyleBackColor = false;
            btnret.Click += btnret_Click;
            // 
            // btndel
            // 
            btndel.BackColor = Color.LightSteelBlue;
            btndel.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndel.Location = new Point(938, 490);
            btndel.Name = "btndel";
            btndel.Size = new Size(131, 57);
            btndel.TabIndex = 6;
            btndel.Text = "Delete";
            btndel.UseVisualStyleBackColor = false;
            btndel.Click += btndel_Click;
            // 
            // btnupd
            // 
            btnupd.BackColor = Color.LightSteelBlue;
            btnupd.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupd.Location = new Point(1105, 330);
            btnupd.Name = "btnupd";
            btnupd.Size = new Size(131, 57);
            btnupd.TabIndex = 5;
            btnupd.Text = "Update";
            btnupd.UseVisualStyleBackColor = false;
            btnupd.Click += btnupd_Click;
            // 
            // btnAddd
            // 
            btnAddd.BackColor = Color.LightSteelBlue;
            btnAddd.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddd.Location = new Point(938, 330);
            btnAddd.Name = "btnAddd";
            btnAddd.Size = new Size(131, 57);
            btnAddd.TabIndex = 4;
            btnAddd.Text = "Add";
            btnAddd.UseVisualStyleBackColor = false;
            btnAddd.Click += btnAddd_Click;
            // 
            // txtAddressD
            // 
            txtAddressD.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAddressD.Location = new Point(904, 158);
            txtAddressD.Multiline = true;
            txtAddressD.Name = "txtAddressD";
            txtAddressD.Size = new Size(228, 41);
            txtAddressD.TabIndex = 10;
            // 
            // txtContactD
            // 
            txtContactD.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtContactD.Location = new Point(408, 158);
            txtContactD.Multiline = true;
            txtContactD.Name = "txtContactD";
            txtContactD.Size = new Size(212, 41);
            txtContactD.TabIndex = 9;
            // 
            // txtNamed
            // 
            txtNamed.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNamed.Location = new Point(63, 158);
            txtNamed.Multiline = true;
            txtNamed.Name = "txtNamed";
            txtNamed.Size = new Size(212, 41);
            txtNamed.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 233);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(835, 324);
            dataGridView1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LavenderBlush;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(63, 116);
            label2.Name = "label2";
            label2.Size = new Size(84, 29);
            label2.TabIndex = 12;
            label2.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lavender;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(450, 121);
            label1.Name = "label1";
            label1.Size = new Size(109, 29);
            label1.TabIndex = 13;
            label1.Text = "Contact:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSteelBlue;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(904, 126);
            label3.Name = "label3";
            label3.Size = new Size(115, 29);
            label3.TabIndex = 14;
            label3.Text = "Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Lavender;
            label5.Font = new Font("Arial Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(418, 9);
            label5.Name = "label5";
            label5.Size = new Size(441, 56);
            label5.TabIndex = 15;
            label5.Text = "Doctor Information";
            // 
            // Doctor_Module
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.hehhe;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1328, 589);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(txtAddressD);
            Controls.Add(txtContactD);
            Controls.Add(txtNamed);
            Controls.Add(btnret);
            Controls.Add(btndel);
            Controls.Add(btnupd);
            Controls.Add(btnAddd);
            Name = "Doctor_Module";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doctor_Module";
            Load += Doctor_Module_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnret;
        private Button btndel;
        private Button btnupd;
        private Button btnAddd;
        private TextBox txtAddressD;
        private TextBox txtContactD;
        private TextBox txtNamed;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label5;
    }
}