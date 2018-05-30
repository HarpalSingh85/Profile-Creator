using System;
using System.Threading.Tasks;
using System.DirectoryServices.AccountManagement;

namespace Profile_Creator
{
    internal static class ADUserValidation
    {       

        public static async Task<bool> ValidateAsync(string _userID)
        {
            bool _result = await Task.Run(() => {

                 bool result = false;
                 using (var context = new PrincipalContext(ContextType.Domain))
                    {
                    using (var user = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, _userID))                   
                    
                        {
                            if (user != null)
                            {
                                result = true;
                                 user.Dispose();
                            }
                        }
                    }
                                                    

                return  result;
            });
            return _result;                      

        }
              
    }
}
