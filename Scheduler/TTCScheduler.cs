using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    public class TTCScheduler
    {
        List<Station> stations = new List<Station>();
        string fileName = "";

        public TTCScheduler()
        {
            stations = Utils.LoadStations(fileName);
        }
        public void CatchNextTrain(string stationName, DateTime currenttime)
        {
            throw new NotImplementedException();
        }

        public bool ValidateStation(string stationName)
        {
            var station = stations.FirstOrDefault(s => (!String.IsNullOrEmpty(s.Name)
                                && s.Name.Equals(stationName)));
            if (station == null)
                return false;
            else
                return true;
        }
    }
}
