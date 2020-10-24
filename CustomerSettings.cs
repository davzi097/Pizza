using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaUML2
{
    class CustomerSettings
    {
        public void CustomerCRUD()
        {
            List<Customer> customers = new List<Customer>();
            
            bool addCustomer = false;
            Console.Write("Add Customer? y/n");
            Console.WriteLine();
            if (Console.ReadLine() == "y")
                addCustomer = true;

            int a = 1;

            while (addCustomer == true)
            {

                Console.WriteLine("Write his name");
                customers.Add(new Customer(a, Console.ReadLine()));
                a++;
                Console.Write("Add another? y/n");
                Console.WriteLine();

                if (Console.ReadLine() != "y")
                    addCustomer = false;

            }

            CustomerList();

            bool updateCustomer = false;
            Console.WriteLine("Change customer name? y/n");
            if (Console.ReadLine() == "y" && customers.Count > 0)
                updateCustomer = true;
            else if (customers.Count == 0)
                Console.WriteLine("There are not any customers in the list");

            while (updateCustomer == true)
            {

                Console.WriteLine("Write his his ID");
                int b = int.Parse(Console.ReadLine()) - 1;

                customers.RemoveAt(b);
                Console.WriteLine("Write his new name");
                customers.Insert(b, new Customer(b + 1, Console.ReadLine()));

                Console.Write("Update another? y/n");
                Console.WriteLine();

                if (Console.ReadLine() != "y")
                    updateCustomer = false;

            }

            CustomerList();

            bool removeCustomer = false;
            Console.Write("Remove Customer? y/n");
            Console.WriteLine();
            if (Console.ReadLine() == "y")
                removeCustomer = true;

            while(removeCustomer == true)
            {
                Console.WriteLine("Write his his ID");
                int b = int.Parse(Console.ReadLine()) - 1;
                
                customers.RemoveAt(b);

                CustomerList();

                Console.Write("Remove another? y/n");
                Console.WriteLine();

                if (Console.ReadLine() != "y")
                    removeCustomer = false;
            }

            CustomerList();

            void CustomerList()
            {
                Console.WriteLine("List of Customers :");
                foreach (var v in customers)
                {
                    if (v.Id < 1000000)
                        Console.WriteLine(v);
                }
            }
           
        }
    }
}
