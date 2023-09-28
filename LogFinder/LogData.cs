using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAnalyzer
{
    public class LogData
    {
        public string dateLog;
        public string timeLog;
        public string typeLog;
        public string packageLog;
        public string infoLog;
        public string changedInfoLog;
        public string stackLog;


        public LogData()
        {

        }
        public LogData(string dateLog, string timeLog, string typeLog, string packageLog, string infoLog, string stackLog, string changedInfoLog)
        {
            this.dateLog = dateLog;
            this.timeLog = timeLog;
            this.typeLog = typeLog;
            this.packageLog = packageLog;
            this.infoLog = infoLog;
            this.stackLog = stackLog;
            this.changedInfoLog = changedInfoLog;
        }

        
    }
}
