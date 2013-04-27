using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.Environment.Extensions.Models;
using Orchard.Security.Permissions;

namespace Bolo.DirectoryNav
{
    public class Permissions : IPermissionProvider
    {
        public static readonly Permission ManageDirectoryNav = new Permission { Description = "Managing Directory Nav", Name = "ManageDirectoryNav" };

        public virtual Feature Feature { get; set; }

        public IEnumerable<Permission> GetPermissions()
        {
            return new[]
                   {
                       ManageDirectoryNav,
                   };
        }

        public IEnumerable<PermissionStereotype> GetDefaultStereotypes()
        {
            return new[]
                   {
                       new PermissionStereotype
                       {
                           Name = "Administrator",
                           Permissions = new[] {ManageDirectoryNav}
                       },
                       new PermissionStereotype
                       {
                           Name = "Editor",
                           Permissions = new[] {ManageDirectoryNav}
                       },
                       new PermissionStereotype
                       {
                           Name = "Moderator",
                       },
                       new PermissionStereotype
                       {
                           Name = "Author",
                           Permissions = new[] {ManageDirectoryNav}
                       },
                       new PermissionStereotype
                       {
                           Name = "Contributor",
                       },
                   };
        }

    }
}