// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20204
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for FoldersNavigation.
    /// </summary>
    public static partial class FoldersNavigationExtensions
    {
            /// <summary>
            /// Returns the folders the current user has access to.
            /// The response will be a list of folders; the hierarchy can be reconstructed
            /// using the ParentId properties. From the root to the folders the user has
            /// actually been assigned to, the folders will be marked as non-selectable
            /// and only the paths to the assigned-to folders will be included.
            /// From the assigned-to folders down to the leaves, the nodes will be marked
            /// as
            /// selectable and their children lists fully populated.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Forbidden or Forbidden.Read.
            ///
            /// Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<ExtendedFolderDto> GetAllFoldersForCurrentUser(this IFoldersNavigation operations)
            {
                return operations.GetAllFoldersForCurrentUserAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the folders the current user has access to.
            /// The response will be a list of folders; the hierarchy can be reconstructed
            /// using the ParentId properties. From the root to the folders the user has
            /// actually been assigned to, the folders will be marked as non-selectable
            /// and only the paths to the assigned-to folders will be included.
            /// From the assigned-to folders down to the leaves, the nodes will be marked
            /// as
            /// selectable and their children lists fully populated.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Forbidden or Forbidden.Read.
            ///
            /// Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ExtendedFolderDto>> GetAllFoldersForCurrentUserAsync(this IFoldersNavigation operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetAllFoldersForCurrentUserWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a filtered subset (paginated) of the folders the current user has
            /// access to.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Forbidden or Forbidden.Read.
            ///
            /// Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='take'>
            /// </param>
            /// <param name='searchText'>
            /// </param>
            public static PageResultDtoFolderDto GetFoldersForCurrentUser(this IFoldersNavigation operations, int skip, int take, string searchText = default(string))
            {
                return operations.GetFoldersForCurrentUserAsync(skip, take, searchText).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a filtered subset (paginated) of the folders the current user has
            /// access to.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Forbidden or Forbidden.Read.
            ///
            /// Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='take'>
            /// </param>
            /// <param name='searchText'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PageResultDtoFolderDto> GetFoldersForCurrentUserAsync(this IFoldersNavigation operations, int skip, int take, string searchText = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetFoldersForCurrentUserWithHttpMessagesAsync(skip, take, searchText, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a subset (paginated) of direct children for a given folder, which
            /// are accessible to the current user.
            /// To ease a folder tree structure navigation design, the list of ancestors
            /// for the given folder is also returned.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Forbidden or Forbidden.Read.
            ///
            /// Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='take'>
            /// </param>
            /// <param name='folderId'>
            /// </param>
            public static FolderNavigationContextDto GetFolderNavigationContextForCurrentUser(this IFoldersNavigation operations, int skip, int take, long? folderId = default(long?))
            {
                return operations.GetFolderNavigationContextForCurrentUserAsync(skip, take, folderId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a subset (paginated) of direct children for a given folder, which
            /// are accessible to the current user.
            /// To ease a folder tree structure navigation design, the list of ancestors
            /// for the given folder is also returned.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Forbidden or Forbidden.Read.
            ///
            /// Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='take'>
            /// </param>
            /// <param name='folderId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FolderNavigationContextDto> GetFolderNavigationContextForCurrentUserAsync(this IFoldersNavigation operations, int skip, int take, long? folderId = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetFolderNavigationContextForCurrentUserWithHttpMessagesAsync(skip, take, folderId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a page of the user-folder assignments for the input user, including
            /// the roles for each folder.
            /// The response also includes the folders assigned to the directory groups of
            /// the user.
            /// The distinction between the folders assigned directly to the user and the
            /// ones assigned to one of his groups
            /// can be made via the User field of the response.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Forbidden or Forbidden.Read.
            ///
            /// Required permissions: (Units.View - Gets roles from all folders) and
            /// (SubFolders.View - Gets roles only from folders where caller has
            /// SubFolders.View permission) and (Users.View and Roles.View).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='username'>
            /// User name
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='take'>
            /// </param>
            public static UserRoleAssignmentsDto GetAllRolesForUser(this IFoldersNavigation operations, string username, int skip, int take)
            {
                return operations.GetAllRolesForUserAsync(username, skip, take).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a page of the user-folder assignments for the input user, including
            /// the roles for each folder.
            /// The response also includes the folders assigned to the directory groups of
            /// the user.
            /// The distinction between the folders assigned directly to the user and the
            /// ones assigned to one of his groups
            /// can be made via the User field of the response.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Forbidden or Forbidden.Read.
            ///
            /// Required permissions: (Units.View - Gets roles from all folders) and
            /// (SubFolders.View - Gets roles only from folders where caller has
            /// SubFolders.View permission) and (Users.View and Roles.View).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='username'>
            /// User name
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='take'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<UserRoleAssignmentsDto> GetAllRolesForUserAsync(this IFoldersNavigation operations, string username, int skip, int take, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetAllRolesForUserWithHttpMessagesAsync(username, skip, take, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}