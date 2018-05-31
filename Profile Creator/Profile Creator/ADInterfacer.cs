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
        public delegate void UserProvisioned(object source, EventArgs e);
        public event UserProvisioned UserProvisioningCompleted;
        
        public string Value { get; private set; }
        public string ScriptPath { get; private set; }
        public string HomeDirectory { get; private set; }
        public string CTXDirectory { get; private set; }
        public string User { get; private set; }
        public string GrpName { get; private set; }
        public string RoamingGrpName { get; private set; }


        public ADInterfacer(string _user, string _path, string _pLocation,string _profileType)
        {
            MembershipInfo member = new MembershipInfo();
            string _value = null;
            string _scriptPath = null;
            string _roaming = null;
            string _ctxpath = @"\\svaakntnas458\Citrix\TSHome\";
            if (_pLocation.StartsWith("UK"))
            {
                _scriptPath = "UkloginWin7.vbs";
            }
            
            if(_profileType.Equals("Roaming Profile"))
            {
                _roaming = "GS_IT_RoamingProfile";
            }               
                        
            this.ScriptPath = _scriptPath;
            this.Value = _value;            
            this.CTXDirectory = _ctxpath + _user;
            this.HomeDirectory = _path + _user;
            this.User = _user;
            this.GrpName = member.GetGroupName(_path);
            this.RoamingGrpName = _roaming;            
        }

        public async Task<string> ProvisionUser()
        {
            await Task.Run(() => {
                try
                {
                    DirectoryEntry entry = new DirectoryEntry("LDAP://" + DefaultNamingContext.GetDefaultNamingContext());
                    DirectorySearcher searcher = new DirectorySearcher(entry);
                    searcher.Filter = "(&(objectClass=user) (samaccountname=" + User + "))";
                    SearchResult user = searcher.FindOne();

                    if (user != null)
                    {
                        DirectoryEntry entryToUpdate = user.GetDirectoryEntry();
                        entryToUpdate.InvokeSet("scriptPath", ScriptPath);
                        entryToUpdate.InvokeSet("homeDrive", "I:");
                        entryToUpdate.InvokeSet("homeDirectory", HomeDirectory);
                        entryToUpdate.InvokeSet("profilePath", HomeDirectory);
                        entryToUpdate.InvokeSet("TerminalServicesHomeDrive", "I:");
                        entryToUpdate.InvokeSet("TerminalServicesHomeDirectory", HomeDirectory);
                        entryToUpdate.InvokeSet("TerminalServicesProfilePath", CTXDirectory);
                        entryToUpdate.CommitChanges();
                        entry.Close();
                        ProvisionGroupMembership(User, GrpName);
                        if (!String.IsNullOrEmpty(RoamingGrpName))
                        {
                            ProvisionGroupMembership(User, RoamingGrpName);
                        }
                        Value = "Completed";
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

            });
            
            OnUserProvisioningCompleted();
            return Value;

        }

        protected virtual void OnUserProvisioningCompleted()
        {
            UserProvisioningCompleted?.Invoke(this, EventArgs.Empty);
        }

        public void ProvisionGroupMembership(string _user, string _groupName)
        {
            try
            {
                using (PrincipalContext context = new PrincipalContext(ContextType.Domain))
                {
                    GroupPrincipal group = GroupPrincipal.FindByIdentity(context, IdentityType.SamAccountName, _groupName);
                    UserPrincipal usr = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, _user);
                    DirectoryEntry dirEntry = new DirectoryEntry("LDAP://" + group.DistinguishedName);
                    dirEntry.Properties["member"].Add(usr.DistinguishedName);
                    dirEntry.CommitChanges();
                    dirEntry.Close();
                    
                }
                              

            }
            catch (Exception ex)
            {
                throw ex;
            }
                       

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

