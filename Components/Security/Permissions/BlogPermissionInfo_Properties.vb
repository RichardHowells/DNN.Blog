Imports System
Imports System.Runtime.Serialization

Namespace Security.Permissions
 Partial Public Class BlogPermissionInfo

#Region " Private Members "
#End Region

#Region " Public Properties "
  <DataMember()>
  Public Property AllowAccess() As Boolean
  <DataMember()>
  Public Property BlogId() As Int32
  <DataMember()>
  Public Property Expires() As Date
  <DataMember()>
  Public Property PermissionId() As Int32
  <DataMember()>
  Public Property RoleId() As Int32
  <DataMember()>
  Public Property UserId() As Int32
  <DataMember()>
  Public Property Username() As String
  <DataMember()>
  Public Property DisplayName() As String
  '<DataMember()>
  'Public Property RoleName() As String
#End Region

 End Class
End Namespace


