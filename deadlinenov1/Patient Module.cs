using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deadlinenov1
{
    public partial class Patient_Module : Form
    {
        public Patient_Module()
        {
            InitializeComponent();
            LoadPatients();
            using var conn = new MySqlConnection(Form1.Config.ConnectionString);
            conn.Open();
        }

        private void LoadPatients()
        {
            try
            {
                using var conn = new MySqlConnection(Form1.Config.ConnectionString);
                conn.Open();
                using var cmd = new MySqlCommand("SELECT id, name, age, contact, address FROM patients ORDER BY id", conn);
                using var adapter = new MySqlDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                ClearInputs();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Load failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Patient_Module_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || !int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Enter valid Name and Age.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var conn = new MySqlConnection(Form1.Config.ConnectionString);
                conn.Open();
                using var cmd = new MySqlCommand(
                    "INSERT INTO patients (name, age, contact, address) VALUES (@name, @age, @contact, @address)",
                    conn);
                cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@contact", txtContact.Text.Trim());
                cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                cmd.ExecuteNonQuery();
                LoadPatients();
                MessageBox.Show("Patient added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId();
            if (id == null)
            {
                MessageBox.Show("Select a patient to update.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text) || !int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Enter valid Name and Age.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using var conn = new MySqlConnection(Form1.Config.ConnectionString);
                conn.Open();
                using var cmd = new MySqlCommand(
                    "UPDATE patients SET name=@name, age=@age, contact=@contact, address=@address WHERE id=@id",
                    conn);
                cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@contact", txtContact.Text.Trim());
                cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@id", id.Value);
                var rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    LoadPatients();
                    MessageBox.Show("Patient updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update failed (no rows affected).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        


        

        private void btndelete_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId();
            if (id == null)
            {
                MessageBox.Show("Select a patient to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show("Delete selected patient?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using var conn = new MySqlConnection(Form1.Config.ConnectionString);
                conn.Open();
                using var cmd = new MySqlCommand("DELETE FROM patients WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id.Value);
                var rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    LoadPatients();
                    MessageBox.Show("Patient deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Delete failed (no rows affected).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var dash = new dashboard();
            dash.Show();
            this.Close();
        }
        private int? GetSelectedId()
        {
            if (dataGridView1.CurrentRow == null) return null;
            var cell = dataGridView1.CurrentRow.Cells["id"];
            if (cell?.Value == null) return null;
            return Convert.ToInt32(cell.Value);
        }
        private void Grid_SelectionChanged(object? sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                ClearInputs();
                return;
            }
            var row = dataGridView1.CurrentRow;
            txtName.Text = row.Cells["name"].Value?.ToString() ?? "";
            txtAge.Text = row.Cells["age"].Value?.ToString() ?? "";
            txtContact.Text = row.Cells["contact"].Value?.ToString() ?? "";
            txtAddress.Text = row.Cells["address"].Value?.ToString() ?? "";
        }
        private void ClearInputs()
        {
            txtName.Text = "";
            txtAge.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            dataGridView1.ClearSelection();
        }
    }
}