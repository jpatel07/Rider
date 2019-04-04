using System;
using System.Collections.Generic;
using System.IO;
using FileHelpers;
using System.Linq;

namespace Scheduler
{
    public class Utils
    {
        readonly static int Seconds = 0;
        public static List<Station> LoadStations(string filePath)
        {
            if (String.IsNullOrWhiteSpace(filePath))
            {
                throw new ArgumentException(nameof(filePath));
            }

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException(filePath);
            }

            return LoadCSVFile(filePath);
        }

        private static List<Station> LoadCSVFile(string csvFilePath)
        {
            try
            {
                var engine = new FileHelperEngine<Station>();
                var result = engine.ReadFile(csvFilePath);
                return result.ToList();
            }
            catch (Exception ex)
            {

                throw new Exception($"Failed to load {csvFilePath} : {ex.Message}");
            }
        }

        //For simply city next time arrive at next quarte of the hour
        public static TimeSpan GetNextTrainArrivalTime(int hour, int minute)
        {
            if (!ValidateHour(hour))
            {
                throw new ArgumentException(nameof(hour));
            }

            if (!ValidateMinutes(minute))
            {
                throw new ArgumentException(nameof(hour));
            }

            return (new TimeSpan(hour, minute, Seconds).RoundTo(15));
        }

        private static bool ValidateMinutes(int minute)
        {
            if (minute < 0 || minute > 59)
                return false;

            return true;
        }

        private static bool ValidateHour(int hour)
        {
            if (hour < 0 || hour > 24)
                return false;

            return true;

        }
    }
}