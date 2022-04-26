using System.ComponentModel;
using System.Reflection;

namespace AntDesignExample.Helpers
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum genericEnum)
        {
            Type genericEnumType = genericEnum.GetType();
            MemberInfo[] memberInfo = genericEnumType.GetMember(genericEnum.ToString());
            if (memberInfo != null && memberInfo.Length > 0)
            {
                var attribs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attribs != null && attribs.Count() > 0)
                {
                    return ((DescriptionAttribute)attribs.ElementAt(0)).Description;
                }
            }

            return genericEnum.ToString();
        }
    }
}
