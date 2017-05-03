using BotFactory.Common.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Common.Interface
{
    public interface IUnitFactory
    {

        //Properties
        int QueueCapacity { get; }
        int StorageCapacity { get; }
        Queue<IFactoryQueueElement> Queue { get; set; }
        List<ITestingUnit> Storage { get; set; }
        TimeSpan QueueTime { get; set; }
        int QueueFreeSlots { get; set; }
        int StorageFreeSlots { get; set; }
        event FactoryStatusHandler FactoryStatus;



        //Methods
        bool AddWorkableUnitToQueue(Type model, string name, Coordinates parkingPos, Coordinates workingPos);
        void FactoryProgress(object bot);
    }
}  