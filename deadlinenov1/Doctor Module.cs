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
    public partial class Doctor_Module : Form
    {
        public Doctor_Module()
        {
            InitializeComponent();
            LoadDoctors();
            using var conn = new MySqlConnection(Form1.Config.ConnectionString);
            conn.Open();
        }
        private void LoadDoctors()
        {
            try
            {
                using var conn = new MySqlConnection(Form1.Config.ConnectionString);
                conn.Open();
                using var cmd = new MySqlCommand("SELECT id, name, contact, specialty AS address FROM doctors ORDER BY id", conn);
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


        private void btnAddd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamed.Text))
            {
                MessageBox.Show("Enter doctor's name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using var conn = new MySqlConnection(Form1.Config.ConnectionString);
                conn.Open();
                using var cmd = new MySqlCommand(
                    "INSERT INTO doctors (name, specialty, contact) VALUES (@name, @specialty, @contact)",
                    conn);
                cmd.Parameters.AddWithValue("@name", txtNamed.Text.Trim());
                cmd.Parameters.AddWithValue("@specialty", txtAddressD.Text.Trim());
                cmd.Parameters.AddWithValue("@contact", txtContactD.Text.Trim());
                cmd.ExecuteNonQuery();

                LoadDoctors();
                MessageBox.Show("Doctor added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnupd_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId();
            if (id == null)
            {
                MessageBox.Show("Select a doctor to update.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNamed.Text))
            {
                MessageBox.Show("Enter doctor's name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using var conn = new MySqlConnection(Form1.Config.ConnectionString);
                conn.Open();
                using var cmd = new MySqlCommand(
                    "UPDATE doctors SET name=@name, specialty=@specialty, contact=@contact WHERE id=@id",
                    conn);
                cmd.Parameters.AddWithValue("@name", txtNamed.Text.Trim());
                cmd.Parameters.AddWithValue("@specialty", txtAddressD.Text.Trim());
                cmd.Parameters.AddWithValue("@contact", txtContactD.Text.Trim());
                cmd.Parameters.AddWithValue("@id", id.Value);
                var rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    LoadDoctors();
                    MessageBox.Show("Doctor updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btndel_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId();
            if (id == null)
            {
                MessageBox.Show("Select a doctor to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var confirm = MessageBox.Show("Delete selected doctor?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;
            try
            {
                using var conn = new MySqlConnection(Form1.Config.ConnectionString);
                conn.Open();
                using var cmd = new MySqlCommand("DELETE FROM doctors WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id.Value);
                var rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    LoadDoctors();
                    MessageBox.Show("Doctor deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnret_Click(object sender, EventArgs e)
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
            txtNamed.Text = row.Cells["name"].Value?.ToString() ?? "";
            txtContactD.Text = row.Cells["contact"].Value?.ToString() ?? "";

            txtAddressD.Text = row.Cells["address"].Value?.ToString() ?? "";
        }
        private void ClearInputs()
        {
            txtNamed.Text = "";
            txtContactD.Text = "";
            txtAddressD.Text = "";
            dataGridView1.ClearSelection();
        }

        private void Doctor_Module_Load(object sender, EventArgs e)
        {

        }
    }
}
