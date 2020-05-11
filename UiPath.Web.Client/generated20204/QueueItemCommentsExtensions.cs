// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20204
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for QueueItemComments.
    /// </summary>
    public static partial class QueueItemCommentsExtensions
    {
            /// <summary>
            /// Gets the QueueItemComments.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Queues or Queues.Read.
            ///
            /// Required permissions: Queues.View and Transactions.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline.
            /// </param>
            /// <param name='filter'>
            /// Filters the results, based on a Boolean condition.
            /// </param>
            /// <param name='select'>
            /// Selects which properties to include in the response.
            /// </param>
            /// <param name='orderby'>
            /// Sorts the results.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results.
            /// </param>
            /// <param name='count'>
            /// Includes a count of the matching results in the response.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static ODataValueIEnumerableQueueItemCommentDto Get(this IQueueItemComments operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.GetAsync(expand, filter, select, orderby, top, skip, count, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the QueueItemComments.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Queues or Queues.Read.
            ///
            /// Required permissions: Queues.View and Transactions.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline.
            /// </param>
            /// <param name='filter'>
            /// Filters the results, based on a Boolean condition.
            /// </param>
            /// <param name='select'>
            /// Selects which properties to include in the response.
            /// </param>
            /// <param name='orderby'>
            /// Sorts the results.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results.
            /// </param>
            /// <param name='count'>
            /// Includes a count of the matching results in the response.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataValueIEnumerableQueueItemCommentDto> GetAsync(this IQueueItemComments operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), long? xUIPATHOrganizationUnitId = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(expand, filter, select, orderby, top, skip, count, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a QueueItemComment.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Queues or Queues.Write.
            ///
            /// Required permissions: Queues.View and Transactions.Edit.
            ///
            /// Note: If the CreationTime is passed in in the
            /// {UiPath.Orchestrator.Application.Dto.Queues.QueueItemCommentDto} it will be
            /// overriden with server UTC time.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='queueItemCommentDto'>
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static QueueItemCommentDto Post(this IQueueItemComments operations, QueueItemCommentDto queueItemCommentDto, long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.PostAsync(queueItemCommentDto, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a QueueItemComment.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Queues or Queues.Write.
            ///
            /// Required permissions: Queues.View and Transactions.Edit.
            ///
            /// Note: If the CreationTime is passed in in the
            /// {UiPath.Orchestrator.Application.Dto.Queues.QueueItemCommentDto} it will be
            /// overriden with server UTC time.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='queueItemCommentDto'>
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<QueueItemCommentDto> PostAsync(this IQueueItemComments operations, QueueItemCommentDto queueItemCommentDto, long? xUIPATHOrganizationUnitId = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(queueItemCommentDto, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a QueueItemComment by Id.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Queues or Queues.Read.
            ///
            /// Required permissions: Queues.View and Transactions.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline.
            /// </param>
            /// <param name='select'>
            /// Selects which properties to include in the response.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static QueueItemCommentDto GetById(this IQueueItemComments operations, long id, string expand = default(string), string select = default(string), long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.GetByIdAsync(id, expand, select, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a QueueItemComment by Id.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Queues or Queues.Read.
            ///
            /// Required permissions: Queues.View and Transactions.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline.
            /// </param>
            /// <param name='select'>
            /// Selects which properties to include in the response.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<QueueItemCommentDto> GetByIdAsync(this IQueueItemComments operations, long id, string expand = default(string), string select = default(string), long? xUIPATHOrganizationUnitId = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetByIdWithHttpMessagesAsync(id, expand, select, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a QueueItemComment
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Queues or Queues.Write.
            ///
            /// Required permissions: Queues.View and Transactions.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='queueItemCommentDto'>
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static void PutById(this IQueueItemComments operations, long id, QueueItemCommentDto queueItemCommentDto, long? xUIPATHOrganizationUnitId = default(long?))
            {
                operations.PutByIdAsync(id, queueItemCommentDto, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a QueueItemComment
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Queues or Queues.Write.
            ///
            /// Required permissions: Queues.View and Transactions.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='queueItemCommentDto'>
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutByIdAsync(this IQueueItemComments operations, long id, QueueItemCommentDto queueItemCommentDto, long? xUIPATHOrganizationUnitId = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.PutByIdWithHttpMessagesAsync(id, queueItemCommentDto, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Deletes a QueueItemComment.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Queues or Queues.Write.
            ///
            /// Required permissions: Queues.View and Transactions.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='ifMatch'>
            /// If-Match header
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static void DeleteById(this IQueueItemComments operations, long id, string ifMatch = default(string), long? xUIPATHOrganizationUnitId = default(long?))
            {
                operations.DeleteByIdAsync(id, ifMatch, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a QueueItemComment.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Queues or Queues.Write.
            ///
            /// Required permissions: Queues.View and Transactions.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='ifMatch'>
            /// If-Match header
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteByIdAsync(this IQueueItemComments operations, long id, string ifMatch = default(string), long? xUIPATHOrganizationUnitId = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.DeleteByIdWithHttpMessagesAsync(id, ifMatch, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Returns a collection of Queue Item Comments associated to a Queue Item and
            /// all its related Queue Items.
            /// A Queue Item is related to another if it was created as a retry of a failed
            /// Queue Item. They also share the same Key.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Queues or Queues.Read.
            ///
            /// Required permissions: Queues.View and Transactions.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='queueItemId'>
            /// The Id of the Queue Item for which the comment history is requested.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline.
            /// </param>
            /// <param name='filter'>
            /// Filters the results, based on a Boolean condition.
            /// </param>
            /// <param name='select'>
            /// Selects which properties to include in the response.
            /// </param>
            /// <param name='orderby'>
            /// Sorts the results.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results.
            /// </param>
            /// <param name='count'>
            /// Includes a count of the matching results in the odata-count header.
            /// </param>
            public static ODataValueIEnumerableQueueItemCommentDto GetQueueItemCommentsHistoryByQueueitemid(this IQueueItemComments operations, long queueItemId, long? xUIPATHOrganizationUnitId = default(long?), string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?))
            {
                return operations.GetQueueItemCommentsHistoryByQueueitemidAsync(queueItemId, xUIPATHOrganizationUnitId, expand, filter, select, orderby, top, skip, count).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a collection of Queue Item Comments associated to a Queue Item and
            /// all its related Queue Items.
            /// A Queue Item is related to another if it was created as a retry of a failed
            /// Queue Item. They also share the same Key.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Queues or Queues.Read.
            ///
            /// Required permissions: Queues.View and Transactions.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='queueItemId'>
            /// The Id of the Queue Item for which the comment history is requested.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline.
            /// </param>
            /// <param name='filter'>
            /// Filters the results, based on a Boolean condition.
            /// </param>
            /// <param name='select'>
            /// Selects which properties to include in the response.
            /// </param>
            /// <param name='orderby'>
            /// Sorts the results.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results.
            /// </param>
            /// <param name='count'>
            /// Includes a count of the matching results in the odata-count header.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataValueIEnumerableQueueItemCommentDto> GetQueueItemCommentsHistoryByQueueitemidAsync(this IQueueItemComments operations, long queueItemId, long? xUIPATHOrganizationUnitId = default(long?), string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetQueueItemCommentsHistoryByQueueitemidWithHttpMessagesAsync(queueItemId, xUIPATHOrganizationUnitId, expand, filter, select, orderby, top, skip, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
