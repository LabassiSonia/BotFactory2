using BotFactory.Common.Interface;
using BotFactory.Common.Tools;
using System.Threading.Tasks;

namespace BotFactory.Models
{
    public abstract class WorkingUnit : BaseUnit, IWorkingUnit
    {

        //Fields
        private Coordinates _ParkingPos;
        private Coordinates _WorkingPos;
        private bool _IsWorking;
       


        //Properties implementation
        public bool IsWorking
        {
            get { return _IsWorking; }
            set { _IsWorking = value;
                if(_IsWorking)
                    OnStatusChanged("WorkBegins");
                else
                    OnStatusChanged("WorkEnd");
            }
        }
        public Coordinates WorkingPos
        {
            get { return _WorkingPos; }
            set { _WorkingPos = value; }
        }
        public Coordinates ParkingPos
        {
            get { return _ParkingPos; }
            set { _ParkingPos = value; }
        }



        //Constructors and methods
        public WorkingUnit(string model, string name, Coordinates parkingPos, Coordinates workingPos, double speed = 1, double buildTime = 5) : base(model, name, speed, buildTime)
        {
            ParkingPos = parkingPos;
            WorkingPos = workingPos;
        }

        public virtual async Task<bool> WorkBegins()
        {
            
            //When Reached returns true, the robot should be in the WorkingPos
            IsWorking = await Reached(WorkingPos);
            return true;
        }

        public virtual async Task<bool> WorkEnds()
        {   
            //when Reached returns true, it means that the robot has reached the parking position, in other words the robot is no longer working
            IsWorking = !await Reached(ParkingPos);
            return true;
        }

        private async Task<bool> Reached(Coordinates Position)
        {
            //The position Contains either the ParkingPos or the WorkingPos
            //The move async will return the position reached, so we just have to compare them 
            return (Position.Equals(await Move(Position)));
        }

        public override void OnStatusChanged(string NewStatus)
        {
            base.OnStatusChanged(NewStatus);

        }

    }
}
