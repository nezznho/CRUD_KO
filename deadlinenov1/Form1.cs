using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace deadlinenov1
{
    public partial class Form1 : Form
    {
        public static class Config
        {
            public static string ConnectionString { get; set; } =
                "Server=127.0.0.1;Port=3306;Database=clinic_db;Uid=root;Pwd=JOHNZENDATABASE;SslMode=None;";
        }
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = btnlogin;
        }
            
        private void btnexit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
     

        private void btnlogin_Click(object sender, EventArgs e)
        {
            var username = txtemail.Text?.Trim() ?? string.Empty;
            var password = txtpassword.Text ?? string.Empty;

            if (username == "Johnzen" || username =="johnzen" && password == "Johnzen28" || password == "johnzen28")
            {
                MessageBox.Show("Login successful. Welcome, admin.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var dash = new dashboard();
                dash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Optionally clear password field for security
                txtpassword.Clear();
                txtpassword.Focus();
            }
        }
    }
}
