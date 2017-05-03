using System;
using System.Threading.Tasks;
using BotFactory.Common.Interface;
using BotFactory.Common.Tools;

namespace BotFactory.Models
{
    public abstract class BaseUnit : ReportingUnit, IBaseUnit
    {

        //Fields
        private string _Name;
        private double _Speed;
        private Coordinates _CurrentPos;



        //Properties implementation
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public Coordinates CurrentPos
        {
            get { return _CurrentPos; }
            set
            {
                _CurrentPos.X = 0;
                _CurrentPos.Y = 0;
            }
        }
        public double Speed
        {
            get { return _Speed; }
            set { _Speed = value; }
        }


        //Constructors & methods
        public BaseUnit(string model, string name, double speed = 1, double buildTime = 5) : base(model, buildTime)
        {
            Name = name;
            Speed = speed;
        }

        //Permet de faire bouger le rebot tout en respectant le temps de dépplacement nécessaire   
        public async Task<Coordinates> Move(Coordinates arrival)
        {
            int time = Convert.ToInt32(Math.Round(new Vector().Length(Vector.FromCoordinates(CurrentPos, arrival)) * Speed));
            await Task.Delay(time * 1000);
            CurrentPos = arrival;
            return arrival;
        }




    }
}
