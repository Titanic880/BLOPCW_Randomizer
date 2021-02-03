using System;

namespace ZombiesLib
{
    public class ZombRandLib : Weapons.WeaponNames
    {
        readonly Random rand = new Random();
        readonly Weapons.ZmPerks perks = new Weapons.ZmPerks();

        #region Info
        string explName = "Explosives";

        public string WeaponRand { get; private set; } = null;
        public string FieldRand { get; private set; } = null;
        public string OrderedPerks { get; private set; } = null;
        public string SupportRand { get; private set; } = null;
        public string TacticalRand { get; private set; } = null;
        public string LethalRand { get; private set; } = null;

        /// <summary>
        /// Field Upgrade
        /// </summary>
        public bool FR{ get; private set; } = false;
        /// <summary>
        /// Support
        /// </summary>
        public bool SR { get; private set; } = false;
        /// <summary>
        /// Tactical
        /// </summary>
        public bool TR { get; private set; } = false; 
        /// <summary>
        /// Lethal
        /// </summary>
        public bool LR { get; private set; } = false; 

        #region SafeGuards
        /// <summary>
        /// Changes the name Explosive to "Content Cannons"
        /// </summary>
        public bool Content { get; private set; } = false;
        /// <summary>
        /// Flag that says to allow the DLC weapons 
        /// </summary>
        public bool DLC_Enabled { get; private set; } = false;
        /// <summary>
        /// bool to determine if out of category weapons are good from box
        /// </summary>
        public bool Box_OutofCat { get; private set; } = false;
        /// <summary>
        /// bool to determine if out of category weapons are good from wall
        /// </summary>
        public bool Wall_OutofCat { get; private set; } = false;
        #endregion SafeGuards

        #endregion Info


        #region SetInfo
        public void ApplyOptions(bool[] Sets)
        {
            SetContent(Sets[0]);
            SetDLC(Sets[1]);
            SetOutofCategory_Box(Sets[2]);
            SetOutofCategory_Wall(Sets[3]);

        }
        public void TrueRandom()
        {
            SetContent(Convert.ToBoolean(rand.Next(2)));
            SetDLC(Convert.ToBoolean(rand.Next(2)));
            SetOutofCategory();

            bool[] rnd = {Convert.ToBoolean(rand.Next(2)), Convert.ToBoolean(rand.Next(2)), Convert.ToBoolean(rand.Next(2)), Convert.ToBoolean(rand.Next(2)) };
            FR = rnd[0];
            LR = rnd[1];
            SR = rnd[2];
            TR = rnd[3];

            randEquipment();
            PerkOrder();
        }
        public void Random(bool[] input)
        {
            SetContent(input[0]);
            SetDLC(input[1]);
            SetOutofCategory_Box(input[2]);
            SetOutofCategory_Wall(input[3]);
        }

        /// <summary>
        /// Sets the value of content
        /// </summary>
        /// <param name="cont"></param>
        private string SetContent(bool cont)
        {
            if (cont)
                explName = "Content Cannons";
            else
                explName = "Explosives";

            return explName;
        }
        private void SetDLC(bool cont)
        {
            DLC_Enabled = cont;
        }

        #region OutofCategory
        /// <summary>
        /// Sets the out of category of box weapons
        /// </summary>
        /// <param name="chk"></param>
        public void SetOutofCategory_Box(bool chk)
        {
            Box_OutofCat = chk;
        }
        /// <summary>
        /// Sets the out of category of wall weapons
        /// </summary>
        /// <param name="chk"></param>
        public void SetOutofCategory_Wall(bool chk)
        {
            Wall_OutofCat = chk;

        }
        /// <summary>
        /// Sets random info for out of categories
        /// </summary>
        public void SetOutofCategory()
        {
            SetOutofCategory_Box(Convert.ToBoolean(rand.Next(2)));
            SetOutofCategory_Wall(Convert.ToBoolean(rand.Next(2)));
        }
        #endregion OutofCategory
        #endregion SetInfo



        #region Randomize
        /// <summary>
        /// Returns category and Weapon (Comma seperated)
        /// </summary>
        /// <returns></returns>
        private void RandomWeapon()
        {
            int Category = rand.Next(WeaponCategories.Length - 1);
            string ret = WeaponCategories[Category] + ",";
            ///Checks to see if the category is DLC, and if it is enabled
            if (Category == 9 && DLC_Enabled)
                ret += DLC[rand.Next(DLC.Length)];
            ///Checks for the disabled DLC, and if the Category is selected
            else if (Category == 9 && !DLC_Enabled)
                //Recursion at its finest...
                RandomWeapon();
            else
            {
                ///Find a better method ?
                switch (Category)
                {
                    case 0:
                        ret += SMG[rand.Next(SMG.Length - 1)];
                        break;
                    case 1:
                        ret += Shotgun[rand.Next(Shotgun.Length - 1)];
                        break;

                    case 2:
                        ret += Pistol[rand.Next(Pistol.Length - 1)];
                        break;
                    case 3:
                        ret += TacR[rand.Next(TacR.Length - 1)];
                        break;
                    case 4:
                        ret += Sniper[rand.Next(Sniper.Length - 1)];
                        break;
                    case 5:
                        ret += LMG[rand.Next(LMG.Length - 1)];
                        break;
                    case 6:
                        ret += AR[rand.Next(AR.Length - 1)];
                        break;
                    case 7:
                        ret += Melee[0];            //HARDCODED 0
                        break;
                    case 8:
                        ret = explName;
                        ret += Expl[rand.Next(Expl.Length)];
                        break;
                }
            }
            WeaponRand = ret;
        }

        /// <summary>
        /// Options :: Banned Specific, All but Specified banned, None
        /// </summary>
        /// <returns></returns>
        private void randEquipment()
        {
            if(FR)FieldRand = perks.FieldUpgrades[rand.Next(perks.FieldUpgrades.Length - 1)];
            if(SR)SupportRand = perks.Support[rand.Next(perks.Support.Length - 1)];
            if(TR)TacticalRand = perks.Tactical[rand.Next(perks.Tactical.Length - 1)];
            if(LR)LethalRand = perks.Lethal[rand.Next(perks.Lethal.Length - 1)];
        }
        /// <summary>
        /// Randomize the order that you would obtain perks (comma seperated)
        /// </summary>
        /// <returns></returns>
        private void PerkOrder()
        {
            throw new NotImplementedException();
        }

        #endregion Randomize
    }
}