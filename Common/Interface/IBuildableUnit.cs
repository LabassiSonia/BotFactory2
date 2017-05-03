using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Common.Interface
{
    public interface IBuildableUnit
    {
        //Properties
        double BuildTime { get; set; }
        string Model { get; set; }
    }
}
