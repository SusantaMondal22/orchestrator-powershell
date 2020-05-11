// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20204.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class IEdmTerm
    {
        /// <summary>
        /// Initializes a new instance of the IEdmTerm class.
        /// </summary>
        public IEdmTerm()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IEdmTerm class.
        /// </summary>
        /// <param name="schemaElementKind">Possible values include: 'None',
        /// 'TypeDefinition', 'Term', 'Action', 'EntityContainer',
        /// 'Function'</param>
        public IEdmTerm(IEdmTypeReference type = default(IEdmTypeReference), string appliesTo = default(string), string defaultValue = default(string), IEdmTermSchemaElementKind? schemaElementKind = default(IEdmTermSchemaElementKind?), string namespaceProperty = default(string), string name = default(string))
        {
            Type = type;
            AppliesTo = appliesTo;
            DefaultValue = defaultValue;
            SchemaElementKind = schemaElementKind;
            NamespaceProperty = namespaceProperty;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public IEdmTypeReference Type { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AppliesTo")]
        public string AppliesTo { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DefaultValue")]
        public string DefaultValue { get; private set; }

        /// <summary>
        /// Gets possible values include: 'None', 'TypeDefinition', 'Term',
        /// 'Action', 'EntityContainer', 'Function'
        /// </summary>
        [JsonProperty(PropertyName = "SchemaElementKind")]
        public IEdmTermSchemaElementKind? SchemaElementKind { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Namespace")]
        public string NamespaceProperty { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; private set; }

    }
}
