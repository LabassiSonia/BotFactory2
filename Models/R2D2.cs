using BotFactory.Common.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Models
{
    public class R2D2 : TestingUnit
    {
        public R2D2(string name, Coordinates parkingPos, Coordinates workingPos) : base("R2D2", name, parkingPos, workingPos, 1.5, 5.5)
        {
        }

        public override string ToString()
        {
            return "R2D2";
        }
    }
}
