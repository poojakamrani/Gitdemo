using System;
using System.Collections.Generic;
using System.Text;

namespace prjfirstapplication
{
    class organization
    {
        internal static string Orgname = "LTI";//static variable
        string city = "chennai";//non static variable
        internal static void GetOrgDetails()
        {
            Console.WriteLine(Orgname);
           // Console.WriteLine(city);//error static class can access static variable only
        }
    }
    class Employee
    {
        //property
        int Eid { get; set; }
        string? Empname { get;set; }
        string? Location { get; set; }
        int salary { get; set; }
        int Did { get;  }//read only property
        //constructor:used to intialize value for variable.here used for did
        Employee()
        {
            Did = 101;
        }
        //constructor overloading
        Employee(int Eid,string Empname,string Location,int sal)
        {
            //'this' represents current class instance(Employee)variable
            this.Eid = Eid;
            this.Empname = Empname;
            this.Location = Location;
            salary = sal;//since we have use diff name upar parameter mai toh 'this' nahi likha toh chalega
        }
        void DisplayEmployee(Employee emp)
        {
            Console.WriteLine("Eid:{0} || Empname:{1} || Location:{2} || salary:{3} || did:{4} || Orgname:{5}", Eid, Empname, Location, salary, emp.Did,organization.Orgname);
        }
        static void Main()
        {
            int Empid, Esalary;
            string Elocation, Ename;
            Employee employee = new Employee();
            //Property Output
            // employee.Eid=1001;
            // employee.Empname='xyz';
            //employee.Location='mum';
            //employee.salary=7600;
            //console.writeline("eid:{0} ename:{1} location:{2} salary:{3} did:{4}",employee.Eid,employee.Empname,employee.Location,employee.salary,employee.Did);

            //constructor
            Console.WriteLine("Enter the Eid");
            Empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name");
            Ename = Console.ReadLine();
            Console.WriteLine("Enter the Location");
            Elocation = Console.ReadLine();
            Console.WriteLine("Enter the salary");
            Esalary = Convert.ToInt32(Console.ReadLine());

            Employee employee1 = new Employee(Empid, Ename, Elocation, Esalary);
            employee1.DisplayEmployee(employee);//passing employee constructor has parameter so that did is displayed as 101 and not null

            //calling static method
            organization.GetOrgDetails();
        }
    }
}
