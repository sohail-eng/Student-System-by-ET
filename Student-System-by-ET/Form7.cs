using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_System_by_ET
{
    public partial class Form7 : Form
    {
        Form1 f;
        public Form7(Form1 f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            f.Show();
        }
    }
}
