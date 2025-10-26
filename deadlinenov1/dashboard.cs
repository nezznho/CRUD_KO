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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var patientModule = new Patient_Module();
            patientModule.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var doctorModule = new Doctor_Module();
            doctorModule.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Appointment_Module = new Appointment_Module();
            Appointment_Module.Show();
            this.Hide();
        }
    }
}
