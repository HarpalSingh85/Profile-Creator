using System;
using System.IO;
using System.Threading.Tasks;
using System.Security.AccessControl;

namespace Profile_Creator
{
    internal class SetFolderPermission
    {

        public string User { get; set; }
        public string FolderPath { get; set; }
        public string AccessType { get; set; }

        public delegate void PermissionTaskCompleted(object source, EventArgs e);
        public event PermissionTaskCompleted PermTaskCompleted;


        public SetFolderPermission(string _user, string _folderpath, string _accesstype)
        {
            this.User = _user;
            this.FolderPath = _folderpath;
            this.AccessType = _accesstype;
        }


        public async Task<ProgressReport> AddFolderPermissionAsync()
        {
            ProgressReport update = new ProgressReport();

            await Task.Run(() => {


                try
                {

                    var directoryInfo = new DirectoryInfo(FolderPath);
                    var directorySecurity = directoryInfo.GetAccessControl();

                    if (AccessType.Equals("Read Only"))
                    {
                        var fileSystemRule = new FileSystemAccessRule(User,
                                                                      FileSystemRights.ReadAndExecute,
                                                                      InheritanceFlags.ObjectInherit |
                                                                      InheritanceFlags.ContainerInherit,
                                                                      PropagationFlags.None,
                                                                      AccessControlType.Allow);


                        directorySecurity.AddAccessRule(fileSystemRule);
                        directoryInfo.SetAccessControl(directorySecurity);
                        update.result = true;
                        //OnTaskCompleted();

                    }
                    if (AccessType.Equals("Modify"))
                    {
                        var fileSystemRule = new FileSystemAccessRule(User,
                                                                      FileSystemRights.Modify,
                                                                      InheritanceFlags.ObjectInherit |
                                                                      InheritanceFlags.ContainerInherit,
                                                                      PropagationFlags.None,
                                                                      AccessControlType.Allow);

                        directorySecurity.AddAccessRule(fileSystemRule);
                        directoryInfo.SetAccessControl(directorySecurity);
                        update.result = true;
                        //OnTaskCompleted();
                    }



                }
                catch (Exception ex)
                {
                    if (ex is System.UnauthorizedAccessException)
                    {

                        throw ex;

                    }
                    else
                    {

                        throw ex;
                    }

                }


            });

            OnTaskCompleted();
            return update;

        }

        protected virtual void OnTaskCompleted()
        {
            PermTaskCompleted?.Invoke(this, EventArgs.Empty);
        }


    }
}
