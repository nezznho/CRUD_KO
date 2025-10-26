namespace deadlinenov1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnlogin = new Button();
            txtemail = new TextBox();
            txtpassword = new TextBox();
            lblemail = new Label();
            label1 = new Label();
            btnexit = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnlogin
            // 
            btnlogin.Font = new Font("Microsoft Sans Serif", 11F);
            btnlogin.ForeColor = Color.White;
            btnlogin.Image = Properties.Resources.gradients_app;
            btnlogin.ImageAlign = ContentAlignment.TopCenter;
            btnlogin.Location = new Point(282, 363);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(281, 74);
            btnlogin.TabIndex = 0;
            btnlogin.Text = "Log-in";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // txtemail
            // 
            txtemail.Font = new Font("Microsoft Sans Serif", 16F);
            txtemail.ForeColor = Color.White;
            txtemail.Location = new Point(282, 198);
            txtemail.Multiline = true;
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(281, 46);
            txtemail.TabIndex = 1;
            txtemail.TextAlign = HorizontalAlignment.Center;
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Microsoft Sans Serif", 16F);
            txtpassword.ForeColor = Color.White;
            txtpassword.Location = new Point(282, 298);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(281, 46);
            txtpassword.TabIndex = 2;
            txtpassword.TextAlign = HorizontalAlignment.Center;
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.BackColor = Color.Transparent;
            lblemail.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblemail.ForeColor = Color.White;
            lblemail.Location = new Point(282, 160);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(86, 32);
            lblemail.TabIndex = 3;
            lblemail.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(282, 260);
            label1.Name = "label1";
            label1.Size = new Size(138, 32);
            label1.TabIndex = 4;
            label1.Text = "Password";
            // 
            // btnexit
            // 
            btnexit.Font = new Font("Microsoft Sans Serif", 11F);
            btnexit.ForeColor = Color.White;
            btnexit.Image = Properties.Resources.gradients_app1;
            btnexit.ImageAlign = ContentAlignment.TopCenter;
            btnexit.Location = new Point(282, 452);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(281, 57);
            btnexit.TabIndex = 5;
            btnexit.Text = "exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveBorder;
            label2.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Image = Properties.Resources.likod;
            label2.Location = new Point(282, 96);
            label2.Name = "label2";
            label2.Size = new Size(213, 51);
            label2.TabIndex = 7;
            label2.Text = "Welcome!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(855, 607);
            Controls.Add(label2);
            Controls.Add(btnexit);
            Controls.Add(label1);
            Controls.Add(lblemail);
            Controls.Add(txtpassword);
            Controls.Add(txtemail);
            Controls.Add(btnlogin);
            HelpButton = true;
            Name = "Form1";
            StartPosition = FormStartPosition.Manual;
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnlogin;
        private TextBox txtemail;
        private TextBox txtpassword;
        private Label lblemail;
        private Label label1;
        private Button btnexit;
        private Label label2;
    }
}
