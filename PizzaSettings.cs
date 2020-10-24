using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaUML2
{
    class PizzaSettings
    {
        public void PizzaCRUD()
        {
            List<Pizza> pizzas = new List<Pizza>();

            bool addPizza = false;
            Console.Write("Add Pizza? y/n");
            Console.WriteLine();
            if (Console.ReadLine() == "y")
                addPizza = true;

            int a = 1;

            while (addPizza == true)
            {

                Console.WriteLine("Write pizza name");
                pizzas.Add(new Pizza(a, Console.ReadLine()));
                a++;
                Console.Write("Add another? y/n");
                Console.WriteLine();

                if (Console.ReadLine() != "y")
                    addPizza = false;

            }

            PizzaList();

            bool updatePizza = false;
            Console.WriteLine("Change Pizza name? y/n");
            if (Console.ReadLine() == "y" && pizzas.Count > 0)
                updatePizza = true;
            else if (pizzas.Count == 0)
                Console.WriteLine("There are not any pizzas in the list");

            while (updatePizza == true)
            {

                Console.WriteLine("Write pizza ID");
                int b = int.Parse(Console.ReadLine()) - 1;

                pizzas.RemoveAt(b);
                Console.WriteLine("Write new name for your pizza");
                pizzas.Insert(b, new Pizza(b + 1, Console.ReadLine()));

                Console.Write("Update another? y/n");
                Console.WriteLine();

                if (Console.ReadLine() != "y")
                    updatePizza = false;

            }

            PizzaList();

            bool removePizza = false;
            Console.Write("Remove Pizza? y/n");
            Console.WriteLine();
            if (Console.ReadLine() == "y")
                removePizza = true;

            while (removePizza == true)
            {
                Console.WriteLine("Write pizza ID");
                int b = int.Parse(Console.ReadLine()) - 1;

                pizzas.RemoveAt(b);
                
                PizzaList();

                Console.Write("Remove another? y/n");
                Console.WriteLine();

                if (Console.ReadLine() != "y")
                    removePizza = false;
            }

            PizzaList();

            void PizzaList()
            {
                Console.WriteLine("List of Pizzas :");
                foreach (var v in pizzas)
                {
                    if (v.Id < 1000000)
                        Console.WriteLine(v);
                }
            }

        }
    }
}
