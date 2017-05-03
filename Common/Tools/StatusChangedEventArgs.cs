using BotFactory.Common.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Common.Tools
{
    public class StatusChangedEventArgs : EventArgs, IStatusChangedEventArgs
    {
        private string _NewStatus;

        public string NewStatus
        {
            get { return _NewStatus; }
            set { _NewStatus = value; }
        }
       

    }
}
