Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data

Namespace Data

 Partial Public Class SqlDataProvider

#Region " BlogPermission Methods "
	Public Overrides Function GetBlogPermissionsByBlog(blogID As Int32 , StartRowIndex As Integer, MaximumRows As Integer, OrderBy As String) As IDataReader
		Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & ModuleQualifier & "GetBlogPermissionsByBlog", blogID, StartRowIndex, MaximumRows, OrderBy.ToUpper), IDataReader)
	End Function

#End Region

#Region " Blog Methods "
	Public Overrides Function GetBlogsByModule(moduleID As Int32 , StartRowIndex As Integer, MaximumRows As Integer, OrderBy As String) As IDataReader
		Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & ModuleQualifier & "GetBlogsByModule", moduleID, StartRowIndex, MaximumRows, OrderBy.ToUpper), IDataReader)
	End Function

	Public Overrides Function GetBlogsByCreatedByUser(userID As Int32 , StartRowIndex As Integer, MaximumRows As Integer, OrderBy As String) As IDataReader
		Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & ModuleQualifier & "GetBlogsByCreatedByUser", userID, StartRowIndex, MaximumRows, OrderBy.ToUpper), IDataReader)
	End Function

#End Region

#Region " Entry Methods "
	Public Overrides Function GetEntriesByBlog(blogID As Int32 , StartRowIndex As Integer, MaximumRows As Integer, OrderBy As String) As IDataReader
		Return CType(SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner & ObjectQualifier & ModuleQualifier & "GetEntriesByBlog", blogID, StartRowIndex, MaximumRows, OrderBy.ToUpper), IDataReader)
	End Function

#End Region

 End Class

End Namespace
