using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.Data
{
    public class DummyDataAccess : IDummyDataAccess
    {
        public int age;
        public DummyDataAccess()
        {
            Random rnd = new Random();
            age = rnd.Next(1, 10);
        }

        public int GetUserAge()
        {
            return age;
        }
    }
}
