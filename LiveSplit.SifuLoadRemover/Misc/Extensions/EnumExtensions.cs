using LiveSplit.SifuLoadRemover.Misc.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveSplit.SifuLoadRemover.Misc.Extensions
{
    public static class EnumExtensions
    {
        public static string Description(this Enum value)
        {
            var enumType = value.GetType();
            var field = enumType.GetField(value.ToString());
            var attributes = field.GetCustomAttributes(typeof(DescriptionAttribute),
                                                       false);
            return attributes.Length == 0 ? value.ToString() : ((DescriptionAttribute)attributes[0]).Description;
        }

        public static string TessDataLanguage(this Enum value)
        {
            var attributes = value.GetAttributesFromEnum(typeof(TessDataAttribute));
            return attributes.Length == 0 ? string.Empty : ((TessDataAttribute)attributes[0]).TessDataName;
        }


        public static string LoadingText(this Enum value)
        {
            var attributes = value.GetAttributesFromEnum(typeof(LoadingTextAttribute));
            return attributes.Length == 0 ? string.Empty : ((LoadingTextAttribute)attributes[0]).LoadingText;
        }


        private static object[] GetAttributesFromEnum(this Enum value, Type AttributeType)
            =>
            value.GetType().GetField(value.ToString()).GetCustomAttributes(AttributeType, false);
    }
}
