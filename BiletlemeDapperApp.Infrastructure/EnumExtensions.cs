using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletlemeDapperApp.Infrastructure
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum e)
        {
            var enumType = e.GetType();
            var memberInfo = enumType.GetMember(e.ToString());
            var attributes = memberInfo[0].GetCustomAttributes(false);
            var description = string.Empty;
            if (attributes.Length > 0)
                description = ((DescriptionAttribute)attributes[0]).Description;

            return description;
        }
        public static List<SelectViewModel> GetEnumerations<T>()
        {
            var enumDetails = new List<SelectViewModel>();
            var type = typeof(T);
            var valuesAsArray = Enum.GetNames(type);
            foreach (var s in valuesAsArray)
            {
                var memInfo = type.GetMember(s);
                var attributes = memInfo[0].GetCustomAttributes(false);
                string description;
                if (attributes.Length > 0)
                    description = ((DescriptionAttribute)attributes[0]).Description;
                else
                    description = s;
                string value = ((int)Enum.Parse(type, s)).ToString();

                enumDetails.Add(new SelectViewModel { Text = description, Value = Convert.ToInt32(value) });
            }
            return enumDetails;
        }

    }
}
