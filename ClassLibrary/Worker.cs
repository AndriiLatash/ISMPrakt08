using System;

namespace ClassLibrary
{
    public class Worker
    {
        public string Name { set; get; }
        public string SecondName { set; get; }
        public string Patronymic { set; get; }
        public string DateOfEmployment { set; get; }
        public Job Job;
        public string Experience { set; get; }
        public string Education { set; get; }

        public Worker(string name, string secondName, string patronymic, string dateOfEmployment, Job job, string experience, string education)
        {
            Name = name;
            SecondName = secondName;
            Patronymic = patronymic;
            DateOfEmployment = dateOfEmployment;
            Job = new Job(job);
            Experience = experience;
            Education = education;
        }
        public Worker(Worker worker)
        {
            Name = worker.Name;
            SecondName = worker.SecondName;
            Patronymic = worker.Patronymic;
            DateOfEmployment = worker.DateOfEmployment;
            Job = worker.Job;
            Experience = worker.Experience;
            Education = worker.Education;
        }

        public string GetWorker()
        {
            return $"{Name} {SecondName} {Patronymic}\n Date of Employment : {DateOfEmployment}\n Job : \n{Job.GetJob()}\n {Experience}\n Education : {Education}";
        }

    }


}
