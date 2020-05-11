// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20204.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The definition of a work queue. A work queue contains work items that
    /// are processed by robots.
    /// </summary>
    public partial class WebhookQueueDefinitionDto
    {
        /// <summary>
        /// Initializes a new instance of the WebhookQueueDefinitionDto class.
        /// </summary>
        public WebhookQueueDefinitionDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebhookQueueDefinitionDto class.
        /// </summary>
        /// <param name="name">A custom name for the queue.</param>
        /// <param name="description">Used to add additional information about
        /// a queue in order to better identify it.</param>
        /// <param name="maxNumberOfRetries">An integer value representing the
        /// number of times an item of this queue can be retried if its
        /// processing fails with application exception and auto retry is
        /// on.</param>
        /// <param name="acceptAutomaticallyRetry">States whether a robot
        /// should retry to process an item if, after processing, it failed
        /// with application exception.</param>
        /// <param name="enforceUniqueReference">States whether Item Reference
        /// field should be unique per Queue. Deleted and retried items are not
        /// checked against this rule.</param>
        /// <param name="slaInMinutes">An integer value representing the Queue
        /// SLA in minutes.</param>
        /// <param name="riskSlaInMinutes">An integer value representing the
        /// Queue RiskSla in minutes.</param>
        public WebhookQueueDefinitionDto(long? id = default(long?), string name = default(string), string description = default(string), int? maxNumberOfRetries = default(int?), bool? acceptAutomaticallyRetry = default(bool?), bool? enforceUniqueReference = default(bool?), int? slaInMinutes = default(int?), int? riskSlaInMinutes = default(int?))
        {
            Id = id;
            Name = name;
            Description = description;
            MaxNumberOfRetries = maxNumberOfRetries;
            AcceptAutomaticallyRetry = acceptAutomaticallyRetry;
            EnforceUniqueReference = enforceUniqueReference;
            SlaInMinutes = slaInMinutes;
            RiskSlaInMinutes = riskSlaInMinutes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; private set; }

        /// <summary>
        /// Gets a custom name for the queue.
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets used to add additional information about a queue in order to
        /// better identify it.
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; private set; }

        /// <summary>
        /// Gets an integer value representing the number of times an item of
        /// this queue can be retried if its processing fails with application
        /// exception and auto retry is on.
        /// </summary>
        [JsonProperty(PropertyName = "MaxNumberOfRetries")]
        public int? MaxNumberOfRetries { get; private set; }

        /// <summary>
        /// Gets states whether a robot should retry to process an item if,
        /// after processing, it failed with application exception.
        /// </summary>
        [JsonProperty(PropertyName = "AcceptAutomaticallyRetry")]
        public bool? AcceptAutomaticallyRetry { get; private set; }

        /// <summary>
        /// Gets states whether Item Reference field should be unique per
        /// Queue. Deleted and retried items are not checked against this rule.
        /// </summary>
        [JsonProperty(PropertyName = "EnforceUniqueReference")]
        public bool? EnforceUniqueReference { get; private set; }

        /// <summary>
        /// Gets an integer value representing the Queue SLA in minutes.
        /// </summary>
        [JsonProperty(PropertyName = "SlaInMinutes")]
        public int? SlaInMinutes { get; private set; }

        /// <summary>
        /// Gets an integer value representing the Queue RiskSla in minutes.
        /// </summary>
        [JsonProperty(PropertyName = "RiskSlaInMinutes")]
        public int? RiskSlaInMinutes { get; private set; }

    }
}
