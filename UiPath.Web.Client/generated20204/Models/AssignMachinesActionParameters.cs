// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20204.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class AssignMachinesActionParameters
    {
        /// <summary>
        /// Initializes a new instance of the AssignMachinesActionParameters
        /// class.
        /// </summary>
        public AssignMachinesActionParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AssignMachinesActionParameters
        /// class.
        /// </summary>
        public AssignMachinesActionParameters(MachineAssignmentsDto assignments = default(MachineAssignmentsDto))
        {
            Assignments = assignments;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "assignments")]
        public MachineAssignmentsDto Assignments { get; set; }

    }
}
