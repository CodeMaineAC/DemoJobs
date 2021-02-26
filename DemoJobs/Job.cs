using System;
using System.Collections.Generic;
using System.Text;


namespace DemoJobs
{
    class Job
    {
        private string description;
        private double time;
        private double hourlyRate;
        private double total;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public double Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
                CalcTotal();
            }
        }

        public double Hourly
        {
            get
            {
                return hourlyRate;
            }
            set
            {
                hourlyRate = value;
                CalcTotal();
            }
        }

        public double Total
        {
            get { return total; }
        }

        private void CalcTotal()
        {
            total = Math.Round((time * hourlyRate), 2, MidpointRounding.AwayFromZero);
        }

        public static Job operator+(Job j1, Job j2)
        {
            Job j3 = new Job();

            j3.Description = j1.Description + " and " + j2.Description;
            j3.Time = j1.Time + j2.Time;
            j3.Hourly = (j1.Hourly + j2.Hourly) / 2; 

            return j3;
        }
    }
}
