using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deadlinenov1
{
    public partial class Patient_Module : Form
    {
        private class PatientModel
        {
            public int Id { get; set; }
            public string Name { get; set; } = "";
            public int Age { get; set; }
            public string Contact { get; set; } = "";
            public string Address { get; set; } = "";
        }
    }
}
