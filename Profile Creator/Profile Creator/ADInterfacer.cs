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

        public string GetUser(string _user,string _path,string _pLocation)
        {
            string _value = null;
            string _scriptPath = null;
            string _ctxpath = @"\\svaakntnas458\Citrix\TSHome\";
            if(_pLocation.StartsWith("UK"))
            {
                _scriptPath = "UkloginWin7.vbs";
            }
            
            try
            {               
                DirectoryEntry entry = new DirectoryEntry("LDAP://" + DefaultNamingContext.GetDefaultNamingContext());
                DirectorySearcher searcher = new DirectorySearcher(entry);
                searcher.Filter = "(&(objectClass=user) (samaccountname=" + _user + "))";                
                SearchResult user = searcher.FindOne();              

                if (user != null)
                {
                    DirectoryEntry entryToUpdate = user.GetDirectoryEntry();
                    entryToUpdate.InvokeSet("scriptPath", _scriptPath);
                    entryToUpdate.InvokeSet("homeDrive", "I:");
                    entryToUpdate.InvokeSet("homeDirectory", _path + _user);
                    entryToUpdate.InvokeSet("profilePath", _path + _user);
                    entryToUpdate.InvokeSet("TerminalServicesHomeDrive", "Z:");
                    entryToUpdate.InvokeSet("TerminalServicesHomeDirectory", _ctxpath + _user);
                    entryToUpdate.InvokeSet("TerminalServicesProfilePath", _ctxpath +  _user);
                    entryToUpdate.CommitChanges();
                    entry.Close();
                    _value = "Completed";
                }
                else
                {
                    throw new InvalidUserException("User ID not found / Invalid");
                }

            }

            catch (Exception Ex)
            {                
                throw Ex;
            }

            return _value;

        }             

    }

    public class InvalidUserException : Exception
    {
        public InvalidUserException(string message)
           : base(message)
        {
        }
    }
}

