// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20182
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for LicensesNamedUser.
    /// </summary>
    public static partial class LicensesNamedUserExtensions
    {
            /// <summary>
            /// Gets named-user licenses.
            /// </summary>
            /// <remarks>
            /// Required permissions: Robots.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='robotType'>
            /// Possible values include: 'NonProduction', 'Attended', 'Unattended',
            /// 'Development'
            /// </param>
            public static ODataResponseListLicenseNamedUserDto GetLicensesNamedUserByRobottype(this ILicensesNamedUser operations, string robotType)
            {
                return operations.GetLicensesNamedUserByRobottypeAsync(robotType).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets named-user licenses.
            /// </summary>
            /// <remarks>
            /// Required permissions: Robots.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='robotType'>
            /// Possible values include: 'NonProduction', 'Attended', 'Unattended',
            /// 'Development'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseListLicenseNamedUserDto> GetLicensesNamedUserByRobottypeAsync(this ILicensesNamedUser operations, string robotType, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetLicensesNamedUserByRobottypeWithHttpMessagesAsync(robotType, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}