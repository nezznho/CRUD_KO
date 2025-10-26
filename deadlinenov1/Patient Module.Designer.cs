namespace deadlinenov1
{
    partial class Patient_Module
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
            btnAdd = new Button();
            btnUpdate = new Button();
            btndelete = new Button();
            btnExit = new Button();
            txtName = new TextBox();
            txtAge = new TextBox();
            txtContact = new TextBox();
            txtAddress = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightSteelBlue;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Arial Black", 14F, FontStyle.Bold);
            btnAdd.Location = new Point(935, 292);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(131, 57);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightSteelBlue;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Font = new Font("Arial Black", 14F, FontStyle.Bold);
            btnUpdate.Location = new Point(1125, 292);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(145, 57);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.LightSteelBlue;
            btndelete.Cursor = Cursors.Hand;
            btndelete.Font = new Font("Arial Black", 14F, FontStyle.Bold);
            btndelete.Location = new Point(935, 394);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(131, 57);
            btndelete.TabIndex = 2;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightSteelBlue;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Font = new Font("Arial Black", 14F, FontStyle.Bold);
            btnExit.Location = new Point(1125, 394);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(145, 57);
            btnExit.TabIndex = 3;
            btnExit.Text = "Return";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.Location = new Point(135, 118);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(212, 41);
            txtName.TabIndex = 4;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(135, 199);
            txtAge.Multiline = true;
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(212, 41);
            txtAge.TabIndex = 5;
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtContact.Location = new Point(806, 118);
            txtContact.Multiline = true;
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(212, 41);
            txtContact.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(806, 199);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(212, 41);
            txtAddress.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(82, 278);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(804, 324);
            dataGridView1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(135, 86);
            label1.Name = "label1";
            label1.Size = new Size(84, 29);
            label1.TabIndex = 9;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(137, 167);
            label2.Name = "label2";
            label2.Size = new Size(65, 29);
            label2.TabIndex = 10;
            label2.Text = "Age:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSteelBlue;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(808, 86);
            label3.Name = "label3";
            label3.Size = new Size(109, 29);
            label3.TabIndex = 11;
            label3.Text = "Contact:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightSteelBlue;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(806, 167);
            label4.Name = "label4";
            label4.Size = new Size(115, 29);
            label4.TabIndex = 12;
            label4.Text = "Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Lavender;
            label5.Font = new Font("Arial Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(484, 10);
            label5.Name = "label5";
            label5.Size = new Size(450, 56);
            label5.TabIndex = 13;
            label5.Text = "Patient Information";
            // 
            // Patient_Module
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.hehhe;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1328, 627);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(txtAddress);
            Controls.Add(txtContact);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(btnExit);
            Controls.Add(btndelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Name = "Patient_Module";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patient_Module";
            Load += Patient_Module_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnUpdate;
        private Button btndelete;
        private Button btnExit;
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtContact;
        private TextBox txtAddress;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}