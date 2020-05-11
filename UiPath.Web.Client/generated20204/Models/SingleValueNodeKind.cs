// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20204.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for SingleValueNodeKind.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SingleValueNodeKind
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Constant")]
        Constant,
        [EnumMember(Value = "Convert")]
        Convert,
        [EnumMember(Value = "NonResourceRangeVariableReference")]
        NonResourceRangeVariableReference,
        [EnumMember(Value = "BinaryOperator")]
        BinaryOperator,
        [EnumMember(Value = "UnaryOperator")]
        UnaryOperator,
        [EnumMember(Value = "SingleValuePropertyAccess")]
        SingleValuePropertyAccess,
        [EnumMember(Value = "CollectionPropertyAccess")]
        CollectionPropertyAccess,
        [EnumMember(Value = "SingleValueFunctionCall")]
        SingleValueFunctionCall,
        [EnumMember(Value = "Any")]
        Any,
        [EnumMember(Value = "CollectionNavigationNode")]
        CollectionNavigationNode,
        [EnumMember(Value = "SingleNavigationNode")]
        SingleNavigationNode,
        [EnumMember(Value = "SingleValueOpenPropertyAccess")]
        SingleValueOpenPropertyAccess,
        [EnumMember(Value = "SingleResourceCast")]
        SingleResourceCast,
        [EnumMember(Value = "All")]
        All,
        [EnumMember(Value = "CollectionResourceCast")]
        CollectionResourceCast,
        [EnumMember(Value = "ResourceRangeVariableReference")]
        ResourceRangeVariableReference,
        [EnumMember(Value = "SingleResourceFunctionCall")]
        SingleResourceFunctionCall,
        [EnumMember(Value = "CollectionFunctionCall")]
        CollectionFunctionCall,
        [EnumMember(Value = "CollectionResourceFunctionCall")]
        CollectionResourceFunctionCall,
        [EnumMember(Value = "NamedFunctionParameter")]
        NamedFunctionParameter,
        [EnumMember(Value = "ParameterAlias")]
        ParameterAlias,
        [EnumMember(Value = "EntitySet")]
        EntitySet,
        [EnumMember(Value = "KeyLookup")]
        KeyLookup,
        [EnumMember(Value = "SearchTerm")]
        SearchTerm,
        [EnumMember(Value = "CollectionOpenPropertyAccess")]
        CollectionOpenPropertyAccess,
        [EnumMember(Value = "CollectionComplexNode")]
        CollectionComplexNode,
        [EnumMember(Value = "SingleComplexNode")]
        SingleComplexNode,
        [EnumMember(Value = "Count")]
        Count,
        [EnumMember(Value = "SingleValueCast")]
        SingleValueCast
    }
    internal static class SingleValueNodeKindEnumExtension
    {
        internal static string ToSerializedValue(this SingleValueNodeKind? value)
        {
            return value == null ? null : ((SingleValueNodeKind)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this SingleValueNodeKind value)
        {
            switch( value )
            {
                case SingleValueNodeKind.None:
                    return "None";
                case SingleValueNodeKind.Constant:
                    return "Constant";
                case SingleValueNodeKind.Convert:
                    return "Convert";
                case SingleValueNodeKind.NonResourceRangeVariableReference:
                    return "NonResourceRangeVariableReference";
                case SingleValueNodeKind.BinaryOperator:
                    return "BinaryOperator";
                case SingleValueNodeKind.UnaryOperator:
                    return "UnaryOperator";
                case SingleValueNodeKind.SingleValuePropertyAccess:
                    return "SingleValuePropertyAccess";
                case SingleValueNodeKind.CollectionPropertyAccess:
                    return "CollectionPropertyAccess";
                case SingleValueNodeKind.SingleValueFunctionCall:
                    return "SingleValueFunctionCall";
                case SingleValueNodeKind.Any:
                    return "Any";
                case SingleValueNodeKind.CollectionNavigationNode:
                    return "CollectionNavigationNode";
                case SingleValueNodeKind.SingleNavigationNode:
                    return "SingleNavigationNode";
                case SingleValueNodeKind.SingleValueOpenPropertyAccess:
                    return "SingleValueOpenPropertyAccess";
                case SingleValueNodeKind.SingleResourceCast:
                    return "SingleResourceCast";
                case SingleValueNodeKind.All:
                    return "All";
                case SingleValueNodeKind.CollectionResourceCast:
                    return "CollectionResourceCast";
                case SingleValueNodeKind.ResourceRangeVariableReference:
                    return "ResourceRangeVariableReference";
                case SingleValueNodeKind.SingleResourceFunctionCall:
                    return "SingleResourceFunctionCall";
                case SingleValueNodeKind.CollectionFunctionCall:
                    return "CollectionFunctionCall";
                case SingleValueNodeKind.CollectionResourceFunctionCall:
                    return "CollectionResourceFunctionCall";
                case SingleValueNodeKind.NamedFunctionParameter:
                    return "NamedFunctionParameter";
                case SingleValueNodeKind.ParameterAlias:
                    return "ParameterAlias";
                case SingleValueNodeKind.EntitySet:
                    return "EntitySet";
                case SingleValueNodeKind.KeyLookup:
                    return "KeyLookup";
                case SingleValueNodeKind.SearchTerm:
                    return "SearchTerm";
                case SingleValueNodeKind.CollectionOpenPropertyAccess:
                    return "CollectionOpenPropertyAccess";
                case SingleValueNodeKind.CollectionComplexNode:
                    return "CollectionComplexNode";
                case SingleValueNodeKind.SingleComplexNode:
                    return "SingleComplexNode";
                case SingleValueNodeKind.Count:
                    return "Count";
                case SingleValueNodeKind.SingleValueCast:
                    return "SingleValueCast";
            }
            return null;
        }

        internal static SingleValueNodeKind? ParseSingleValueNodeKind(this string value)
        {
            switch( value )
            {
                case "None":
                    return SingleValueNodeKind.None;
                case "Constant":
                    return SingleValueNodeKind.Constant;
                case "Convert":
                    return SingleValueNodeKind.Convert;
                case "NonResourceRangeVariableReference":
                    return SingleValueNodeKind.NonResourceRangeVariableReference;
                case "BinaryOperator":
                    return SingleValueNodeKind.BinaryOperator;
                case "UnaryOperator":
                    return SingleValueNodeKind.UnaryOperator;
                case "SingleValuePropertyAccess":
                    return SingleValueNodeKind.SingleValuePropertyAccess;
                case "CollectionPropertyAccess":
                    return SingleValueNodeKind.CollectionPropertyAccess;
                case "SingleValueFunctionCall":
                    return SingleValueNodeKind.SingleValueFunctionCall;
                case "Any":
                    return SingleValueNodeKind.Any;
                case "CollectionNavigationNode":
                    return SingleValueNodeKind.CollectionNavigationNode;
                case "SingleNavigationNode":
                    return SingleValueNodeKind.SingleNavigationNode;
                case "SingleValueOpenPropertyAccess":
                    return SingleValueNodeKind.SingleValueOpenPropertyAccess;
                case "SingleResourceCast":
                    return SingleValueNodeKind.SingleResourceCast;
                case "All":
                    return SingleValueNodeKind.All;
                case "CollectionResourceCast":
                    return SingleValueNodeKind.CollectionResourceCast;
                case "ResourceRangeVariableReference":
                    return SingleValueNodeKind.ResourceRangeVariableReference;
                case "SingleResourceFunctionCall":
                    return SingleValueNodeKind.SingleResourceFunctionCall;
                case "CollectionFunctionCall":
                    return SingleValueNodeKind.CollectionFunctionCall;
                case "CollectionResourceFunctionCall":
                    return SingleValueNodeKind.CollectionResourceFunctionCall;
                case "NamedFunctionParameter":
                    return SingleValueNodeKind.NamedFunctionParameter;
                case "ParameterAlias":
                    return SingleValueNodeKind.ParameterAlias;
                case "EntitySet":
                    return SingleValueNodeKind.EntitySet;
                case "KeyLookup":
                    return SingleValueNodeKind.KeyLookup;
                case "SearchTerm":
                    return SingleValueNodeKind.SearchTerm;
                case "CollectionOpenPropertyAccess":
                    return SingleValueNodeKind.CollectionOpenPropertyAccess;
                case "CollectionComplexNode":
                    return SingleValueNodeKind.CollectionComplexNode;
                case "SingleComplexNode":
                    return SingleValueNodeKind.SingleComplexNode;
                case "Count":
                    return SingleValueNodeKind.Count;
                case "SingleValueCast":
                    return SingleValueNodeKind.SingleValueCast;
            }
            return null;
        }
    }
}
