using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZombiesLib;

namespace Black_Ops_CW_Randomizer
{
    public partial class Zombies : UserControl
    {
        ZombRandLib zomg = null;
        ZombieOptions zom = null;
        public bool[] Settings = null;
        public Zombies()
        {
            InitializeComponent();
            zomg = new ZombRandLib();
        }

        public void SetSettings(bool[] set)
        {
            Settings = set;
        }

        private void BtnOptions_Click(object sender, EventArgs e)
        {
            if(zom == null)
            {
                zom = new ZombieOptions(zomg,this);
                zom.Left = Parent.Controls[0].Right + 12;
                zom.Top = 12;
                Parent.Height = 375;
                Parent.Width = 440; //217 173 + 36
                Parent.Controls.Add(zom);
                BtnOptions.Text = "Randomize by Options";
                BtnOptions.Height = BtnOptions.Height * 2;
                BtnRandomize.Height = BtnRandomize.Height * 2;
            }
            else
            {
                if(BtnOptions.Text.Trim() == "Randomize by Options")
                {
                    zomg.Random(Settings);
                }
            }
            
        }

        private void BtnRandomize_Click(object sender, EventArgs e)
        {
            zomg.TrueRandom();   
        }
    }
}
