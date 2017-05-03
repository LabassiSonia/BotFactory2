using BotFactory.Common.Interface;
using BotFactory.Common.Tools;

namespace BotFactory.Models
{
   
    public abstract class ReportingUnit : BuildableUnit, IReportingUnit
    {

        //Fields

        private event UnitStatusChangedHandler _UnitStatusChanged;

        //Properties implementation
        public event UnitStatusChangedHandler UnitStatusChanged
        {
            add { _UnitStatusChanged += value; }
            remove { _UnitStatusChanged -= value; }
        }





        //Constructors and methods
        public ReportingUnit(string model, double buildTime = 5) : base(model, buildTime = 5)
        {

        }


        public virtual void OnStatusChanged(string NewStatus)
        {
            if (_UnitStatusChanged != null)
                _UnitStatusChanged(this, new StatusChangedEventArgs { NewStatus = NewStatus });

        }


    }
}
