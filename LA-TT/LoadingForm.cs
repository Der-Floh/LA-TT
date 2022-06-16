using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LA_TT
{
    public partial class LoadingForm : Form
    {
        private BackgroundWorker backgroundWorkerTop;
        private BackgroundWorker backgroundWorkerBottom;
        public int currPercentageTop { get; set; }
        public int currPercentageBottom { get; set; }
        public string currTextTop { get; set; }
        public string currTextBottom { get; set; }
        public bool finished { get; set; }

        public LoadingForm()
        {
            InitializeComponent();

            backgroundWorkerTop = new BackgroundWorker();

            backgroundWorkerTop.DoWork += BackgroundWorkerTop_DoWork;
            backgroundWorkerTop.ProgressChanged += BackgroundWorkerTop_ProgressChanged;
            backgroundWorkerTop.RunWorkerCompleted += BackgroundWorkerTop_Completed;

            backgroundWorkerTop.WorkerReportsProgress = true;
            backgroundWorkerTop.WorkerSupportsCancellation = true;

            backgroundWorkerBottom = new BackgroundWorker();

            backgroundWorkerBottom.DoWork += BackgroundWorkerBottom_DoWork;
            backgroundWorkerBottom.ProgressChanged += BackgroundWorkerBottom_ProgressChanged;
            backgroundWorkerBottom.RunWorkerCompleted += BackgroundWorkerBottom_Completed;

            backgroundWorkerBottom.WorkerReportsProgress = true;
            backgroundWorkerBottom.WorkerSupportsCancellation = true;
        }

        private void BackgroundWorkerTop_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            TopLoadingBar.Value = e.ProgressPercentage;
            TopLoadingBarLabel.Text = currTextTop;

            TopLoadingBar.Refresh();
            TopLoadingBarLabel.Refresh();
        }

        private void BackgroundWorkerTop_Completed(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void BackgroundWorkerTop_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!finished)
            {
                if (backgroundWorkerTop.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                Thread.Sleep(100);
                backgroundWorkerTop.ReportProgress(currPercentageTop);
            }
        }

        private void BackgroundWorkerBottom_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            BottomLoadingBar.Value = e.ProgressPercentage;
            BottomLoadingBarLabel.Text = currTextBottom;

            BottomLoadingBar.Refresh();
            BottomLoadingBarLabel.Refresh();
        }

        private void BackgroundWorkerBottom_Completed(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void BackgroundWorkerBottom_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!finished)
            {
                if (backgroundWorkerTop.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                Thread.Sleep(100);
                backgroundWorkerBottom.ReportProgress(currPercentageBottom);
            }
        }

        public void StartBackgroundWorkers()
        {
            backgroundWorkerTop.RunWorkerAsync();
            backgroundWorkerBottom.RunWorkerAsync();
        }
    }
}
