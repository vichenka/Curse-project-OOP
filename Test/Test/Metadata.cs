﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Metadata
    {
        static public string CurrentConnectionString = ConnectionString.defaultString;
        static public bool CurrentAppRole;
        static public int CurrentUserId;
        public class ConnectionString
        {
            static public string defaultString = "Data Source=DESKTOP-GGFT0KG\\SQLEXPRESS;Initial Catalog=KP;Integrated Security=true;";
            static public string user = "Data Source=DESKTOP-FFV5E68\\SQLEXPRESS;Integrated Security = False; User ID = userln; Password=userln;ApplicationIntent=ReadWrite;";
            static public string admin = "Data Source=DESKTOP-FFV5E68\\SQLEXPRESS;Integrated Security=False;User ID=adminln;Password=admin;ApplicationIntent=ReadWrite;";
        }
        public enum AuthRoles
        {
            ADMIN = 2,
            USER = 1,
            ANON = 0
        }

    }
}
