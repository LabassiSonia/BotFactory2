using System.Threading.Tasks;
using BotFactory.Common.Tools;

namespace BotFactory.Common.Interface
{ 
    public interface IBaseUnit : IReportingUnit
    {
        //Properties
        string Name { get; set; }
        double Speed { get; set; }
        Coordinates CurrentPos { get; set; }
        //Methods


    }

}
