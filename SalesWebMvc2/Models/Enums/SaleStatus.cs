using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc2.Models.Enums
{
    public enum Status : int
    {
        Canceled = 0,
        Billed = 1,
        Shiped = 2
    }
}
