using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletlemeDapperApp.Domain.Enums
{
    public enum DurumEnum
    {
        [Description("Aktif")]
        Active = 1,

        [Description("Pasif")]
        Passive = 2
    }
}
