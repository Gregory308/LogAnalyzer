using DevExpress.XtraGrid.Views.Grid;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LogAnalyzer.DataSet1;
using static LogAnalyzer.DataSet2;

namespace LogAnalyzer
{
    public partial class Form1 : Form
    {
        private FolderBrowserDialog chooseFolder;
        LogsDataTable logsTable;
        private static string path;
        LogDataLoad logDataLoad;
        public Dictionary<string, List<LogData>> errorsDictionary;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chooseDirectoryButton_Click(object sender, EventArgs e)
        {
            chooseFolder = new FolderBrowserDialog();
            if (chooseFolder.ShowDialog() == DialogResult.OK)
            {
                //path = chooseFolder.SelectedPath;
                path = "C:\\Repo\\lg";
                pathTextBox.Text = path;
                pathTextBox.Visible = true;
                pathLabel.Visible = true;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dataSet1.Logs.Clear();
                // Setting to fast debug
                path = "C:\\Repo\\Projekt2\\loggss";
                pathTextBox.Text = path;
                pathTextBox.Visible = true;
                pathLabel.Visible = true;
                LogDataLoad logDataLoad = new LogDataLoad();
                errorsDictionary = logDataLoad.Load(path);
                logsTable = getDataMain();
                dataSet1.Logs.Merge(logsTable);
                dataGridView1.DataSource = dataSet1.Logs;
                logDataLoad.ProgressEvent += ProgressEventHandler;
                numberTextbox.Text = logsTable.Rows.Count.ToString();
                numberTextbox.Visible = true;
                loadProgressBar.Value = 100;
                loadProgressBar.Visible = true;

                
            }
            catch (Exception ex)
            {
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(ex.Message, caption, buttons);
            }

        }

        private void saveToJsonButton_Click(object sender, EventArgs e)
        {
            string filePathJson = "C:\\Repo\\Projekt2\\loggss\\test.json";
            string json = JsonConvert.SerializeObject(logsTable, Formatting.Indented);
            File.WriteAllText(filePathJson, json);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            pathTextBox.Clear();
            loadProgressBar.Value = 0;
            dataSet1.Logs.Clear();
            numberTextbox.Clear();
        }
        /*
        private void OpenNewForm(string cellValue)
        {
            // Otwarcie nowego formularza Form2 i przekazanie wartości komórki
            LogForm logForm = new LogForm(cellValue);
            logForm.ShowDialog();
        }
        */
        private void dataGridView1_DoubleClick(object sender, System.EventArgs e)
        {
            //string key = logData.typeLog + " " + logData.packageLog + " " + infoLogForKey;
            GridView view = sender as GridView;
            int idx = this.gridView1.GetSelectedRows().ElementAt((0));
            //DataRow row = gridView1.GetRowCellValue;
            gridView1.SelectRow(gridView1.FocusedRowHandle);
            LogForm form2 = new LogForm(errorsDictionary.ElementAt(idx + 1));
            form2.Show();
        }

        public LogsDataTable getDataMain()
        {
            string pattern2 = @"^(\w+)\s+(\S+)\s+(.+)$";
            LogsDataTable logsTable = new LogsDataTable();
            foreach (KeyValuePair<string, List<LogData>> row in errorsDictionary)
            {
                Match match3 = Regex.Match(row.Key, pattern2);
                if (match3.Success)
                {
                    LogsRow newRow = logsTable.NewLogsRow();
                    newRow.typeLog = match3.Groups[1].Value;
                    newRow.packageLog = match3.Groups[2].Value;
                    newRow.infoLog = match3.Groups[3].Value;
                    newRow.countLog = row.Value.Count.ToString();
                    logsTable.AddLogsRow(newRow);
                }
            }
            return logsTable;
        }

        private void ProgressEventHandler(object sender, ProgressEventArgs e)
        {
            loadProgressBar.Value += e.Progress;
        }
    }
}
