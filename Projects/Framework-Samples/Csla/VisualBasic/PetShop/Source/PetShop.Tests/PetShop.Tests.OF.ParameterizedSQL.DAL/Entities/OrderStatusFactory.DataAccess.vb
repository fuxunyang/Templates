'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v1.5.0.0, CSLA Framework: v3.8.0.
'     Changes to this template will not be lost.
'
'     Template: ObjectFactory.DataAccess.ParameterizedSQL.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

#Region "Imports declarations"

Imports System
Imports System.Data
Imports System.Data.SqlClient

Imports Csla
Imports Csla.Data
Imports Csla.Server

Imports PetShop.Tests.OF.ParameterizedSQL

#End Region

Public Partial Class OrderStatusFactory
    Inherits ObjectFactory

    #Region "Create"

    ''' <summary>
    ''' Creates New OrderStatus with default values.
    ''' </summary>
    ''' <Returns>New OrderStatus.</Returns>
    <RunLocal()> _
    Public Function Create() As OrderStatus
        Dim item As OrderStatus = CType(Activator.CreateInstance(GetType(OrderStatus), True), OrderStatus)

        Dim cancel As Boolean = False
        OnCreating(cancel)
        If (cancel) Then
            Return item
        End If

        Using BypassPropertyChecks(item)
            ' Default values.


            CheckRules(item)
            MarkNew(item)
            MarkAsChild(item)
        End Using

        OnCreated()

        Return item
    End Function

    ''' <summary>
    ''' Creates New OrderStatus with default values.
    ''' </summary>
    ''' <Returns>New OrderStatus.</Returns>
    <RunLocal()> _
    Private Function Create(ByVal criteria As OrderStatusCriteria) As  OrderStatus
        Dim item As OrderStatus = CType(Activator.CreateInstance(GetType(OrderStatus), True), OrderStatus)

        Dim cancel As Boolean = False
        OnCreating(cancel)
        If (cancel) Then
            Return item
        End If

        Dim resource As OrderStatus = Fetch(criteria)

        Using BypassPropertyChecks(item)
            item.Timestamp = resource.Timestamp
            item.Status = resource.Status
        End Using

        CheckRules(item)
        MarkNew(item)
        MarkAsChild(item)

        OnCreated()

        Return item
    End Function

    #End Region

    #Region "Fetch

    ''' <summary>
    ''' Fetch OrderStatus.
    ''' </summary>
    ''' <param name="criteria">The criteria.</param>
    ''' <Returns></Returns>
    Public Function Fetch(ByVal criteria As OrderStatusCriteria) As OrderStatus
        Dim item As OrderStatus = Nothing
        
        Dim cancel As Boolean = False
        OnFetching(criteria, cancel)
        If (cancel) Then
            Return item
        End If

        Dim commandText As String = String.Format("SELECT [OrderId], [LineNum], [Timestamp], [Status] FROM [dbo].[OrderStatus] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                    If reader.Read() Then
                        item = Map(reader)
                    Else
                        Throw New Exception(String.Format("The record was not found in 'OrderStatus' using the following criteria: {0}.", criteria))
                    End If
                End Using
            End Using
        End Using

        MarkOld(item)
        MarkAsChild(item)

        OnFetched()

        Return item
    End Function

    #End Region

    #Region "Insert"

    Private Sub DoInsert(ByVal item As OrderStatus, ByVal stopProccessingChildren As Boolean)
        ' Don't update If the item isn't dirty.
        If Not (item.IsDirty) Then
            Return
        End If

        Dim cancel As Boolean = False
        OnInserting(cancel)
        If (cancel) Then
            Return
        End If

        Const commandText As String = "INSERT INTO [dbo].[OrderStatus] ([OrderId], [LineNum], [Timestamp], [Status]) VALUES (@p_OrderId, @p_LineNum, @p_Timestamp, @p_Status)"
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@p_OrderId", item.OrderId)
				command.Parameters.AddWithValue("@p_LineNum", item.LineNum)
				command.Parameters.AddWithValue("@p_Timestamp", item.Timestamp)
				command.Parameters.AddWithValue("@p_Status", item.Status)

                Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                    If reader.Read() Then

                    End If
                End Using
            End Using
        End Using

        MarkOld(item)
        CheckRules(item)
        
        If Not (stopProccessingChildren) Then
            ' Update Child Items.
            Update_Order_OrderMember_OrderId(item)
        End If

        OnInserted()
    End Sub

    #End Region

    #Region "Update"

    <Transactional(TransactionalTypes.TransactionScope)> _
    Public Function Update(ByVal item As OrderStatus) As OrderStatus
        Return Update(item, false)
    End Function

    Public Function Update(ByVal item As OrderStatus, ByVal stopProccessingChildren as Boolean) As OrderStatus
        If(item.IsDeleted) Then
            DoDelete(item)
            MarkNew(item)
        Else If(item.IsNew) Then
            DoInsert(item, stopProccessingChildren)
        Else
           DoUpdate(item, stopProccessingChildren)
        End If

        Return item
    End Function

    Private Sub DoUpdate(ByVal item As OrderStatus, ByVal stopProccessingChildren As Boolean)
        Dim cancel As Boolean = False
        OnUpdating(cancel)
        If (cancel) Then
            Return
        End If

        ' Don't update If the item isn't dirty.
        If (item.IsDirty) Then
            Const commandText As String = "UPDATE [dbo].[OrderStatus]  SET [OrderId] = @p_OrderId, [LineNum] = @p_LineNum, [Timestamp] = @p_Timestamp, [Status] = @p_Status WHERE [OrderId] = @p_OrderId AND [LineNum] = @p_LineNum"
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddWithValue("@p_OrderId", item.OrderId)
				command.Parameters.AddWithValue("@p_LineNum", item.LineNum)
				command.Parameters.AddWithValue("@p_Timestamp", item.Timestamp)
				command.Parameters.AddWithValue("@p_Status", item.Status)

                    Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                        'RecordsAffected: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                        If reader.RecordsAffected = 0 Then
                            Throw New DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                        End If
                    End Using
                End Using
            End Using
        End If

        MarkOld(item)
        CheckRules(item)

        If Not (stopProccessingChildren) Then
            ' Update Child Items.
            Update_Order_OrderMember_OrderId(item)
        End If

        OnUpdated()
    End Sub

    #End Region

    #Region "Delete"

    <Transactional(TransactionalTypes.TransactionScope)> _
    Public Sub Delete(ByVal criteria As OrderStatusCriteria)
        ' Note: this call to delete is for immediate deletion and doesn't keep track of any entity state.
        DoDelete(criteria)
    End Sub

    Protected Sub DoDelete(ByVal item As OrderStatus)
        ' If we're not dirty then don't update the database.
        If Not (item.IsDirty) Then
            Return
        End If

        ' If we're New then don't call delete.
        If (item.IsNew) Then
            Return
        End If

        Dim criteria As New OrderStatusCriteria()
criteria.OrderId = item.OrderId
		criteria.LineNum = item.LineNum
        DoDelete(criteria)

        MarkNew(item)
    End Sub

    Private Sub DoDelete(ByVal criteria As OrderStatusCriteria)
        Dim cancel As Boolean = False
        OnDeleting(criteria, cancel)
        If (cancel) Then
            Return
        End If

        Dim commandText As String = String.Format("DELETE FROM [dbo].[OrderStatus] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))

                'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                Dim result As Integer = command.ExecuteNonQuery()
                If (result = 0) Then
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                End If
            End Using
        End Using

        OnDeleted()
    End Sub

    #End Region

    #Region "Helper Methods"

    Public Function Map(ByVal reader As SafeDataReader) As OrderStatus
        Dim item As OrderStatus = CType(Activator.CreateInstance(GetType(OrderStatus), True), OrderStatus)
        Using BypassPropertyChecks(item)
            item.OrderId = reader.GetInt32("OrderId")
            item.LineNum = reader.GetInt32("LineNum")
            item.Timestamp = reader.GetDateTime("Timestamp")
            item.Status = reader.GetString("Status")
        End Using

        Return item
    End Function

    'AssociatedManyToOne
    Private Shared Sub  Update_Order_OrderMember_OrderId(ByRef item As OrderStatus)
		item.OrderMember.OrderId = item.OrderId

        Dim factory As New OrderFactory
        factory.Update(item.OrderMember, True)
    End Sub

    #End Region

    #Region "Data access partial methods"

    Partial Private Sub OnCreating(ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnFetching(ByVal criteria As OrderStatusCriteria, ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnFetched()
    End Sub
    Partial Private Sub OnInserting(ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnInserted()
    End Sub
    Partial Private Sub OnUpdating(ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnUpdated()
    End Sub
    Partial Private Sub OnSelfDeleting(ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnSelfDeleted()
    End Sub
    Partial Private Sub OnDeleting(ByVal criteria As OrderStatusCriteria, ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnDeleted()
    End Sub

    #End Region
End Class