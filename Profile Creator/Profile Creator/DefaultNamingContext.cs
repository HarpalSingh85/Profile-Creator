using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;

namespace Profile_Creator
{    
    public static class DefaultNamingContext
    {
        internal static string GetDefaultNamingContext()
        {
            string defaultNamingContext;
            using (DirectoryEntry rootDSE = new DirectoryEntry("LDAP://RootDSE"))
            {
                defaultNamingContext = rootDSE.Properties["defaultNamingContext"].Value.ToString();
            }

            return defaultNamingContext;
        }
    }
    
}
