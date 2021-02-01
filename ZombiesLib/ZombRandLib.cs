﻿using System;


namespace ZombiesLib
{
    public class ZombRandLib : Weapons.WeaponNames
    {
        readonly Random rand = new Random();

        #region SetInfo
        /// <summary>
        /// Sets the value of content
        /// </summary>
        /// <param name="cont"></param>
        public void SetContent(bool cont)
        {
            Content = cont;
            if (Content)
                WeaponCategories[8] = "Content Cannons";
            else
                WeaponCategories[8] = "Explosives";
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

        #region ???

        #endregion ???
    }
}
