﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.1817, CSLA Framework: v4.0.0.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Cart.cs'.
//
//     Template: EditableChild.DataAccess.ParameterizedSQL.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Data;
using System.Data.SqlClient;

using Csla;
using Csla.Data;

#endregion

namespace PetShop.Business
{
    public partial class Cart
    {
        protected override void Child_Create()
        {
            bool cancel = false;
            OnChildCreating(ref cancel);
            if (cancel) return;

            BusinessRules.CheckRules();

            OnChildCreated();
        }

        private void Child_Fetch(CartCriteria criteria)
        {
            bool cancel = false;
            OnChildFetching(criteria, ref cancel);
            if (cancel) return;

            string commandText = string.Format("SELECT [CartId], [UniqueID], [ItemId], [Name], [Type], [Price], [CategoryId], [ProductId], [IsShoppingCart], [Quantity] FROM [dbo].[Cart] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if(reader.Read())
                            Map(reader);
                        else
                            throw new Exception(string.Format("The record was not found in 'Cart' using the following criteria: {0}.", criteria));
                    }
                }
            }

            OnChildFetched();
        }

        #region Child_Insert

        private void Child_Insert(SqlConnection connection)
        {
            bool cancel = false;
            OnChildInserting(connection, ref cancel);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            const string commandText = "INSERT INTO [dbo].[Cart] ([UniqueID], [ItemId], [Name], [Type], [Price], [CategoryId], [ProductId], [IsShoppingCart], [Quantity]) VALUES (@p_UniqueID, @p_ItemId, @p_Name, @p_Type, @p_Price, @p_CategoryId, @p_ProductId, @p_IsShoppingCart, @p_Quantity); SELECT [CartId] FROM [dbo].[Cart] WHERE CartId = SCOPE_IDENTITY()";
            using(SqlCommand command = new SqlCommand(commandText, connection))
            {
                command.Parameters.AddWithValue("@p_UniqueID", this.UniqueID);
					command.Parameters.AddWithValue("@p_ItemId", this.ItemId);
					command.Parameters.AddWithValue("@p_Name", this.Name);
					command.Parameters.AddWithValue("@p_Type", this.Type);
					command.Parameters.AddWithValue("@p_Price", this.Price);
					command.Parameters.AddWithValue("@p_CategoryId", this.CategoryId);
					command.Parameters.AddWithValue("@p_ProductId", this.ProductId);
					command.Parameters.AddWithValue("@p_IsShoppingCart", this.IsShoppingCart);
					command.Parameters.AddWithValue("@p_Quantity", this.Quantity);

                using(var reader = new SafeDataReader(command.ExecuteReader()))
                {
                    if(reader.Read())
                    {

                        // Update identity primary key value.
                        LoadProperty(_cartIdProperty, reader.GetInt32("CartId"));
                    }
                }
            }

            FieldManager.UpdateChildren(this, connection);
            OnChildInserted();
        }

        private void Child_Insert(Profile profile, SqlConnection connection)
        {
            bool cancel = false;
            OnChildInserting(connection, ref cancel);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            const string commandText = "INSERT INTO [dbo].[Cart] ([UniqueID], [ItemId], [Name], [Type], [Price], [CategoryId], [ProductId], [IsShoppingCart], [Quantity]) VALUES (@p_UniqueID, @p_ItemId, @p_Name, @p_Type, @p_Price, @p_CategoryId, @p_ProductId, @p_IsShoppingCart, @p_Quantity); SELECT [CartId] FROM [dbo].[Cart] WHERE CartId = SCOPE_IDENTITY()";
            using(SqlCommand command = new SqlCommand(commandText, connection))
            {
                command.Parameters.AddWithValue("@p_UniqueID", profile != null ? profile.UniqueID : this.UniqueID);
					command.Parameters.AddWithValue("@p_ItemId", this.ItemId);
					command.Parameters.AddWithValue("@p_Name", this.Name);
					command.Parameters.AddWithValue("@p_Type", this.Type);
					command.Parameters.AddWithValue("@p_Price", this.Price);
					command.Parameters.AddWithValue("@p_CategoryId", this.CategoryId);
					command.Parameters.AddWithValue("@p_ProductId", this.ProductId);
					command.Parameters.AddWithValue("@p_IsShoppingCart", this.IsShoppingCart);
					command.Parameters.AddWithValue("@p_Quantity", this.Quantity);

                using(var reader = new SafeDataReader(command.ExecuteReader()))
                {
                    if(reader.Read())
                    {

                        // Update identity primary key value.
                        LoadProperty(_cartIdProperty, reader.GetInt32("CartId"));
                    }
                }

                // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
                if(profile != null && profile.UniqueID != this.UniqueID)
                    LoadProperty(_uniqueIDProperty, profile.UniqueID);
            }
            
            // A child relationship exists on this Business Object but its type is not a child type (E.G. EditableChild). 
            // TODO: Please override OnChildInserted() and insert this child manually.
            // FieldManager.UpdateChildren(this, connection);
            OnChildInserted();
        }

        #endregion

        #region Child_Update

        private void Child_Update(SqlConnection connection)
        {
            bool cancel = false;
            OnChildUpdating(connection, ref cancel);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            const string commandText = "UPDATE [dbo].[Cart]  SET [UniqueID] = @p_UniqueID, [ItemId] = @p_ItemId, [Name] = @p_Name, [Type] = @p_Type, [Price] = @p_Price, [CategoryId] = @p_CategoryId, [ProductId] = @p_ProductId, [IsShoppingCart] = @p_IsShoppingCart, [Quantity] = @p_Quantity WHERE [CartId] = @p_CartId";
            using(SqlCommand command = new SqlCommand(commandText, connection))
            {
                command.Parameters.AddWithValue("@p_CartId", this.CartId);
					command.Parameters.AddWithValue("@p_UniqueID", this.UniqueID);
					command.Parameters.AddWithValue("@p_ItemId", this.ItemId);
					command.Parameters.AddWithValue("@p_Name", this.Name);
					command.Parameters.AddWithValue("@p_Type", this.Type);
					command.Parameters.AddWithValue("@p_Price", this.Price);
					command.Parameters.AddWithValue("@p_CategoryId", this.CategoryId);
					command.Parameters.AddWithValue("@p_ProductId", this.ProductId);
					command.Parameters.AddWithValue("@p_IsShoppingCart", this.IsShoppingCart);
					command.Parameters.AddWithValue("@p_Quantity", this.Quantity);

                using(var reader = new SafeDataReader(command.ExecuteReader()))
                {
                    if(reader.Read())
                    {
                    }
                }
            }

            FieldManager.UpdateChildren(this, connection);

            OnChildUpdated();
        }
 
        private void Child_Update(Profile profile, SqlConnection connection)
        {
            bool cancel = false;
            OnChildUpdating(connection, ref cancel);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            const string commandText = "UPDATE [dbo].[Cart]  SET [UniqueID] = @p_UniqueID, [ItemId] = @p_ItemId, [Name] = @p_Name, [Type] = @p_Type, [Price] = @p_Price, [CategoryId] = @p_CategoryId, [ProductId] = @p_ProductId, [IsShoppingCart] = @p_IsShoppingCart, [Quantity] = @p_Quantity WHERE [CartId] = @p_CartId";
            using(SqlCommand command = new SqlCommand(commandText, connection))
            {
                command.Parameters.AddWithValue("@p_CartId", this.CartId);
					command.Parameters.AddWithValue("@p_UniqueID", profile != null ? profile.UniqueID : this.UniqueID);
					command.Parameters.AddWithValue("@p_ItemId", this.ItemId);
					command.Parameters.AddWithValue("@p_Name", this.Name);
					command.Parameters.AddWithValue("@p_Type", this.Type);
					command.Parameters.AddWithValue("@p_Price", this.Price);
					command.Parameters.AddWithValue("@p_CategoryId", this.CategoryId);
					command.Parameters.AddWithValue("@p_ProductId", this.ProductId);
					command.Parameters.AddWithValue("@p_IsShoppingCart", this.IsShoppingCart);
					command.Parameters.AddWithValue("@p_Quantity", this.Quantity);

                using(var reader = new SafeDataReader(command.ExecuteReader()))
                {
                    if(reader.Read())
                    {
                    }
                }

                // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
                if(profile != null && profile.UniqueID != this.UniqueID)
                    LoadProperty(_uniqueIDProperty, profile.UniqueID);
            }
            
            // A child relationship exists on this Business Object but its type is not a child type (E.G. EditableChild). 
            // TODO: Please override OnChildUpdated() and update this child manually.
            // FieldManager.UpdateChildren(this, connection);

            OnChildUpdated();
        }
        #endregion

        private void Child_DeleteSelf(SqlConnection connection)
        {
            bool cancel = false;
            OnChildSelfDeleting(connection, ref cancel);
            if (cancel) return;
            
            DataPortal_Delete(new CartCriteria (CartId), connection);
        
            OnChildSelfDeleted();
        }

        protected void DataPortal_Delete(CartCriteria criteria, SqlConnection connection)
        {
            bool cancel = false;
            OnDeleting(criteria, connection, ref cancel);
            if (cancel) return;

            string commandText = string.Format("DELETE FROM [dbo].[Cart] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
            using (SqlCommand command = new SqlCommand(commandText, connection))
            {
                command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));

                //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                int result = command.ExecuteNonQuery();
                if (result == 0)
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");
            }

            OnDeleted();
        }

        private void Map(SafeDataReader reader)
        {
            bool cancel = false;
            OnMapping(reader, ref cancel);
            if (cancel) return;

            using(BypassPropertyChecks)
            {
                LoadProperty(_cartIdProperty, reader["CartId"]);
                LoadProperty(_uniqueIDProperty, reader["UniqueID"]);
                LoadProperty(_itemIdProperty, reader["ItemId"]);
                LoadProperty(_nameProperty, reader["Name"]);
                LoadProperty(_typeProperty, reader["Type"]);
                LoadProperty(_priceProperty, reader["Price"]);
                LoadProperty(_categoryIdProperty, reader["CategoryId"]);
                LoadProperty(_productIdProperty, reader["ProductId"]);
                LoadProperty(_isShoppingCartProperty, reader["IsShoppingCart"]);
                LoadProperty(_quantityProperty, reader["Quantity"]);
            }

            OnMapped();

            MarkAsChild();
            MarkOld();
        }
    }
}
