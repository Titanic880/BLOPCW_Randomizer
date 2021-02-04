using System;
using ZombiesLib;
using System.Windows.Forms;

namespace Black_Ops_CW_Randomizer
{
    public partial class ZombieOptions : UserControl
    {
        private readonly ZombRandLib lib;
        private readonly Zombies zomb = null;
        public ZombieOptions(ZombRandLib lib, Zombies zmg)
        {
            InitializeComponent();
            this.lib = lib;
            zomb = zmg;
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            bool LR = false;
            bool SR = false;
            bool TR = false;

            if (combBoxLethal.Text.Trim() != "None")
                LR = true;
            if (comBoxSupport.Text.Trim() != "None")
                SR = true;
            if (comBoxTact.Text.Trim() != "None")
                TR = true;

            bool[] Settings =
            {
                cbCont.Checked,
                cbDLC.Checked,
                cbBox.Checked,
                cbWall.Checked,
                cbField.Checked,
                LR,
                SR,
                TR,
                cbPerks.Checked,
                cbWep.Checked
            };
            string[] a = 
            {
                combBoxLethal.Text, 
                comBoxSupport.Text, 
                comBoxTact.Text
            };

            lib.ApplyOptions(Settings);
            zomb.SetSettings(a);
            BtnApply.Enabled = false;
            MessageBox.Show("New Settings Applied!");
        }
        private void Enable(object sender, EventArgs e)
        {
            BtnApply.Enabled = true;
        }
    }
}