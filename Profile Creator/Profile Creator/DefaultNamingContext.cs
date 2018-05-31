using System.DirectoryServices;

namespace Profile_Creator
{    
    public static class DefaultNamingContext
    {
        public static string GetDefaultNamingContext()
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
