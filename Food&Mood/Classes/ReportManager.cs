using System;
using System.Collections.Generic;
using System.IO;

namespace Food_Mood.Classes
{
    public static class ReportManager
    {
        public static List<Report> ReportList { get; set; } = new List<Report>();

        public static void AddReport(Report report) {  ReportList.Add(report); }

        public static void LoadReports() 
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string filePath = Path.Combine(baseDirectory, "Resources\\Report.csv");

            if (File.Exists(filePath))
            {

                using (var reader = new StreamReader(filePath))
                {
                    // Read and ignore the header row
                    string headerLine = reader.ReadLine();

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] values = line.Split(',');
                        var report = new Report(values[0], DateTime.Parse(values[1]), values[3], values[2], Convert.ToInt32(values[4]));
                        AddReport(report);
                    }
                }
            }
        }
    }
}
