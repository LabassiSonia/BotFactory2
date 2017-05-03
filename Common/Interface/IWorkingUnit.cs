using BotFactory.Common.Tools;
using System.Threading.Tasks;

namespace BotFactory.Common.Interface
{
    public interface IWorkingUnit : IBaseUnit
    {
        //Properties
        Coordinates ParkingPos { get; set; }
        Coordinates WorkingPos { get; set; }
        bool IsWorking { get; set; }
        


        //Methods
        Task<bool> WorkBegins();
        Task<bool> WorkEnds();

    }
}
