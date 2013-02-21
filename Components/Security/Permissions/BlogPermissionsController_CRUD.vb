Imports System
Imports System.Data
Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization

Imports DotNetNuke
Imports DotNetNuke.Common
Imports DotNetNuke.Common.Utilities
Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.Entities.Portals
Imports DotNetNuke.Services.Tokens

Imports DotNetNuke.Modules.Blog.Data

Namespace Security.Permissions

 Partial Public Class BlogPermissionsController

  Public Shared Sub AddBlogPermission(objBlogPermission As BlogPermissionInfo)

   DataProvider.Instance().AddBlogPermission(objBlogPermission.AllowAccess, objBlogPermission.BlogId, objBlogPermission.Expires, objBlogPermission.PermissionId, objBlogPermission.RoleId, objBlogPermission.UserId)

  End Sub

 End Class
End Namespace

