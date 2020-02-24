/*
 * Created by: Byron Edmonds Decosse
 * Created on: Feb,18,2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #7 Album changer
 * when the user click on the menu item it will change the label in the group box
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

namespace AlbumChangerByron
{
    public partial class AlbumChangerFrm : Form
    {
        public AlbumChangerFrm()
        {
            InitializeComponent();
        }

        private void LvlIsRageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // change the lebel to the albums Songs
            this.LblAlbum1.Text = "Safe House, Banned From TV, Super Saiyan, 7AM, Yamborghini Dreams, Right Now, Top, All My Chains, Belly, Enemies, Ballin, Paradise ";
        }

        private void LilUziVertVsTheWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // change the label to the albums songs 
            this.LblAlbum5.Text = "Canadian Goose, High Roller, Money Longer, Grab The Wheel, You Was Right, Baby Are You Home, Ps & Qs, Team Rocket, Scott And Ramona ";
        }

        private void ThePerfectLuvTapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // change the lebel to the albums songs
            this.LblAlbum3.Text = "Do What I Want, Ofcourse We Ghetto Flowers, Original Uzi, Money Mitch, Sideline Watching, I Can Drive, You're Lost, Erase Your Social, Ronda, Seven Million ";
        }

        private void LuvIsRage2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // change the label to the album songs
            this.LblAlbum4.Text = "Two, 444+222, Sauce It Up, No Sleep Leak, The Way Life Goes, For Real, Feelings Mutual, Neon Guts, Early 20 Rager, Unfazed, Pretty Mami, How To Talk, X," +
                "Malfunction, Dark Queen, Xo Your Llif3";
        }
    }
}
