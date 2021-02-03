using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Black_Ops_CW_Randomizer
{
    public partial class Form1 : Form
    {
        UserControl maincont = null;
        public Form1()
        {
            InitializeComponent();
            this.Width = 186;
            this.Height = 140;
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mode has not be implemented yet~!");
            return;
            this.Width = 400;
            this.Height = 300;
            maincont = new Multiplayer();
            BtnMult.Dispose();
            BtnZom.Dispose();
        }

        private void BtnZom_Click(object sender, EventArgs e)
        {
            maincont = new Zombies();
            maincont.Left = 12;
            maincont.Top = 12;

            this.Width = maincont.Width + 36;
            this.Height = 270;
            
            Controls.Add(maincont);
            BtnMult.Dispose();
            BtnZom.Dispose();
        }
    }
}
