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
    public partial class Appointment_Module : Form
    {
        public Appointment_Module()
        {
            InitializeComponent();
            LoadAppointments();
            using var conn = new MySqlConnection(Form1.Config.ConnectionString);
            conn.Open();
        }
        private void LoadAppointments()
        {
            try
            {
                using var conn = new MySqlConnection(Form1.Config.ConnectionString);
                conn.Open();

                using var cmd = new MySqlCommand(
                    "SELECT a.id, p.name AS patient_name, d.name AS doctor_name, a.appointment_datetime, a.reason " +
                    "FROM appointments a " +
                    "JOIN patients p ON a.patient_id = p.id " +
                    "JOIN doctors d ON a.doctor_id = d.id " +
                    "ORDER BY a.appointment_datetime", conn);

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
        private int? GetSelectedAppointmentId()
        {
            if (dataGridView1.CurrentRow == null) return null;
            var cell = dataGridView1.CurrentRow.Cells["id"];
            if (cell?.Value == null) return null;
            return Convert.ToInt32(cell.Value);
        }
        private int? GetPatientIdByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return null;
            try
            {
                using var conn = new MySqlConnection(Form1.Config.ConnectionString);
                conn.Open();
                using var cmd = new MySqlCommand("SELECT id FROM patients WHERE name = @name LIMIT 1", conn);
                cmd.Parameters.AddWithValue("@name", name.Trim());
                var result = cmd.ExecuteScalar();
                if (result == null || result == DBNull.Value) return null;
                return Convert.ToInt32(result);
            }
            catch
            {
                return null;
            }
        }
        private int? GetDoctorIdByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return null;
            try
            {
                using var conn = new MySqlConnection(Form1.Config.ConnectionString);
                conn.Open();
                using var cmd = new MySqlCommand("SELECT id FROM doctors WHERE name = @name LIMIT 1", conn);
                cmd.Parameters.AddWithValue("@name", name.Trim());
                var result = cmd.ExecuteScalar();
                if (result == null || result == DBNull.Value) return null;
                return Convert.ToInt32(result);
            }
            catch
            {
                return null;
            }
        }


        private void Appointment_Module_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var patientName = txtPatient.Text.Trim();
            var doctorName = txtDoctor.Text.Trim();
            var reason = txtReason.Text.Trim();
            var dt = dateTimePicker1.Value;

            if (string.IsNullOrWhiteSpace(patientName) || string.IsNullOrWhiteSpace(doctorName))
            {
                MessageBox.Show("Enter both patient and doctor names (exact match to records).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var patientId = GetPatientIdByName(patientName);
            if (patientId == null)
            {
                MessageBox.Show($"Patient '{patientName}' not found. Create the patient first or enter exact name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var doctorId = GetDoctorIdByName(doctorName);
            if (doctorId == null)
            {
                MessageBox.Show($"Doctor '{doctorName}' not found. Create the doctor first or enter exact name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using var conn = new MySqlConnection(Form1.Config.ConnectionString);
                conn.Open();
                using var cmd = new MySqlCommand(
                    "INSERT INTO appointments (patient_id, doctor_id, appointment_datetime, reason) " +
                    "VALUES (@pid, @did, @dt, @reason)", conn);
                cmd.Parameters.AddWithValue("@pid", patientId.Value);
                cmd.Parameters.AddWithValue("@did", doctorId.Value);
                cmd.Parameters.AddWithValue("@dt", dt);
                cmd.Parameters.AddWithValue("@reason", reason);
                cmd.ExecuteNonQuery();

                LoadAppointments();
                MessageBox.Show("Appointment added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            var apptId = GetSelectedAppointmentId();
            if (apptId == null)
            {
                MessageBox.Show("Select an appointment to update.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var patientName = txtPatient.Text.Trim();
            var doctorName = txtDoctor.Text.Trim();
            var reason = txtReason.Text.Trim();
            var dt = dateTimePicker1.Value;

            if (string.IsNullOrWhiteSpace(patientName) || string.IsNullOrWhiteSpace(doctorName))
            {
                MessageBox.Show("Enter both patient and doctor names (exact match to records).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var patientId = GetPatientIdByName(patientName);
            if (patientId == null)
            {
                MessageBox.Show($"Patient '{patientName}' not found.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var doctorId = GetDoctorIdByName(doctorName);
            if (doctorId == null)
            {
                MessageBox.Show($"Doctor '{doctorName}' not found.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using var conn = new MySqlConnection(Form1.Config.ConnectionString);
                conn.Open();
                using var cmd = new MySqlCommand(
                    "UPDATE appointments SET patient_id=@pid, doctor_id=@did, appointment_datetime=@dt, reason=@reason WHERE id=@id",
                    conn);
                cmd.Parameters.AddWithValue("@pid", patientId.Value);
                cmd.Parameters.AddWithValue("@did", doctorId.Value);
                cmd.Parameters.AddWithValue("@dt", dt);
                cmd.Parameters.AddWithValue("@reason", reason);
                cmd.Parameters.AddWithValue("@id", apptId.Value);
                var rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    LoadAppointments();
                    MessageBox.Show("Appointment updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            var apptId = GetSelectedAppointmentId();
            if (apptId == null)
            {
                MessageBox.Show("Select an appointment to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var confirm = MessageBox.Show("Delete selected appointment?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using var conn = new MySqlConnection(Form1.Config.ConnectionString);
                conn.Open();
                using var cmd = new MySqlCommand("DELETE FROM appointments WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", apptId.Value);
                var rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    LoadAppointments();
                    MessageBox.Show("Appointment deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnreturn_Click(object sender, EventArgs e)
        {
            var dash = new dashboard();
            dash.Show();
            this.Close();
        }
        private void Grid_SelectionChanged(object? sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                ClearInputs();
                return;
            }
            var row = dataGridView1.CurrentRow;
            txtPatient.Text = row.Cells["patient_name"].Value?.ToString() ?? "";
            txtDoctor.Text = row.Cells["doctor_name"].Value?.ToString() ?? "";
            txtReason.Text = row.Cells["reason"].Value?.ToString() ?? "";

            if (row.Cells["appointment_datetime"].Value != null && DateTime.TryParse(row.Cells["appointment_datetime"].Value.ToString(), out var dt))
            {
                dateTimePicker1.Value = dt;
            }
        }
        private void ClearInputs()
        {
            txtPatient.Text = "";
            txtDoctor.Text = "";
            txtReason.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dataGridView1.ClearSelection();
        }
    }
}
