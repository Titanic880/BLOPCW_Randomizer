using System;

namespace Weapons
{
    public class WeaponNames
    {
        /// <summary>
        /// Name of each major Category of weapon
        /// </summary>
        protected string[] WeaponCategories =
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
        protected string[] SMG =
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
        protected string[] Shotgun =
        {
            "Hauer 77",
            "Gallo SA12"
        };
        /// <summary>
        /// 
        /// </summary>
        protected string[] Pistol =
        {
            "1911",
            "Magnum",
            "Diamatti"
        };
        protected string[] TacR =
        {
            "Type 63",
            "M16",
            "AUG",
            "DMR 14"
        };
        protected string[] Sniper = { };
        protected string[] LMG = { };
        protected string[] AR = { };
        protected string[] Melee = { "Knife" };
        /// <summary>
        /// Things that shoot that go boom
        /// </summary>
        protected string[] Expl =
        {
            "Cigma 2",
            "RPG-7",
            "M79"
        };
        /// <summary>
        /// Weapons that are obtained from DLC/Cheevos (Does not include Mac 10 (yet))
        /// </summary>
        protected string[] DLC =
        {
            "Street Sweeper",
            "Sledgehammer",
            "Wakizashi"
        };
    }
}
