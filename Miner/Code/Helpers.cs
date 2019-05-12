using System.ComponentModel;
using System.Reflection;

namespace Miner.Code
{
    public static class Helpers
    {
        public enum AvailableLocalizations
        {
            [Description("en-US")]
            English,
            [Description("ru-RU")]
            Russian
        }

        public static string GetEnumDescriptions(AvailableLocalizations value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute attribute = fi.GetCustomAttribute<DescriptionAttribute>(false);

            if (attribute != null)
                return attribute.Description;
            else 
                return value.ToString();
        }
    }
}
