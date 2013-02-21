﻿Imports DotNetNuke.Modules.Blog.Common.Constants

Namespace Security.Permissions

 Public Class PermissionCollection
  Implements IDictionary(Of String, PermissionInfo)

  Private _permissions As New Dictionary(Of String, PermissionInfo)
  Private _keys As New SortedDictionary(Of Integer, String)

  Public Sub New()
   Me.Add("ADD", New PermissionInfo With {.PermissionId = BlogPermissionTypes.ADD, .PermissionKey = "ADD"})
   Me.Add("EDIT", New PermissionInfo With {.PermissionId = BlogPermissionTypes.EDIT, .PermissionKey = "EDIT"})
   Me.Add("APPROVE", New PermissionInfo With {.PermissionId = BlogPermissionTypes.APPROVE, .PermissionKey = "APPROVE"})
  End Sub

  Public Function GetById(id As Integer) As PermissionInfo
   Select Case id
    Case BlogPermissionTypes.ADD
     Return Me("ADD")
    Case BlogPermissionTypes.EDIT
     Return Me("EDIT")
    Case BlogPermissionTypes.APPROVE
     Return Me("APPROVE")
   End Select
   Return Nothing
  End Function

  Public Sub Add(item As System.Collections.Generic.KeyValuePair(Of String, PermissionInfo)) Implements System.Collections.Generic.ICollection(Of System.Collections.Generic.KeyValuePair(Of String, PermissionInfo)).Add
   If Not ContainsKey(item.Key) Then
    _permissions.Add(item.Key, item.Value)
    _keys.Add(_permissions.Count - 1, item.Key)
   End If
  End Sub

  Public Sub Clear() Implements System.Collections.Generic.ICollection(Of System.Collections.Generic.KeyValuePair(Of String, PermissionInfo)).Clear
   _permissions.Clear()
   _keys.Clear()
  End Sub

  Public Function Contains(item As System.Collections.Generic.KeyValuePair(Of String, PermissionInfo)) As Boolean Implements System.Collections.Generic.ICollection(Of System.Collections.Generic.KeyValuePair(Of String, PermissionInfo)).Contains
   Return _permissions.ContainsValue(item.Value)
  End Function

  Public Sub CopyTo(array() As System.Collections.Generic.KeyValuePair(Of String, PermissionInfo), arrayIndex As Integer) Implements System.Collections.Generic.ICollection(Of System.Collections.Generic.KeyValuePair(Of String, PermissionInfo)).CopyTo
   'todo
  End Sub

  Public ReadOnly Property Count() As Integer Implements System.Collections.Generic.ICollection(Of System.Collections.Generic.KeyValuePair(Of String, PermissionInfo)).Count
   Get
    Return _permissions.Count
   End Get
  End Property

  Public ReadOnly Property IsReadOnly() As Boolean Implements System.Collections.Generic.ICollection(Of System.Collections.Generic.KeyValuePair(Of String, PermissionInfo)).IsReadOnly
   Get
    Return False
   End Get
  End Property

  Public Function Remove(item As System.Collections.Generic.KeyValuePair(Of String, PermissionInfo)) As Boolean Implements System.Collections.Generic.ICollection(Of System.Collections.Generic.KeyValuePair(Of String, PermissionInfo)).Remove
   If _permissions.ContainsKey(item.Key) Then
    _permissions.Remove(item.Key)
    Return True
   End If
   Return False
  End Function

  Public Sub Add(key As String, value As PermissionInfo) Implements System.Collections.Generic.IDictionary(Of String, PermissionInfo).Add
   If Not _permissions.ContainsKey(key) Then
    _permissions.Add(key, value)
    _keys.Add(_permissions.Count - 1, key)
   End If
  End Sub

  Public Function ContainsKey(key As String) As Boolean Implements System.Collections.Generic.IDictionary(Of String, PermissionInfo).ContainsKey
   Return _permissions.ContainsKey(key)
  End Function

  Default Public Property Item(key As String) As PermissionInfo Implements System.Collections.Generic.IDictionary(Of String, PermissionInfo).Item
   Get
    Return _permissions(key)
   End Get
   Set(value As PermissionInfo)
    _permissions(key) = value
   End Set
  End Property

  Default Public Property Item(index As Integer) As PermissionInfo
   Get
    Return Item(_keys(index))
   End Get
   Set(value As PermissionInfo)
    Item(_keys(index)) = value
   End Set
  End Property

  Public ReadOnly Property Keys() As System.Collections.Generic.ICollection(Of String) Implements System.Collections.Generic.IDictionary(Of String, PermissionInfo).Keys
   Get
    Return _keys.Values
   End Get
  End Property

  Public Function Remove(key As String) As Boolean Implements System.Collections.Generic.IDictionary(Of String, PermissionInfo).Remove
   If _permissions.ContainsKey(key) Then
    _permissions.Remove(key)
    Return True
   End If
   Return False
  End Function

  Public Function TryGetValue(key As String, ByRef value As PermissionInfo) As Boolean Implements System.Collections.Generic.IDictionary(Of String, PermissionInfo).TryGetValue
   Return _permissions.TryGetValue(key, value)
  End Function

  Public ReadOnly Property Values() As System.Collections.Generic.ICollection(Of PermissionInfo) Implements System.Collections.Generic.IDictionary(Of String, PermissionInfo).Values
   Get
    Return _permissions.Values
   End Get
  End Property

  Public Function GetEnumerator() As System.Collections.Generic.IEnumerator(Of System.Collections.Generic.KeyValuePair(Of String, PermissionInfo)) Implements System.Collections.Generic.IEnumerable(Of System.Collections.Generic.KeyValuePair(Of String, PermissionInfo)).GetEnumerator
   Return Nothing
  End Function

  Public Function GetEnumerator1() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
   Return Nothing
  End Function

 End Class
End Namespace
