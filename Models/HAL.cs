using BotFactory.Common.Tools;

namespace BotFactory.Models
{
    public class HAL : TestingUnit
    {
        public HAL(string name, Coordinates parkingPos, Coordinates workingPos) : base("HAL", name, parkingPos, workingPos, 0.5, 7)
        {
        }

        public override string ToString()
        {
            return "HAL";
        }
    }
}
