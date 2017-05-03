using BotFactory.Common.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Common.Interface
{
    public interface IReportingUnit : IBuildableUnit
    {
        event UnitStatusChangedHandler UnitStatusChanged;
        void OnStatusChanged(string NewStatus);
    }
}
