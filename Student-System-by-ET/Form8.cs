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
    public partial class Form8 : Form
    {
        Form f;
        public Form8(Form1 f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {
            f.Show();
        }
    }
}
