using System;
using System.Collections.Generic;
using System.IO;

namespace Scheduler
{
    public class Utils
    {
        public static List<Station> LoadStations(string fileName)
        {
            List<Station> stations = new List<Station>();

            if(String.IsNullOrWhiteSpace(fileName))
            {
                throw new ArgumentException(nameof(fileName));
            }

            if(!File.Exists(fileName))
            {
                throw new FileNotFoundException(nameof(fileName));
            }

            return stations;
        }
    }
}