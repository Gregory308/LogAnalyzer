using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAnalyzer
{
    class ProgressEventArgs : EventArgs
    {
        public int Progress { get; set; }
        public ProgressEventArgs(int progress)
        {
            Progress = progress;
        }
    }
}
