﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Linq.Dynamic;

namespace Tracker.Core.Data
{
    /// <summary>
    /// The query extension class for User.
    /// </summary>
    public static partial class UserExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        public static Tracker.Core.Data.User GetByKey(this IQueryable<Tracker.Core.Data.User> queryable, int id)
        {
            var entity = queryable as System.Data.Linq.Table<Tracker.Core.Data.User>;
            if (entity != null && entity.Context.LoadOptions == null)
                return Query.GetByKey.Invoke((Tracker.Core.Data.TrackerDataContext)entity.Context, id);
            
            return queryable.FirstOrDefault(u => u.Id == id);
        }

        /// <summary>
        /// Immediately deletes the entity by the primary key from the underlying data source with a single delete command.
        /// </summary>
        /// <param name="table">Represents a table for a particular type in the underlying database containing rows are to be deleted.</param>
        /// <returns>The number of rows deleted from the database.</returns>
        public static int Delete(this System.Data.Linq.Table<Tracker.Core.Data.User> table, int id)
        {
            return table.Delete(u => u.Id == id);
        }
        
        /// <summary>
        /// Gets an instance by using a unique index.
        /// </summary>
        /// <returns>An instance of the entity or null if not found.</returns>
        public static Tracker.Core.Data.User GetByEmailAddress(this IQueryable<Tracker.Core.Data.User> queryable, string emailAddress)
        {
            var entity = queryable as System.Data.Linq.Table<Tracker.Core.Data.User>;
            if (entity != null && entity.Context.LoadOptions == null)
                return Query.GetByEmailAddress.Invoke((Tracker.Core.Data.TrackerDataContext)entity.Context, emailAddress);

            return queryable.FirstOrDefault(u => u.EmailAddress == emailAddress);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.User.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="id">Id to search for.</param>
        /// <returns>IQueryable with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.User> ById(this IQueryable<Tracker.Core.Data.User> queryable, int id)
        {
            return queryable.Where(u => u.Id == id);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.User.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="id">Id to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns>IQueryable with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.User> ById(this IQueryable<Tracker.Core.Data.User> queryable, int id, params int[] additionalValues)
        {
            var idList = new List<int> {id};

            if (additionalValues != null)
                idList.AddRange(additionalValues);

            if (idList.Count == 1)
                return queryable.ById(idList[0]);

            var expression = DynamicExpression.BuildExpression<Tracker.Core.Data.User, bool>("Id", idList);
            return queryable.Where(expression);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.User.EmailAddress"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="emailAddress">EmailAddress to search for.</param>
        /// <returns>IQueryable with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.User> ByEmailAddress(this IQueryable<Tracker.Core.Data.User> queryable, string emailAddress)
        {
            return queryable.Where(u => u.EmailAddress == emailAddress);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.User.EmailAddress"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="emailAddress">EmailAddress to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns>IQueryable with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.User> ByEmailAddress(this IQueryable<Tracker.Core.Data.User> queryable, string emailAddress, params string[] additionalValues)
        {
            var emailAddressList = new List<string> {emailAddress};

            if (additionalValues != null)
                emailAddressList.AddRange(additionalValues);

            if (emailAddressList.Count == 1)
                return queryable.ByEmailAddress(emailAddressList[0]);

            var expression = DynamicExpression.BuildExpression<Tracker.Core.Data.User, bool>("EmailAddress", emailAddressList);
            return queryable.Where(expression);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.User.FirstName"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="firstName">FirstName to search for.</param>
        /// <returns>IQueryable with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.User> ByFirstName(this IQueryable<Tracker.Core.Data.User> queryable, string firstName)
        {
            return queryable.Where(u => object.Equals(u.FirstName, firstName));
        }
        
        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.User.FirstName"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="firstName">FirstName to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns>IQueryable with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.User> ByFirstName(this IQueryable<Tracker.Core.Data.User> queryable, string firstName, params string[] additionalValues)
        {
            var firstNameList = new List<string> {firstName};

            if (additionalValues != null)
                firstNameList.AddRange(additionalValues);
            else
                firstNameList.Add(null);

            if (firstNameList.Count == 1)
                return queryable.ByFirstName(firstNameList[0]);

            var expression = DynamicExpression.BuildExpression<Tracker.Core.Data.User, bool>("FirstName", firstNameList);
            return queryable.Where(expression);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.User.LastName"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="lastName">LastName to search for.</param>
        /// <returns>IQueryable with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.User> ByLastName(this IQueryable<Tracker.Core.Data.User> queryable, string lastName)
        {
            return queryable.Where(u => object.Equals(u.LastName, lastName));
        }
        
        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.User.LastName"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="lastName">LastName to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns>IQueryable with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.User> ByLastName(this IQueryable<Tracker.Core.Data.User> queryable, string lastName, params string[] additionalValues)
        {
            var lastNameList = new List<string> {lastName};

            if (additionalValues != null)
                lastNameList.AddRange(additionalValues);
            else
                lastNameList.Add(null);

            if (lastNameList.Count == 1)
                return queryable.ByLastName(lastNameList[0]);

            var expression = DynamicExpression.BuildExpression<Tracker.Core.Data.User, bool>("LastName", lastNameList);
            return queryable.Where(expression);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.User.CreatedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="createdDate">CreatedDate to search for.</param>
        /// <returns>IQueryable with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.User> ByCreatedDate(this IQueryable<Tracker.Core.Data.User> queryable, System.DateTime createdDate)
        {
            return queryable.Where(u => u.CreatedDate == createdDate);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.User.CreatedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="createdDate">CreatedDate to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns>IQueryable with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.User> ByCreatedDate(this IQueryable<Tracker.Core.Data.User> queryable, System.DateTime createdDate, params System.DateTime[] additionalValues)
        {
            var createdDateList = new List<System.DateTime> {createdDate};

            if (additionalValues != null)
                createdDateList.AddRange(additionalValues);

            if (createdDateList.Count == 1)
                return queryable.ByCreatedDate(createdDateList[0]);

            var expression = DynamicExpression.BuildExpression<Tracker.Core.Data.User, bool>("CreatedDate", createdDateList);
            return queryable.Where(expression);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.User.ModifiedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="modifiedDate">ModifiedDate to search for.</param>
        /// <returns>IQueryable with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.User> ByModifiedDate(this IQueryable<Tracker.Core.Data.User> queryable, System.DateTime modifiedDate)
        {
            return queryable.Where(u => u.ModifiedDate == modifiedDate);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.User.ModifiedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="modifiedDate">ModifiedDate to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns>IQueryable with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.User> ByModifiedDate(this IQueryable<Tracker.Core.Data.User> queryable, System.DateTime modifiedDate, params System.DateTime[] additionalValues)
        {
            var modifiedDateList = new List<System.DateTime> {modifiedDate};

            if (additionalValues != null)
                modifiedDateList.AddRange(additionalValues);

            if (modifiedDateList.Count == 1)
                return queryable.ByModifiedDate(modifiedDateList[0]);

            var expression = DynamicExpression.BuildExpression<Tracker.Core.Data.User, bool>("ModifiedDate", modifiedDateList);
            return queryable.Where(expression);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.User.PasswordHash"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="passwordHash">PasswordHash to search for.</param>
        /// <returns>IQueryable with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.User> ByPasswordHash(this IQueryable<Tracker.Core.Data.User> queryable, string passwordHash)
        {
            return queryable.Where(u => u.PasswordHash == passwordHash);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.User.PasswordHash"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="passwordHash">PasswordHash to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns>IQueryable with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.User> ByPasswordHash(this IQueryable<Tracker.Core.Data.User> queryable, string passwordHash, params string[] additionalValues)
        {
            var passwordHashList = new List<string> {passwordHash};

            if (additionalValues != null)
                passwordHashList.AddRange(additionalValues);

            if (passwordHashList.Count == 1)
                return queryable.ByPasswordHash(passwordHashList[0]);

            var expression = DynamicExpression.BuildExpression<Tracker.Core.Data.User, bool>("PasswordHash", passwordHashList);
            return queryable.Where(expression);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.User.PasswordSalt"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="passwordSalt">PasswordSalt to search for.</param>
        /// <returns>IQueryable with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.User> ByPasswordSalt(this IQueryable<Tracker.Core.Data.User> queryable, string passwordSalt)
        {
            return queryable.Where(u => u.PasswordSalt == passwordSalt);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.User.PasswordSalt"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="passwordSalt">PasswordSalt to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns>IQueryable with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.User> ByPasswordSalt(this IQueryable<Tracker.Core.Data.User> queryable, string passwordSalt, params string[] additionalValues)
        {
            var passwordSaltList = new List<string> {passwordSalt};

            if (additionalValues != null)
                passwordSaltList.AddRange(additionalValues);

            if (passwordSaltList.Count == 1)
                return queryable.ByPasswordSalt(passwordSaltList[0]);

            var expression = DynamicExpression.BuildExpression<Tracker.Core.Data.User, bool>("PasswordSalt", passwordSaltList);
            return queryable.Where(expression);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.User.Comment"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="comment">Comment to search for.</param>
        /// <returns>IQueryable with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.User> ByComment(this IQueryable<Tracker.Core.Data.User> queryable, string comment)
        {
            return queryable.Where(u => object.Equals(u.Comment, comment));
        }
        
        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.User.Comment"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="comment">Comment to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns>IQueryable with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.User> ByComment(this IQueryable<Tracker.Core.Data.User> queryable, string comment, params string[] additionalValues)
        {
            var commentList = new List<string> {comment};

            if (additionalValues != null)
                commentList.AddRange(additionalValues);
            else
                commentList.Add(null);

            if (commentList.Count == 1)
                return queryable.ByComment(commentList[0]);

            var expression = DynamicExpression.BuildExpression<Tracker.Core.Data.User, bool>("Comment", commentList);
            return queryable.Where(expression);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.User.IsApproved"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="isApproved">IsApproved to search for.</param>
        /// <returns>IQueryable with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.User> ByIsApproved(this IQueryable<Tracker.Core.Data.User> queryable, bool isApproved)
        {
            return queryable.Where(u => u.IsApproved == isApproved);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.User.IsApproved"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="isApproved">IsApproved to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns>IQueryable with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.User> ByIsApproved(this IQueryable<Tracker.Core.Data.User> queryable, bool isApproved, params bool[] additionalValues)
        {
            var isApprovedList = new List<bool> {isApproved};

            if (additionalValues != null)
                isApprovedList.AddRange(additionalValues);

            if (isApprovedList.Count == 1)
                return queryable.ByIsApproved(isApprovedList[0]);

            var expression = DynamicExpression.BuildExpression<Tracker.Core.Data.User, bool>("IsApproved", isApprovedList);
            return queryable.Where(expression);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.User.LastLoginDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="lastLoginDate">LastLoginDate to search for.</param>
        /// <returns>IQueryable with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.User> ByLastLoginDate(this IQueryable<Tracker.Core.Data.User> queryable, System.DateTime? lastLoginDate)
        {
            return queryable.Where(u => object.Equals(u.LastLoginDate, lastLoginDate));
        }
        
        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.User.LastLoginDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="lastLoginDate">LastLoginDate to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns>IQueryable with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.User> ByLastLoginDate(this IQueryable<Tracker.Core.Data.User> queryable, System.DateTime? lastLoginDate, params System.DateTime?[] additionalValues)
        {
            var lastLoginDateList = new List<System.DateTime?> {lastLoginDate};

            if (additionalValues != null)
                lastLoginDateList.AddRange(additionalValues);
            else
                lastLoginDateList.Add(null);

            if (lastLoginDateList.Count == 1)
                return queryable.ByLastLoginDate(lastLoginDateList[0]);

            var expression = DynamicExpression.BuildExpression<Tracker.Core.Data.User, bool>("LastLoginDate", lastLoginDateList);
            return queryable.Where(expression);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.User.LastActivityDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="lastActivityDate">LastActivityDate to search for.</param>
        /// <returns>IQueryable with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.User> ByLastActivityDate(this IQueryable<Tracker.Core.Data.User> queryable, System.DateTime lastActivityDate)
        {
            return queryable.Where(u => u.LastActivityDate == lastActivityDate);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.User.LastActivityDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="lastActivityDate">LastActivityDate to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns>IQueryable with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.User> ByLastActivityDate(this IQueryable<Tracker.Core.Data.User> queryable, System.DateTime lastActivityDate, params System.DateTime[] additionalValues)
        {
            var lastActivityDateList = new List<System.DateTime> {lastActivityDate};

            if (additionalValues != null)
                lastActivityDateList.AddRange(additionalValues);

            if (lastActivityDateList.Count == 1)
                return queryable.ByLastActivityDate(lastActivityDateList[0]);

            var expression = DynamicExpression.BuildExpression<Tracker.Core.Data.User, bool>("LastActivityDate", lastActivityDateList);
            return queryable.Where(expression);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.User.LastPasswordChangeDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="lastPasswordChangeDate">LastPasswordChangeDate to search for.</param>
        /// <returns>IQueryable with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.User> ByLastPasswordChangeDate(this IQueryable<Tracker.Core.Data.User> queryable, System.DateTime? lastPasswordChangeDate)
        {
            return queryable.Where(u => object.Equals(u.LastPasswordChangeDate, lastPasswordChangeDate));
        }
        
        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.User.LastPasswordChangeDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="lastPasswordChangeDate">LastPasswordChangeDate to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns>IQueryable with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.User> ByLastPasswordChangeDate(this IQueryable<Tracker.Core.Data.User> queryable, System.DateTime? lastPasswordChangeDate, params System.DateTime?[] additionalValues)
        {
            var lastPasswordChangeDateList = new List<System.DateTime?> {lastPasswordChangeDate};

            if (additionalValues != null)
                lastPasswordChangeDateList.AddRange(additionalValues);
            else
                lastPasswordChangeDateList.Add(null);

            if (lastPasswordChangeDateList.Count == 1)
                return queryable.ByLastPasswordChangeDate(lastPasswordChangeDateList[0]);

            var expression = DynamicExpression.BuildExpression<Tracker.Core.Data.User, bool>("LastPasswordChangeDate", lastPasswordChangeDateList);
            return queryable.Where(expression);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.User.AvatarType"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="avatarType">AvatarType to search for.</param>
        /// <returns>IQueryable with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.User> ByAvatarType(this IQueryable<Tracker.Core.Data.User> queryable, string avatarType)
        {
            return queryable.Where(u => object.Equals(u.AvatarType, avatarType));
        }
        
        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.User.AvatarType"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="avatarType">AvatarType to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns>IQueryable with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.User> ByAvatarType(this IQueryable<Tracker.Core.Data.User> queryable, string avatarType, params string[] additionalValues)
        {
            var avatarTypeList = new List<string> {avatarType};

            if (additionalValues != null)
                avatarTypeList.AddRange(additionalValues);
            else
                avatarTypeList.Add(null);

            if (avatarTypeList.Count == 1)
                return queryable.ByAvatarType(avatarTypeList[0]);

            var expression = DynamicExpression.BuildExpression<Tracker.Core.Data.User, bool>("AvatarType", avatarTypeList);
            return queryable.Where(expression);
        }

        #region Query
        /// <summary>
        /// A private class for lazy loading static compiled queries.
        /// </summary>
        private static partial class Query
        {

            internal static readonly Func<Tracker.Core.Data.TrackerDataContext, int, Tracker.Core.Data.User> GetByKey = 
                System.Data.Linq.CompiledQuery.Compile(
                    (Tracker.Core.Data.TrackerDataContext db, int id) => 
                        db.User.FirstOrDefault(u => u.Id == id));

            internal static readonly Func<Tracker.Core.Data.TrackerDataContext, string, Tracker.Core.Data.User> GetByEmailAddress = 
                System.Data.Linq.CompiledQuery.Compile(
                    (Tracker.Core.Data.TrackerDataContext db, string emailAddress) => 
                        db.User.FirstOrDefault(u => u.EmailAddress == emailAddress));

        }
        #endregion
    }
}
