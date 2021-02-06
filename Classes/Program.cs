using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            Console.ReadLine();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Console.ReadLine();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.City = "İstanbul";
            customer.FirstName = "yaren";//değeri verdiğimizde buna Set bloğu denir
            customer.LastName = "zengin";

            Customer customer2 = new Customer { Id = 2 ,City = "Ankara",
             FirstName = "Engin" , LastName ="demiroğ"};

            Console.WriteLine(customer2.FirstName);//cust. adını al dediğimizde Get bloğu çalışıyor


        }
    }
    class CustomerManager
    {
        //bunu kullanmak için o class ın bir örneğini oluşturmak gerekir
       public void Add()
        {
            Console.WriteLine("customer added");

        }
        public void Update()
        {
            Console.WriteLine("customer updated");
        }
    }
    //gruplama yaptık
    class ProductManager
    {
        
        public void Add()
        {
            Console.WriteLine("customer added");

        }
        public void Update()
        {
            Console.WriteLine("customer updated");
        }
    }
}
