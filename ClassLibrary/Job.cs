using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    class Job
    {
        public string CompanyName { set; get; }
        public Address Address;
        public int Salary { set; get; }
        public string WorkingHours { set; get; }

        public Job(string companyName, Address address, int salary, string workingHours)
        {
            CompanyName = companyName;
            Address = address;
            Salary = salary;
            WorkingHours = workingHours;

        }
        public Job(Job job)
        {

            CompanyName = job.CompanyName;
            Address = job.Address;
            Salary = job.Salary;
            WorkingHours = job.WorkingHours;
        }
        public string GetJob()
        {
            return $"Company name : {CompanyName}\n Address : {Address.GetAddress()}\n Salary {Salary} UAH\n Working hours : {WorkingHours}";
        }
    }
}
