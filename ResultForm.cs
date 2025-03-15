using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSSS_LV1
{
    public partial class ResultForm : Form
    {
        MainForm mainForm;
        private int criticalValue;

        System.Timers.Timer timer;
        StreamReader streamReader;

        public ResultForm(MainForm mainForm, int criticalValue, string filePath)
        {
            this.mainForm = mainForm;
            this.criticalValue = criticalValue;

            timer = new(1000);
            timer.Elapsed += new System.Timers.ElapsedEventHandler(PeriodicallyReadFile);
            timer.Start();

            streamReader = new(filePath);

            InitializeComponent();
        }

        void ResultForm_Closing(object sender, FormClosingEventArgs e)
        {
            streamReader.Close();
            mainForm.Show();
        }

        void PeriodicallyReadFile(object? s, EventArgs e)
        {

            Invoke((MethodInvoker)delegate
            {
                string? line = streamReader.ReadLine();
                if (line == null)
                    return;

                if (!int.TryParse(line, out int value))
                    return;

                this.AllResultsTextBox.Text += $"{value}\r\n";

                if (value >= criticalValue)
                    this.CriticalValueResultsTextBox.Text += $"{value}\r\n";
            });
        }
    }
}
