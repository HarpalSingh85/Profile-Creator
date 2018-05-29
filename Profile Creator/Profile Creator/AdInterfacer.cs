using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;

namespace Profile_Creator
{
    internal class ADInterfacer
    {       

        public List<string> GetUser(string _user)
        {
            List<string> _value = null;
            
            try
            {                
                PrincipalContext PC = new PrincipalContext(ContextType.Domain);
                UserPrincipal UP = UserPrincipal.FindByIdentity(PC, _user);
                DirectoryEntry DE = (DirectoryEntry)UP.GetUnderlyingObject();
                //To Change the value
               // DE.InvokeSet("TerminalServicesHomeDirectory", new object[] { "testing" });
               // DE.CommitChanges();
                //to get the value
                _value.Add(DE.InvokeGet("TerminalServicesHomeDrive").ToString());
                _value.Add(DE.InvokeGet("TerminalServicesProfilePath").ToString());
                _value.Add(DE.InvokeGet("TerminalServicesHomeDirectory").ToString());
                
            }

            catch (Exception Ex)
            {  
               
                throw Ex;
            }

            return _value;

        }
                      

    }
}

//PrincipalContext PC = new PrincipalContext(ContextType.Domain);
//UserPrincipal UP = UserPrincipal.FindByIdentity(PC, "testact");
//DirectoryEntry DE = (DirectoryEntry)UP.GetUnderlyingObject();
////To Change the value
//DE.InvokeSet("TerminalServicesHomeDirectory", new object[] { "testing" });
//    DE.CommitChanges();
//    //to get the value
//    string value = DE.InvokeGet("TerminalServicesHomeDirectory");