using BotFactory.Common.Interface;
using BotFactory.Common.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Factories
{
    public class FactoryQueueElement : IFactoryQueueElement
    {
        //Fields

        private string _Name;
        private string _Model;
        private Coordinates _ParkingPos;
        private Coordinates _WorkingPos;


        //Properties implementation      
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Model
        {
            get { return _Model; }
            set { _Model = value; }
        }
        public Coordinates ParkingPos
        {
            get { return _ParkingPos; }
            set { _ParkingPos = value; }
        }
        public Coordinates WorkingPos
        {
            get { return _WorkingPos; }
            set { _WorkingPos = value; }
        }



        //Constructor
        public FactoryQueueElement(string model, string name, Coordinates parkingPos, Coordinates workingPos)
        {
            Model = model;
            Name = name;
            ParkingPos = parkingPos;
            WorkingPos = workingPos;
        }
    }
}
