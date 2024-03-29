﻿using System;
using System.Collections.Generic;
/************************************************************
 * Assignment 2
 * Programmers: Robert Tyler Trotter z1802019
 *              Mitchell Trafton     z1831076
 ***********************************************************/
namespace Assignment2
{
    public enum itemType
    {
        Helmet, Neck, Shoulders, Back, Chest, Wrist,
        Gloves, Belt, Pants, Boots, Ring, Trinket, None
    };
    public enum Race { Orc, Troll, Tauren, Forsaken };

    public enum Class { Warrior, Mage, Druid, Priest, 
                        Warlock, Rogue, Paladin, Hunter, Shaman };

    public enum Role { Tank, DPS, Healer };

    public enum GuildType { Casual, Questing, MythicPls, Raiding, PVP };

    static class Constants
    {
        public static uint MAX_ILVL = 360;
        public static uint MAX_PRIMARY = 200;
        public static uint MAX_STAMINA = 275;
        public static uint MAX_LEVEL = 60;
        public static uint GEAR_SLOTS = 14;
        public static uint MAX_INVENTORY_SIZE = 20;

        public static Dictionary<Class, List<Role>> allowedRolls = new Dictionary<Class, List<Role>>() //dictionary contining lists of allowed roles for each race
        {
            { Class.Warrior, new List<Role>{ Role.Tank, Role.DPS } },
            { Class.Mage, new List<Role>{ Role.DPS } },
            { Class.Druid, new List<Role>{ Role.Tank, Role.Healer, Role.DPS } },
            { Class.Priest, new List<Role>{ Role.Healer, Role.DPS } },
            { Class.Warlock, new List<Role>{ Role.DPS } },
            { Class.Rogue, new List<Role>{ Role.DPS } },
            { Class.Paladin, new List<Role>{ Role.Tank, Role.Healer, Role.DPS } },
            { Class.Hunter, new List<Role>{ Role.DPS } },
            { Class.Shaman, new List<Role>{ Role.Healer, Role.DPS } }
        };
    }

}