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
        Random rng = new Random();

        ZombRandLib zomg = null;
        ZombieOptions zom = null;
        public bool[] Settings { get; private set; } = null;
        public string[] Sett { get; private set; } = new string[] { null, null, null};
        public Zombies()
        {
            InitializeComponent();
            zomg = new ZombRandLib();
        }

        public void SetSettings(bool[] set, string[] str)
        {
            Settings = set;
            Sett = str;
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
                    lst.Items.Clear();
                    SetList();
                }
            }
        }

        private void BtnRandomize_Click(object sender, EventArgs e)
        {
            zomg.TrueRandom();
            lst.Items.Clear();
            SetList();
        }

        private void SetList()
        {
            ///Sets Weapon
            if (zomg.Wep) lst.Items.Add("Weapon:" + zomg.WeaponRand);
            else lst.Items.Add("Weapon Not Randomized");

            ///Sets the DLC
            if (zomg.DLC_Enabled) lst.Items.Add("DLC: Enabled");
            else lst.Items.Add("DLC: Disabled");

            ///Sets Box Ban
            if (zomg.Box_OutofCat) lst.Items.Add("Box has been Banned");
            else lst.Items.Add("Box is allowed");
            ///Sets Wall Ban
            if (zomg.Wall_OutofCat) lst.Items.Add("Wall Weapons have been Banned");
            else lst.Items.Add("Wall Weapons are allowed");

            ///Sets Field Upgrade
            if (zomg.FR) lst.Items.Add("Field Upgrade: " + zomg.FieldRand);
            else lst.Items.Add("Field Upgrade Not Randomized");

            ///Sets Perk Order
            if (zomg.OrderedPerks.Trim() != null)
            {
                lst.Items.Add("Perk Order: ");
                string[] spl = zomg.OrderedPerks.Split(',');
                foreach (string a in spl)
                    lst.Items.Add(a);
            }
            else lst.Items.Add("Perks not Randomized");

            ///Sets the Support item
            if ( Sett[0] == null || Sett[0].Trim() == "")
            {
                int r = rng.Next(3);
                if (r == 1)
                    Sett[0] = "Ban Specific";
                else if (r == 2) Sett[0] = "All but Specific";
                else Sett[0] = "";
            }

            if (Sett[0].Trim() == "Ban Specific") lst.Items.Add("Banned Support item: " + zomg.SupportRand);
            else if (Sett[0].Trim() == "All but Specific") lst.Items.Add("Only usable Support: " + zomg.SupportRand);
            else lst.Items.Add("Support Not Randomized");

            ///Sets the Tactical item
            if (Sett[1] == null || Sett[1].Trim() == "")
            {
                int r = rng.Next(3);
                if (r == 1)
                    Sett[1] = "Ban Specific";
                else if (r == 2) Sett[1] = "All but Specific";
                else Sett[1] = "";
            }
            if (Sett[1].Trim() == "Ban Specific") lst.Items.Add("Banned Tactical item: " + zomg.SupportRand);
            else if (Sett[1].Trim() == "All but Specific") lst.Items.Add("Only usable Tactical: " + zomg.SupportRand);
            else lst.Items.Add("Tactical Not Randomized");

            ///Sets the Lethal item
            if (Sett[2] == null || Sett[2].Trim() == "")
            {
                int r = rng.Next(3);
                if (r == 1)
                    Sett[2] = "Ban Specific";
                else if (r == 2) Sett[2] = "All but Specific";
                else Sett[2] = "";
            }
            if (Sett[2].Trim() == "Ban Specific") lst.Items.Add("Banned Lethal item: " + zomg.SupportRand);
            else if (Sett[2].Trim() == "All but Specific") lst.Items.Add("Only usable Lethal: " + zomg.SupportRand);
            else lst.Items.Add("Lethal Not Randomized");
        }
    }
}
