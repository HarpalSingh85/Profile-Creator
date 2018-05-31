using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profile_Creator
{
    internal class ProvisionDirectory
    {
        public delegate void HomeDirectoryProvision(object sender, EventArgs e);
        public event HomeDirectoryProvision HomeDirectoryProvisioned;

        public delegate void CitrixDirectoryProvison(object sender, EventArgs e);
        public event CitrixDirectoryProvison CitrixDirectoryProvisioned;

        public async Task ProvisionHomeDirectory(string _path, string _user)
        {   

            if(!Directory.Exists(_path+_user))
            {
                try
                {
                DirectoryInfo _sourcePath = new DirectoryInfo(_path + "##VAA AD New Starter ##");
                DirectoryInfo _targetPath = new DirectoryInfo(_path + _user);
                _targetPath.Create();
                CopyFilesRecursively(_sourcePath, _targetPath);
                SetFolderPermission perm = new SetFolderPermission(_user,(_path + _user),"Modify");
                await  perm.AddFolderPermissionAsync();
                
                }
                catch(Exception Ex)
                {
                    throw Ex;
                }

                OnHomeDirectoryProvisioned();

            }
            else
            {
                DirectoryInfo _sourcePath = new DirectoryInfo(_path + "##VAA AD New Starter ##");
                DirectoryInfo _targetPath = new DirectoryInfo(_path + _user);
                CopyFilesRecursively(_sourcePath, _targetPath);
                SetFolderPermission perm = new SetFolderPermission(_user, (_path + _user), "Modify");
                await perm.AddFolderPermissionAsync();
                OnHomeDirectoryProvisioned();
            }

        }

        protected virtual void OnHomeDirectoryProvisioned()
        {
            HomeDirectoryProvisioned?.Invoke(this, EventArgs.Empty);
        }

        public async Task ProvisionCitrixDirectory(string _user)
        {
            string _path = @"\\svaakntnas458\Citrix\TSHome\";

            if (!Directory.Exists(_path + _user))
            {
                try
                {
                    DirectoryInfo _sourcePath = new DirectoryInfo(_path + "##VAA AD New Starter ##");
                    DirectoryInfo _targetPath = new DirectoryInfo(_path + _user);
                    _targetPath.Create();
                    CopyFilesRecursively(_sourcePath, _targetPath);
                    SetFolderPermission perm = new SetFolderPermission(_user, (_path + _user), "Modify");
                    await perm.AddFolderPermissionAsync();

                }
                catch (Exception Ex)
                {
                    throw Ex;
                }
                OnCitrixDirectoryProvisioned();
            }
            else
            {
                DirectoryInfo _sourcePath = new DirectoryInfo(_path + "##VAA AD New Starter ##");
                DirectoryInfo _targetPath = new DirectoryInfo(_path + _user);
                CopyFilesRecursively(_sourcePath, _targetPath);
                SetFolderPermission perm = new SetFolderPermission(_user, (_path + _user), "Modify");
                await perm.AddFolderPermissionAsync();
                OnCitrixDirectoryProvisioned();
            }

        }

        protected virtual void OnCitrixDirectoryProvisioned()
        {
            CitrixDirectoryProvisioned?.Invoke(this, EventArgs.Empty);
        }

        public void CopyFilesRecursively(DirectoryInfo source, DirectoryInfo target)
        {
            foreach (DirectoryInfo dir in source.GetDirectories())
                CopyFilesRecursively(dir, target.CreateSubdirectory(dir.Name));
            foreach (FileInfo file in source.GetFiles())
                file.CopyTo(Path.Combine(target.FullName, file.Name),true);
        }

    }
}




