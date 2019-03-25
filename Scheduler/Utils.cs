using System;
using System.Collections.Generic;
using System.IO;
using FileHelpers;
using System.Linq;

namespace Scheduler
{
    public class Utils
    {
        public static List<Station> LoadStations(string filePath)
        {
            if (String.IsNullOrWhiteSpace(filePath))
            {
                throw new ArgumentException(nameof(filePath));
            }

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException(nameof(filePath));
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
    }
}