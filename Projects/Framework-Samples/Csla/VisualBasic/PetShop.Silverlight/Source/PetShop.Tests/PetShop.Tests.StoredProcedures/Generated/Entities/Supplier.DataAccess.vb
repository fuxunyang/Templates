﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.0, CSLA Framework: v4.0.0.
'     Changes to Me file will be lost after each regeneration.
'     To extend the functionality of Me class, please modify the partial class 'Supplier.vb.
'
'     Template: EditableRoot.DataAccess.StoredProcedures.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Data
Imports System.Data.SqlClient

Imports Csla
Imports Csla.Data
Imports Csla.Rules

Namespace PetShop.Tests.StoredProcedures
    Public Partial Class Supplier
        <RunLocal()> _
        Protected Shadows Sub DataPortal_Create()
            Dim cancel As Boolean = False
            OnCreating(cancel)
            If (cancel) Then
                Return
            End If
    
            BusinessRules.CheckRules()
    
            OnCreated()
        End Sub
    
        Private Shadows Sub DataPortal_Fetch(ByVal criteria As SupplierCriteria)
            Dim cancel As Boolean = False
            OnFetching(criteria, cancel)
            If (cancel) Then
                Return
            End If
    
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand("[dbo].[CSLA_Supplier_Select]", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                    command.Parameters.AddWithValue("@p_NameHasValue", criteria.NameHasValue)
					command.Parameters.AddWithValue("@p_Addr1HasValue", criteria.Addr1HasValue)
					command.Parameters.AddWithValue("@p_Addr2HasValue", criteria.Addr2HasValue)
					command.Parameters.AddWithValue("@p_CityHasValue", criteria.CityHasValue)
					command.Parameters.AddWithValue("@p_StateHasValue", criteria.StateHasValue)
					command.Parameters.AddWithValue("@p_ZipHasValue", criteria.ZipHasValue)
					command.Parameters.AddWithValue("@p_PhoneHasValue", criteria.PhoneHasValue)
                    Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                        If reader.Read() Then
                            Map(reader)
                        Else
                            Throw New Exception(String.Format("The record was not found in 'Supplier' using the following criteria: {0}.", criteria))
                        End If
                    End Using
                End Using
            End Using
    
            OnFetched()
        End Sub
    
        <Transactional(TransactionalTypes.TransactionScope)> _
        Protected Overrides Sub DataPortal_Insert()
            Dim cancel As Boolean = False
            OnInserting(cancel)
            If (cancel) Then
                Return
            End If
    
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand("[dbo].[CSLA_Supplier_Insert]", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@p_SuppId", Me.SuppId)
				command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(Me.Name))
				command.Parameters.AddWithValue("@p_Status", Me.Status)
				command.Parameters.AddWithValue("@p_Addr1", ADOHelper.NullCheck(Me.Addr1))
				command.Parameters.AddWithValue("@p_Addr2", ADOHelper.NullCheck(Me.Addr2))
				command.Parameters.AddWithValue("@p_City", ADOHelper.NullCheck(Me.City))
				command.Parameters.AddWithValue("@p_State", ADOHelper.NullCheck(Me.State))
				command.Parameters.AddWithValue("@p_Zip", ADOHelper.NullCheck(Me.Zip))
				command.Parameters.AddWithValue("@p_Phone", ADOHelper.NullCheck(Me.Phone))
    
                    command.ExecuteNonQuery()
    
                    Using (BypassPropertyChecks)
                    End Using
                End Using
                
                LoadProperty(_originalSuppIdProperty, Me.SuppId)
    
                FieldManager.UpdateChildren(Me, connection)
            End Using
    
            OnInserted()
        End Sub
    
        <Transactional(TransactionalTypes.TransactionScope)> _
        Protected Overrides Sub DataPortal_Update()
            Dim cancel As Boolean = False
            OnUpdating(cancel)
            If (cancel) Then
                Return
            End If
    
            If Not OriginalSuppId = SuppId Then
                ' Insert new child.
                Dim item As New Supplier()
                item.SuppId = SuppId
			item.Name = Name
			item.Status = Status
			item.Addr1 = Addr1
			item.Addr2 = Addr2
			item.City = City
			item.State = State
			item.Zip = Zip
			item.Phone = Phone
                item = item.Save()
    
                ' Mark child lists as dirty. This code may need to be updated to one-to-one relationships.
                For Each itemToUpdate As Item In Items
    		itemToUpdate.Supplier = SuppId
                Next
    
                ' Create a new connection.
                Using connection As New SqlConnection(ADOHelper.ConnectionString)
                    connection.Open()
                    FieldManager.UpdateChildren(Me, connection)
                End Using
    
                ' Delete the old.
                Dim criteria As New SupplierCriteria()
                criteria.SuppId = OriginalSuppId
                DataPortal_Delete(criteria)
    
                ' Mark the original as the new one.
                OriginalSuppId = SuppId
                OnUpdated()
    
                Return
            End If
    
    
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand("[dbo].[CSLA_Supplier_Update]", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@p_OriginalSuppId", Me.OriginalSuppId)
				command.Parameters.AddWithValue("@p_SuppId", Me.SuppId)
				command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(Me.Name))
				command.Parameters.AddWithValue("@p_Status", Me.Status)
				command.Parameters.AddWithValue("@p_Addr1", ADOHelper.NullCheck(Me.Addr1))
				command.Parameters.AddWithValue("@p_Addr2", ADOHelper.NullCheck(Me.Addr2))
				command.Parameters.AddWithValue("@p_City", ADOHelper.NullCheck(Me.City))
				command.Parameters.AddWithValue("@p_State", ADOHelper.NullCheck(Me.State))
				command.Parameters.AddWithValue("@p_Zip", ADOHelper.NullCheck(Me.Zip))
				command.Parameters.AddWithValue("@p_Phone", ADOHelper.NullCheck(Me.Phone))
    
                    'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    Dim result As Integer = command.ExecuteNonQuery()
                    If (result = 0) Then
                        throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                    End If
    
                LoadProperty(_originalSuppIdProperty, Me.SuppId)
                End Using
    
                FieldManager.UpdateChildren(Me, connection)
            End Using
    
            OnUpdated()
        End Sub
    
        Protected Overrides Sub DataPortal_DeleteSelf()
            Dim cancel As Boolean = False
            OnSelfDeleting(cancel)
            If (cancel) Then
                Return
            End If
        
            DataPortal_Delete(New SupplierCriteria (SuppId))
        
            OnSelfDeleted()
        End Sub
    
        <Transactional(TransactionalTypes.TransactionScope)> _
        Protected Shadows Sub DataPortal_Delete(ByVal criteria As SupplierCriteria)
            Dim cancel As Boolean = False
            OnDeleting(criteria, cancel)
            If (cancel) Then
                Return
            End If
    
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand("[dbo].[CSLA_Supplier_Delete]", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
    
                    'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    Dim result As Integer = command.ExecuteNonQuery()
                    If (result = 0) Then
                        Throw New DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                    End If
                End Using
            End Using
    
            OnDeleted()
        End Sub
    
        Private Sub Map(ByVal reader As SafeDataReader)
            Dim cancel As Boolean = False
            OnMapping(reader, cancel)
            If (cancel) Then
                Return
            End If
    
            Using(BypassPropertyChecks)
                LoadProperty(_suppIdProperty, reader.Item("SuppId"))
                LoadProperty(_originalSuppIdProperty, reader.Item("SuppId"))
                LoadProperty(_nameProperty, reader.Item("Name"))
                LoadProperty(_statusProperty, reader.Item("Status"))
                LoadProperty(_addr1Property, reader.Item("Addr1"))
                LoadProperty(_addr2Property, reader.Item("Addr2"))
                LoadProperty(_cityProperty, reader.Item("City"))
                LoadProperty(_stateProperty, reader.Item("State"))
                LoadProperty(_zipProperty, reader.Item("Zip"))
                LoadProperty(_phoneProperty, reader.Item("Phone"))
            End Using
    
            OnMapped()
    
            MarkOld()
        End Sub
    End Class
End Namespace
