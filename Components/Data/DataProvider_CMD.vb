Imports System
Imports DotNetNuke

Namespace Data

 Partial Public MustInherit Class DataProvider

  Public MustOverride Sub DeleteBlogPermissions(blogId As Int32)
  Public MustOverride Function GetBlog(blogId As Int32, userId As Int32) As IDataReader
  Public MustOverride Function GetBlogPermissionsByBlog(blogId As Int32) As IDataReader
  Public MustOverride Function GetBlogsByModule(moduleId As Int32, userId As Int32) As IDataReader
  Public MustOverride Function GetEntries(moduleId As Int32, blogID As Int32, published As Int32, endDate As Date, authorUserId As Int32, pageIndex As Int32, pageSize As Int32, orderBy As String) As IDataReader
  Public MustOverride Function GetUserPermissionsByModule(moduleID As Int32, userId As Int32) As IDataReader

 End Class

End Namespace

