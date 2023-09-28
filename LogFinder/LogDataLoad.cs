using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static LogAnalyzer.DataSet1;
using static LogAnalyzer.DataSet2;
using Newtonsoft.Json;


namespace LogAnalyzer
{
    class LogDataLoad
    {
        DataRow row;
        public event EventHandler<ProgressEventArgs> ProgressEvent;
        /*LogData _logData = new LogData();

        public LogData logData
        {
            get { return _logData; }
        }
        */
        string pattern = @"^(\d{2}-\d{2}-\d{4}) (\d{2}:\d{2}:\d{2},\d{3}) (\w+) \[\]:\d+ ([\w.]+) - (.*$)";
        

        public string ReplaceInfoLog(string strReplace)
        {
            string s1 = Regex.Replace(strReplace, @"\[(\d+)\]", "[XXX]");
            string s2 = Regex.Replace(s1, @"(?i)ID: \d+", "ID: XXX");
            string s3 = Regex.Replace(s2, @"(?i)Code: \d+", "Code: XXX");
            string s4 = Regex.Replace(s3, @"\[[^\]]+\]", "[XXX]");
            string s5 = Regex.Replace(s4, @"'(\d+\,\d+)'", "'XXX'");
            string s6 = Regex.Replace(s5, @"(?i)number: '[\d+,]'", "number: 'XXX'");
            string s7 = Regex.Replace(s6, @"(@.{0,7})\w", "$XXX");
            string s8 = Regex.Replace(s7, @"Too many records returned by the query:(.*)", "Too many records returned by the query: XXX");
            string s9 = Regex.Replace(s8, @"REPORTS-INTERRUPTED-POSTFUNCTIONS D&T:(.*)", "REPORTS-INTERRUPTED-POSTFUNCTIONS D&T: XXX");
            string s10 = Regex.Replace(s9, @"boundary=""[^""]+""", "boundary=\"XXX\"");
            string s11 = Regex.Replace(s10, @"(?m)^\s*$\n?", string.Empty);

            return s11;
        }

        public Dictionary<string, List<LogData>> Load(string path)
        {
            string[] fileEntries = Directory.GetFiles(path);
            
            //allLogsDataTable allLogsTable = new allLogsDataTable();
            List<LogData> logs = new List<LogData>();
            Dictionary<string, List<LogData>> errorsDictionary = new Dictionary<string, List<LogData>>();
            int file1;
            int file2;

            foreach (string fileName in fileEntries)
            {
                //OnRaiseProgressEvent(new ProgressEventArgs(100 / fileEntries.Length));
                OnRaiseProgressEvent(new ProgressEventArgs(100 / fileName.Length));
                string[] lines = File.ReadAllLines(fileName);
                //file1 = fileEntries[0].Length;
                //file2 = fileEntries[1].Length;

                StringBuilder stackStringBuilder = new StringBuilder();
                int linesLength = lines.Length;



                for (int i = 0; i < linesLength; i++)
                {
                    string line = lines[i];
                    string replacedLine = ReplaceInfoLog(line);
                    Match match1 = Regex.Match(replacedLine, pattern);
                    Match match2 = Regex.Match(line, pattern);

                    if (match1.Success)
                    {
                        string dateLog = match1.Groups[1].Value;
                        string timeLog = match1.Groups[2].Value;
                        string typeLog = match1.Groups[3].Value;
                        string packageLog = match1.Groups[4].Value;
                        string infoLogForKey = match1.Groups[5].Value;
                        string infoLog = match2.Groups[5].Value;
                        string stackLog = "";
                        LogData logData = new LogData(dateLog, timeLog, typeLog, packageLog, infoLog, stackLog, infoLogForKey);
                        logs.Add(logData);

                        //while (i + 1 < linesLength && !Char.IsDigit(lines[i +1][0]))
                        //{
                        //    LogData lastLog = logs.Last();
                        //    //if (string.IsNullOrEmpty(lines[i + 1]))
                        //    //{
                        //    //    i += 1;
                        //    //    continue;
                        //    //}
                        //    stackStringBuilder.AppendLine().Append(lines[i + 1]);
                        //    i += 1;
                        //    lastLog.stackLog = stackStringBuilder.ToString();
                        //}

                        string key = logData.typeLog + " " + logData.packageLog + " " + infoLogForKey;
                        if (errorsDictionary.ContainsKey(key))
                        {
                            errorsDictionary[key].Add(logData);
                        }
                        else
                        {
                            List<LogData> newLogs = new List<LogData>();
                            newLogs.Add(logData);
                            errorsDictionary.Add(key, newLogs);
                        }

                    }   
                }
            }

            return errorsDictionary;
        }
        protected virtual void OnRaiseProgressEvent(ProgressEventArgs e)
        {
            ProgressEvent?.Invoke(this, e);
        }

    }
}
