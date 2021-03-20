using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace TTConfTool.Shared.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum value)
        {
            var member = value.GetType().GetMember(value.ToString())[0];
            var displayAttribute = member.GetCustomAttribute<DisplayAttribute>();

            if (displayAttribute != null)
                return displayAttribute.GetName();

            return value.ToString();
        }
    }
}
