/*
 * Created by: Byron Edmonds-Decosse
 * Created on: 19-02-2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 - Moving Cat
 * This program changes the image in the box into the pre set ones that are set to when you click the menu item 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingCatByron
{
    public partial class frmMovingCat : Form
    {
        public frmMovingCat()
        {
            InitializeComponent();
        }

        private void MniCat2_Click(object sender, EventArgs e)
        {
            // change the image to cat 2
            this.PicCat.Image = Properties.Resources.cat2;

        }

        private void MniCat1_Click(object sender, EventArgs e)
        {
            // change the image to cat 1
            this.PicCat.Image = Properties.Resources.cat1;

        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            // close the program
            this.Close();
        }

        private void MniDenzelCurry1_Click(object sender, EventArgs e)
        {
            //change the image in the picture box
            this.PicCat.Image = Properties.Resources.denzelcurry;
        }

        private void MniDenzelCurry2_Click(object sender, EventArgs e)
        {
            // change the image in the picture box 
            this.PicCat.Image = Properties.Resources.denzelcurry2;
        }
    }
}
