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
    /// Defines values for RobotDtoHostingType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RobotDtoHostingType
    {
        [EnumMember(Value = "Standard")]
        Standard,
        [EnumMember(Value = "Floating")]
        Floating
    }
    internal static class RobotDtoHostingTypeEnumExtension
    {
        internal static string ToSerializedValue(this RobotDtoHostingType? value)
        {
            return value == null ? null : ((RobotDtoHostingType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this RobotDtoHostingType value)
        {
            switch( value )
            {
                case RobotDtoHostingType.Standard:
                    return "Standard";
                case RobotDtoHostingType.Floating:
                    return "Floating";
            }
            return null;
        }

        internal static RobotDtoHostingType? ParseRobotDtoHostingType(this string value)
        {
            switch( value )
            {
                case "Standard":
                    return RobotDtoHostingType.Standard;
                case "Floating":
                    return RobotDtoHostingType.Floating;
            }
            return null;
        }
    }
}
