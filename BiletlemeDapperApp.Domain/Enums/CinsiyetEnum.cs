using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletlemeDapperApp.Domain.Enums
{
    public enum CinsiyetEnum
    {
        [Description("Erkek")]
        Male = 1,

        [Description("Kadın")]
        Female = 2,

        [Description("Belirtilmemiş")]
        NotSpecified = 3
    }
}
