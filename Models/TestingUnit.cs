using BotFactory.Common.Interface;
using BotFactory.Common.Tools;

namespace BotFactory.Models
{
    public class TestingUnit : WorkingUnit, ITestingUnit
    {
        public TestingUnit(string model, string name, Coordinates parkingPos, Coordinates workingPos, double speed = 1, double buildTime = 5) : base(model, name, parkingPos, workingPos, speed, buildTime)
        {
        }
    }
}
