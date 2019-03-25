using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    public class TTCScheduler
    {
        List<Station> stations = new List<Station>();
        string fileName = "stationsmasterdata.csv";
        string baseDir = AppDomain.CurrentDomain.BaseDirectory;

        public TTCScheduler()
        {
            string filePath = Path.Combine(baseDir, fileName);
            stations = Utils.LoadStations(filePath);
        }
        public void CatchNextTrain(string stationName, DateTime currenttime)
        {
            throw new NotImplementedException();
        }

        public bool ValidateStation(string stationName)
        {
            var station = stations.FirstOrDefault(s => (!String.IsNullOrEmpty(s.Name)
                                && s.Name.Equals(stationName, StringComparison.CurrentCultureIgnoreCase)));
            if (station == null)
                return false;
            else
                return true;
        }
    }
}
