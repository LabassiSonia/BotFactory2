using BotFactory.Common.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Models
{
    public class Wall_E : TestingUnit
    {
        public Wall_E(string name, Coordinates parkingPos, Coordinates workingPos) : base("Wall-E", name, parkingPos, workingPos, 2, 4)
        {
        }
        public override string ToString()
        {
            return "Wall-E";
        }
    }
}
