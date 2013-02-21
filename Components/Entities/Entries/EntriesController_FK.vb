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

Namespace Entities.Entries

 Partial Public Class EntriesController

  Public Shared Function GetEntriesByBlog(blogID As Int32 ) As List(Of EntryInfo)

   Return DotNetNuke.Common.Utilities.CBO.FillCollection(Of EntryInfo)(DataProvider.Instance().GetEntriesByBlog(blogID, 0, 1, ""))

  End Function

  Public Shared Function GetEntriesByBlog(blogID As Int32 , StartRowIndex As Integer, MaximumRows As Integer, OrderBy As String) As List(Of EntryInfo)

   Return DotNetNuke.Common.Utilities.CBO.FillCollection(Of EntryInfo)(DataProvider.Instance().GetEntriesByBlog(blogID, StartRowIndex, MaximumRows, OrderBy))

  End Function


 End Class
End Namespace

