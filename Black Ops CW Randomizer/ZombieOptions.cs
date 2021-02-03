using System;
using System.Windows.Forms;
using ZombiesLib;
namespace Black_Ops_CW_Randomizer
{
    public partial class ZombieOptions : UserControl
    {
        private ZombRandLib lib;
        public ZombieOptions(ZombRandLib lib)
        {
            InitializeComponent();
            this.lib = lib;
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
                cbPerks.Checked
            };
            lib.Random(Settings);
            MessageBox.Show("New Settings Applied!");
        }
    }
}
