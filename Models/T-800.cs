using BotFactory.Common.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Models
{
    public class T_800 : TestingUnit
    {
        public T_800(string name, Coordinates parkingPos, Coordinates workingPos) : base("T-800", name, parkingPos, workingPos, 3, 10)
        {
        }
        public override string ToString()
        {
            return "T_800";
        }
    }
}
