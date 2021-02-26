using System;

namespace DemoJobs
{
    class DemoJobs
    {
        static void Main(string[] args)
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Job job3 = new Job();

            job1.Description = "Dog Walker";
            job1.Hourly = 20;
            job1.Time = 5;

            job2.Description = "Cat Walker";
            job2.Hourly = 30;
            job2.Time = 7;

            DisplayJob(job1);
            DisplayJob(job2);
            job3 = job1 + job2;
            DisplayJob(job3);


        }
        public static void DisplayJob(Job j)
        {
            Console.WriteLine("{0} rate is {1:C} per an hour. \n" +
                "If done for {2} hours the Total is: {3:c}",
                j.Description, j.Hourly, j.Time, j.Total);
        }
    }
}
