using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerAreaByron
{
    public partial class frmPerArea : Form
    {
        public frmPerArea()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //close the program
            this.Close();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //declare local variables
            double length, width;

            //convert to stringfrom each text box
        }
    }
}
