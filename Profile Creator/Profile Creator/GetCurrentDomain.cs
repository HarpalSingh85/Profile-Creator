using System;
using System.DirectoryServices.ActiveDirectory;

namespace Profile_Creator
{
     internal static class GetCurrentDomain
    {
        public static string CurrentDomain { get; set; }

        static GetCurrentDomain()
        {
            try
            {
                var _domain = Domain.GetCurrentDomain();
                if (_domain != null)
                {
                    var curName = _domain.FindDomainController().ToString();
                    string[] cList = (curName.Split('.'));
                    CurrentDomain = cList[0];
                }
                else
                {
                    throw new ArgumentNullException();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }   
}
