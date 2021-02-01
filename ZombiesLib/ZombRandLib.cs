using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombiesLib
{
    public class ZombRandLib
    {
        Random rand = new Random();
        #region Information
        private string[] WeaponCategories =
        {
            "SMG",
            "Shotgun",
            "Pistol",
            "Tactical Rifle",
            "Snipers",
            "LMG'S",
            "Assault Rifles",
            "Melee",
            "Explosives",
            "DLC"
        };
        /// <summary>
        /// List of all SMGS
        /// </summary>
        private string[] SMG = 
        {
            "MP5",
            "Milano 821",
            "Ak-74u",
            "KSP 45",
            "Bullfrog",
            "Mac-10" //Move to DLC After First Season ??
        };
        /// <summary>
        /// List All Shotguns
        /// </summary>
        private string[] Shotgun = 
        {
            "Hauer 77",
            "Gallo SA12"
        };
        /// <summary>
        /// 
        /// </summary>
        private string[] Pistol = 
        {
            "1911",
            "Magnum",
            "Diamatti"
        };
        private string[] TacR = {};
        private string[] Sniper = {};
        private string[] LMG = {};
        private string[] AR = {};
        private string[] Melee = { "Knife" };
        /// <summary>
        /// Things that shoot that go boom
        /// </summary>
        private string[] Expl = 
        {
            "Cigma 2",
            "RPG-7",
            "M79"
        };
        /// <summary>
        /// Weapons that are obtained from DLC/Cheevos (Does not include Mac 10 (yet))
        /// </summary>
        private string[] DLC = 
        {
            "Street Sweeper",
            "Sledgehammer",
            "Wakizashi"
        };
        #endregion Information

        #region Info

        #endregion Info

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
