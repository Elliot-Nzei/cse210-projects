using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Team Leader";
        job1._statrYear = 2002;
        job1._endYear =  2008;

        job1.Display();


        Job job2 = new Job();
        job2._company = "Amazon";
        job2._jobTitle = "Manager";
        job2._statrYear = 2012;
        job2._endYear =  2008;

        job2.Display();

        Resume myResume = new Resume();
        myResume._name = "First Employee";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}