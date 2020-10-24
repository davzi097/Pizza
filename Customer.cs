using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaUML2
{
    public class Customer
    {
        private int _id;
        private string _name;

        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }

        public override string ToString()
        {
            return Name + ", ID = " + Id;
        }
    }
}
