using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonManager personManager = new PersonManager();
            //Customer customer = new Customer();
            //customer.FirstName = "yaren";
            //personManager.Add(customer);
            //Student student = new Student();
            //student.FirstName = "yeşim";
            //personManager.Add(student);

            //IPerson person = new Customer();

            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new SqlServerCustomerDal());

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(), new OracleCustomerDal()
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();

            }


            Console.ReadLine();

        }
    }
    interface IPerson//soyut nesne - new'lenemez 
    {
         int Id { get; set; }
        string FirstName{ get; set; }
        string LastName { get; set; }


    }
    class Customer : IPerson
    {
        public int Id { get; set ; }
        public string FirstName { get ; set ; }
        public string LastName { get ; set ; }
        public string Address { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get ; set ; }
        public string FirstName { get ; set; }
        public string LastName { get ; set ; }
        public string Department{ get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
