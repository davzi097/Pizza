using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime;
using System.Configuration;

namespace PizzaUML2
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            CustomerSettings CustomerCode = new CustomerSettings();
            CustomerCode.CustomerCRUD();

            PizzaSettings PizzaCode = new PizzaSettings();
            PizzaCode.PizzaCRUD();
        }
    }
}
