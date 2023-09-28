using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LogAnalyzer.DataSet2;

namespace LogAnalyzer
{
    public partial class LogForm : Form
    {
        KeyValuePair<string, List<LogData>> errorsDictionary;
        public LogForm(KeyValuePair<string, List<LogData>> errorsDictionary)
        {
            this.errorsDictionary = errorsDictionary;
            
            InitializeComponent();
            dataSet2.allLogs.Merge(getDataMain());
            gridControl1.DataSource = dataSet2.allLogs;
            //gridView1.RowClick += gridView1_RowClick;
        }

        public allLogsDataTable getDataMain()
        {
            //string pattern2 = @"^(\w+)\s+(\S+)\s+(.+)$";
            allLogsDataTable logsTable = new allLogsDataTable();
            errorTextbox.Text = errorsDictionary.Key;
            foreach (LogData row in errorsDictionary.Value)
            {
                //Match match3 = Regex.Match(row.Key, pattern2);
                allLogsRow newRow = logsTable.NewallLogsRow();
                newRow.dateLog = row.dateLog;
                newRow.timeLog = row.timeLog;
                newRow.typeLog = row.typeLog;
                newRow.packageLog = row.packageLog;
                newRow.infoLog = row.infoLog;
                newRow.stackLog = row.stackLog;
                logsTable.AddallLogsRow(newRow);
            }
            return logsTable;
        }
    }
}
