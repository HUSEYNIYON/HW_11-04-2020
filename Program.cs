using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees emp=new Employees();
            
        }
    }
    class Employees
    {
        private int EmployeeID;
        public string LastName;
        public string FirstName;
        public string Title;
        public string TitleOfCourtesy;
        public int BirthDate;
        public DateTime Hire_date;

        public string Address;
        public Employees(int EmployeeID,string LastName, string FirstName, string Title, string 
        TitleOfCourtesy,int BirthDate,DateTime Hire_date,string Address)
        {
            this.EmployeeID=EmployeeID;
            this.LastName=LastName;
            this.FirstName=FirstName;
            this.Title=Title;
            this.TitleOfCourtesy=TitleOfCourtesy;
            this.BirthDate=BirthDate;
            this.Hire_date=Hire_date;
        }


    }
}
