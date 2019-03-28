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
        const bool IgnoreCase = true;

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

        public bool ValidateStationDirection(string stationName, string direction)
        {
            DirectionToLine.Direction inputDirection;

            if (String.IsNullOrWhiteSpace(stationName))
            {
                throw new ArgumentException($"Invalid {nameof(stationName)}");
            }


            if (!Enum.TryParse(direction, IgnoreCase, out inputDirection))
            {
                throw new ArgumentException($"Invalid Direction {nameof(direction)}");
            }

            var station = stations.FirstOrDefault(s => (!String.IsNullOrEmpty(s.Name)
                                && s.Name.Equals(stationName, StringComparison.CurrentCultureIgnoreCase)));

            if (station == null)
                return false;

            List<string> lines = DirectionToLine.ConvertToLines(inputDirection);

            if (station.Line1 && lines.Contains("Line1"))
                return true;

            if (station.Line2 && lines.Contains("Line2"))
                return true;

            if (station.Line3 && lines.Contains("Line3"))
                return true;

            if (station.Line4 && lines.Contains("Line4"))
                return true;

            return false;
        }
    }
}
