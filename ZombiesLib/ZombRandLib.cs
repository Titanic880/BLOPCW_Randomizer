using System;

namespace ZombiesLib
{
    public class ZombRandLib : Weapons.WeaponNames
    {
        readonly Random rand = new Random();
        Weapons.ZmPerks perks = new Weapons.ZmPerks();

        #region Info
        string explName = "Explosives";
        #endregion Info

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
            Content = cont;
            if (Content)
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
        /// Random field upgrade
        /// </summary>
        private void Field()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Randomize the order that you would obtain perks (comma seperated)
        /// </summary>
        /// <returns></returns>
        private string PerkOrder()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Options :: Banned Specific, All but Specified banned, None
        /// </summary>
        /// <returns></returns>
        private string Support()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Options :: Banned Specific, All but Specified banned, None
        /// </summary>
        /// <returns></returns>
        private string Tactical()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Options :: Banned Specific, All but Specified banned, None
        /// </summary>
        /// <returns></returns>
        private string Lethal()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Returns category and Weapon (Comma seperated)
        /// </summary>
        /// <returns></returns>
        private string RandomWeapon()
        {
            int Category = rand.Next(WeaponCategories.Length-1);
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



            return ret;
        }
        #endregion Randomize
    }
}
