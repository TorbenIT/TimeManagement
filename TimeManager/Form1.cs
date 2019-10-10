using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace TimeManager
{
    public partial class Form1 : Form
    {
        static Timer clockTimer = new Timer();
        static Timer alarmTimer = new Timer();

        SoundPlayer soundMarrika = new SoundPlayer(@"E:\Informatik\Software\C#\Windows Forms\TimeManager\TimeManager\bin\Debug\marika.wav");
        SoundPlayer soundPappe = new SoundPlayer(@"E:\Informatik\Software\C#\Windows Forms\TimeManager\TimeManager\bin\Debug\pappe.wav");

        public Form1()
        {
            InitializeComponent();

            numericUpDownHours.Value = DateTime.Now.Hour;
            numericUpDownHours.Maximum = 23;
            numericUpDownHours.Minimum = 0;

            numericUpDownMinutes.Value = DateTime.Now.Minute;
            numericUpDownMinutes.Maximum = 59;
            numericUpDownMinutes.Minimum = 0;
        }


        private void beeendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clockTimer.Interval = 1000;

            clockTimer.Tick += new
                                EventHandler(clockTimer_Check);

            clockTimer.Start();
        }

        private void clockTimer_Check(object sender, EventArgs e)
        {
            string currentTime = Convert.ToString(DateTime.Now.Hour + ":" +
                DateTime.Now.Minute + ":" + DateTime.Now.Second
            );

            labelTime.Text = currentTime;
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            DateTime datetime = new DateTime(dateTimePicker.Value.Year,
                                             dateTimePicker.Value.Month,
                                             dateTimePicker.Value.Day,
                                             Convert.ToInt32(numericUpDownHours.Value),
                                             Convert.ToInt32(numericUpDownMinutes.Value),
                                             Convert.ToInt32(DateTime.Now.Second));

            if (datetime <= DateTime.Now)
            {
                MessageBox.Show("Dieser Zeitpunkt liegt in der Vergangenheit. Entweder" +
                    "Sie fangen früher zu arbeiten an oder hören später auf.");
            }
            else
            {
                alarmTimer.Interval = 1000;

                alarmTimer.Tick += new EventHandler(alarmTimer_check);

                alarmTimer.Start();
            }
        }

        private void alarmTimer_check(object sender, EventArgs e)
        {
            string systemTime = Convert.ToString(DateTime.Now.Hour +
                                            ":" + DateTime.Now.Minute);

            string endWorkTime =
                Convert.ToString(numericUpDownHours.Value + ":" +
                    numericUpDownMinutes.Value);

            labelInfo.Text =
                "Um " + endWorkTime + " Uhr endet deine festgelegte Arbeitszeit für heute.";

            if (systemTime == endWorkTime)
            {
                labelInfo.Text = "Du hast deine festgelegte Arbeitszeit abgearbeitet...";

                if (radioButtonMarrika.Checked)
                {
                    soundMarrika.Play();
                }
                else
                {
                    soundPappe.Play();
                }
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            labelInfo.Text = "";

            alarmTimer.Stop();

            if (radioButtonMarrika.Checked)
            {
                soundMarrika.Stop();
            }
            else
            {
                soundPappe.Stop();
            }
        }
    }
}
