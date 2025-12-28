using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalAvoda
{
    using System;

    public class TemperatureChangedEventArgs : EventArgs
    {
        public double CurrentTemperature { get; }
        public DateTime TimeMeasured { get; }

        public TemperatureChangedEventArgs(double currentTemperature, DateTime timeMeasured)
        {
            CurrentTemperature = currentTemperature;
            TimeMeasured = timeMeasured;
        }
    }
}
