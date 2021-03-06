﻿using System.Collections.Generic;
using System.Web.Security;

namespace SecurityGuard.Interfaces
{
    public interface IRoleService
    {
        // Summary:
        //     Gets or sets the name of the application to store and retrieve role information
        //     for.
        //
        // Returns:
        //     The name of the application to store and retrieve role information for.
        string ApplicationName { get; set; }
        //
        // Summary:
        //     Gets a value indicating whether the current user's roles are cached in a
        //     cookie.
        //
        // Returns:
        //     true if the current user's roles are cached in a cookie; otherwise, false.
        //     The default is true.
        bool CacheRolesInCookie { get; }
        //
        // Summary:
        //     Gets the name of the cookie where role names are cached.
        //
        // Returns:
        //     The name of the cookie where role names are cached. The default is .ASPXROLES.
        string CookieName { get; }
        //
        // Summary:
        //     Gets the path for the cached role names cookie.
        //
        // Returns:
        //     The path of the cookie where role names are cached. The default is /.
        string CookiePath { get; }
        //
        // Summary:
        //     Gets a value that indicates how role names cached in a cookie are protected.
        //
        // Returns:
        //     One of the System.Web.Security.CookieProtection enumeration values indicating
        //     how role names that are cached in a cookie are protected. The default is
        //     All.
        CookieProtection CookieProtectionValue { get; }
        //
        // Summary:
        //     Gets a value indicating whether the role names cookie requires SSL in order
        //     to be returned to the server.
        //
        // Returns:
        //     true if SSL is required to return the role names cookie to the server; otherwise,
        //     false. The default is false.
        bool CookieRequireSSL { get; }
        //
        // Summary:
        //     Indicates whether the role names cookie expiration date and time will be
        //     reset periodically.
        //
        // Returns:
        //     true if the role names cookie expiration date and time will be reset periodically;
        //     otherwise, false. The default is true.
        bool CookieSlidingExpiration { get; }
        //
        // Summary:
        //     Gets the number of minutes before the roles cookie expires.
        //
        // Returns:
        //     An integer specifying the number of minutes before the roles cookie expires.
        //     The default is 30 minutes.
        int CookieTimeout { get; }
        //
        // Summary:
        //     Gets a value indicating whether the role-names cookie is session-based or
        //     persistent.
        //
        // Returns:
        //     true if the role-names cookie is a persistent cookie; otherwise false. The
        //     default is false.
        bool CreatePersistentCookie { get; }
        //
        // Summary:
        //     Gets the value of the domain of the role-names cookie.
        //
        // Returns:
        //     The System.Web.HttpCookie.Domain of the role names cookie.
        string Domain { get; }
        //
        // Summary:
        //     Gets or sets a value indicating whether role management is enabled for the
        //     current Web application.
        //
        // Returns:
        //     true if role management is enabled; otherwise, false. The default is false.
        bool Enabled { get; }
        //
        // Summary:
        //     Gets the maximum number of role names to be cached for a user.
        //
        // Returns:
        //     The maximum number of role names to be cached for a user. The default is
        //     25.
        int MaxCachedResults { get; }
        //
        // Summary:
        //     Gets the default role provider for the application.
        //
        // Returns:
        //     The default role provider for the application, which is exposed as a class
        //     that inherits the System.Web.Security.RoleProvider abstract class.
        //
        // Exceptions:
        //   System.Configuration.Provider.ProviderException:
        //     Role management is not enabled.
        RoleProvider Provider { get; }
        //
        // Summary:
        //     Gets a collection of the role providers for the ASP.NET application.
        //
        // Returns:
        //     A System.Web.Security.RoleProviderCollection that contains the role providers
        //     configured for the ASP.NET application.
        //
        // Exceptions:
        //   System.Configuration.Provider.ProviderException:
        //     Role management is not enabled.
        RoleProviderCollection Providers { get; }

        // Summary:
        //     Adds the specified users to the specified role.
        //
        // Parameters:
        //   usernames:
        //     A string array of user names to add to the specified role.
        //
        //   roleName:
        //     The role to add the specified user names to.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     roleName is null.  -or- One of the elements in usernames is null.
        //
        //   System.ArgumentException:
        //     roleName is an empty string or contains a comma (,).  -or- One of the elements
        //     in usernames is an empty string or contains a comma (,).  -or- usernames
        //     contains a duplicate element.
        //
        //   System.Configuration.Provider.ProviderException:
        //     Role management is not enabled.
        void AddUsersToRole(string[] usernames, string roleName);
        //
        // Summary:
        //     Adds the specified users to the specified roles.
        //
        // Parameters:
        //   usernames:
        //     A string array of user names to add to the specified roles.
        //
        //   roleNames:
        //     A string array of role names to add the specified user names to.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     One of the roles in roleNames is null.  -or- One of the users in usernames
        //     is null.
        //
        //   System.ArgumentException:
        //     One of the roles in roleNames is an empty string or contains a comma (,).
        //      -or- One of the users in usernames is an empty string or contains a comma
        //     (,).  -or- roleNames contains a duplicate element.  -or- usernames contains
        //     a duplicate element.
        //
        //   System.Configuration.Provider.ProviderException:
        //     Role management is not enabled.
        void AddUsersToRoles(string[] usernames, string[] roleNames);
        //
        // Summary:
        //     Adds the specified user to the specified role.
        //
        // Parameters:
        //   username:
        //     The user name to add to the specified role.
        //
        //   roleName:
        //     The role to add the specified user name to.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     roleName is null.  -or- username is null.
        //
        //   System.ArgumentException:
        //     roleName is an empty string or contains a comma (,).  -or- username is an
        //     empty string or contains a comma (,).
        //
        //   System.Configuration.Provider.ProviderException:
        //     Role management is not enabled.
        void AddUserToRole(string username, string roleName);
        //
        // Summary:
        //     Adds the specified user to the specified roles.
        //
        // Parameters:
        //   username:
        //     The user name to add to the specified roles.
        //
        //   roleNames:
        //     A string array of roles to add the specified user name to.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     One of the roles in roleNames is null.  -or- username is null.
        //
        //   System.ArgumentException:
        //     One of the roles in roleNames is an empty string or contains a comma (,).
        //      -or- username is an empty string or contains a comma (,).  -or- roleNames
        //     contains a duplicate element.
        //
        //   System.Configuration.Provider.ProviderException:
        //     Role management is not enabled.
        void AddUserToRoles(string username, string[] roleNames);
        //
        // Summary:
        //     Adds a new role to the data source.
        //
        // Parameters:
        //   roleName:
        //     The name of the role to create.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     roleName is null.
        //
        //   System.ArgumentException:
        //     roleName is an empty string.  -or- roleName contains a comma.
        //
        //   System.Configuration.Provider.ProviderException:
        //     Role management is not enabled.
        void CreateRole(string roleName);
        //
        // Summary:
        //     Deletes the cookie where role names are cached.
        //
        // Exceptions:
        //   System.Configuration.Provider.ProviderException:
        //     Role management is not enabled.
        void DeleteCookie();
        //
        // Summary:
        //     Removes a role from the data source.
        //
        // Parameters:
        //   roleName:
        //     The name of the role to delete.
        //
        // Returns:
        //     true if roleName was deleted from the data source; otherwise, false.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     roleName is null.
        //
        //   System.ArgumentException:
        //     roleName is an empty string or contains a comma (,).
        //
        //   System.Configuration.Provider.ProviderException:
        //     roleName has one or more members.  -or- Role management is not enabled.
        bool DeleteRole(string roleName);
        //
        // Summary:
        //     Removes a role from the data source.
        //
        // Parameters:
        //   roleName:
        //     The name of the role to delete.
        //
        //   throwOnPopulatedRole:
        //     If true, throws an exception if roleName has one or more members.
        //
        // Returns:
        //     true if roleName was deleted from the data source; otherwise; false.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     roleName is null.
        //
        //   System.ArgumentException:
        //     roleName is an empty string.
        //
        //   System.Configuration.Provider.ProviderException:
        //     roleName has one or more members and throwOnPopulatedRole is true.  -or-
        //     Role management is not enabled.
        bool DeleteRole(string roleName, bool throwOnPopulatedRole);
        //
        // Summary:
        //     Gets a list of users in a specified role where the user name contains the
        //     specified user name to match.
        //
        // Parameters:
        //   roleName:
        //     The role to search in.
        //
        //   usernameToMatch:
        //     The user name to search for.
        //
        // Returns:
        //     A string array containing the names of all the users whose user name matches
        //     usernameToMatch and who are members of the specified role.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     roleName is null (Nothing in Visual Basic).  -or- usernameToMatch is null.
        //
        //   System.ArgumentException:
        //     roleName is an empty string or contains a comma (,).  -or- usernameToMatch
        //     is an empty string.
        //
        //   System.Configuration.Provider.ProviderException:
        //     Role management is not enabled.
        string[] FindUsersInRole(string roleName, string usernameToMatch);
        //
        // Summary:
        //     Gets a list of all the roles for the application.
        //
        // Returns:
        //     A string array containing the names of all the roles stored in the data source
        //     for the application.
        //
        // Exceptions:
        //   System.Configuration.Provider.ProviderException:
        //     Role management is not enabled.
        string[] GetAllRoles();
        //
        // Summary:
        //     Gets a list of the roles that the currently logged-on user is in.
        //
        // Returns:
        //     A string array containing the names of all the roles that the currently logged-on
        //     user is in.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     There is no current logged-on user.
        //
        //   System.Configuration.Provider.ProviderException:
        //     Role management is not enabled.
        string[] GetRolesForUser();
        //
        // Summary:
        //     Gets a list of the roles that a user is in.
        //
        // Parameters:
        //   username:
        //     The user to return a list of roles for.
        //
        // Returns:
        //     A string array containing the names of all the roles that the specified user
        //     is in.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     username is null.
        //
        //   System.ArgumentException:
        //     username contains a comma (,).
        //
        //   System.Configuration.Provider.ProviderException:
        //     Role management is not enabled.
        string[] GetRolesForUser(string username);
        //
        // Summary:
        //     Gets a list of users in the specified role.
        //
        // Parameters:
        //   roleName:
        //     The role to get the list of users for.
        //
        // Returns:
        //     A string array containing the names of all the users who are members of the
        //     specified role.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     roleName is null.
        //
        //   System.ArgumentException:
        //     roleName is an empty string or contains a comma (,).
        //
        //   System.Configuration.Provider.ProviderException:
        //     Role management is not enabled.
        string[] GetUsersInRole(string roleName);
        //
        // Summary:
        //     Gets a value indicating whether the currently logged-on user is in the specified
        //     role.
        //
        // Parameters:
        //   roleName:
        //     The name of the role to search in.
        //
        // Returns:
        //     true if the currently logged-on user is in the specified role; otherwise,
        //     false.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     roleName is null.  -or- There is no current logged-on user.
        //
        //   System.ArgumentException:
        //     roleName is an empty string or contains a comma (,).
        //
        //   System.Configuration.Provider.ProviderException:
        //     Role management is not enabled.
        bool IsUserInRole(string roleName);
        //
        // Summary:
        //     Gets a value indicating whether the specified user is in the specified role.
        //
        // Parameters:
        //   username:
        //     The name of the user to search for.
        //
        //   roleName:
        //     The name of the role to search in.
        //
        // Returns:
        //     true if the specified user is in the specified role; otherwise, false.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     roleName is null.  -or- username is null.
        //
        //   System.ArgumentException:
        //     roleName is an empty string or contains a comma (,).  -or- username contains
        //     a comma (,).
        //
        //   System.Configuration.Provider.ProviderException:
        //     Role management is not enabled.
        bool IsUserInRole(string username, string roleName);
        //
        // Summary:
        //     Removes the specified user from the specified role.
        //
        // Parameters:
        //   username:
        //     The user to remove from the specified role.
        //
        //   roleName:
        //     The role to remove the specified user from.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     roleName is null.  -or- username is null.
        //
        //   System.ArgumentException:
        //     roleName is an empty string or contains a comma (,) username is an empty
        //     string or contains a comma (,).
        //
        //   System.Configuration.Provider.ProviderException:
        //     Role management is not enabled.
        void RemoveUserFromRole(string username, string roleName);
        //
        // Summary:
        //     Removes the specified user from the specified roles.
        //
        // Parameters:
        //   username:
        //     The user to remove from the specified roles.
        //
        //   roleNames:
        //     A string array of role names to remove the specified user from.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     One of the roles in roleNames is null.  -or- username is null.
        //
        //   System.ArgumentException:
        //     One of the roles in roleNames is an empty string or contains a comma (,).
        //      -or- username is an empty string or contains a comma (,).  -or- roleNames
        //     contains a duplicate element.
        //
        //   System.Configuration.Provider.ProviderException:
        //     Role management is not enabled.
        void RemoveUserFromRoles(string username, string[] roleNames);
        //
        // Summary:
        //     Removes the specified users from the specified role.
        //
        // Parameters:
        //   usernames:
        //     A string array of user names to remove from the specified roles.
        //
        //   roleName:
        //     The name of the role to remove the specified users from.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     roleName is null.  -or- One of the user names in usernames is null.
        //
        //   System.ArgumentException:
        //     roleName is an empty string or contains a comma (,).  -or- One of the user
        //     names in usernames is an empty string or contains a comma (,).  -or- usernames
        //     contains a duplicate element.
        //
        //   System.Configuration.Provider.ProviderException:
        //     Role management is not enabled.
        void RemoveUsersFromRole(string[] usernames, string roleName);
        //
        // Summary:
        //     Removes the specified user names from the specified roles.
        //
        // Parameters:
        //   usernames:
        //     A string array of user names to remove from the specified roles.
        //
        //   roleNames:
        //     A string array of role names to remove the specified users from.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     One of the roles specified in roleNames is null.  -or- One of the users specified
        //     in usernames is null.
        //
        //   System.ArgumentException:
        //     One of the roles specified in roleNames is an empty string or contains a
        //     comma (,).  -or- One of the users specified in usernames is an empty string
        //     or contains a comma (,).  -or- roleNames contains a duplicate element.  -or-
        //     usernames contains a duplicate element.
        //
        //   System.Configuration.Provider.ProviderException:
        //     Role management is not enabled.
        void RemoveUsersFromRoles(string[] usernames, string[] roleNames);
        //
        // Summary:
        //     Gets a value indicating whether the specified role name already exists in
        //     the role data source.
        //
        // Parameters:
        //   roleName:
        //     The name of the role to search for in the data source.
        //
        // Returns:
        //     true if the role name already exists in the data source; otherwise, false.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     roleName is null (Nothing in Visual Basic).
        //
        //   System.ArgumentException:
        //     roleName is an empty string or contains a comma (,).
        //
        //   System.Configuration.Provider.ProviderException:
        //     Role management is not enabled.
        bool RoleExists(string roleName);


        /***************************************************************************************
         * Additional Members added by King Wilder
         * ************************************************************************************/
        IEnumerable<string> AvailableRolesForUser(string userName);

    }
}
