using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added.");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted.");
        }

        public void Update()
        {
            Console.WriteLine("Sql UPDATED.");
        }
    }

    class OracleServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added.");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted.");
        }

        public void Update()
        {
            Console.WriteLine("Oracle UPDATED.");
        }

    }

    class MySqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql added.");
        }

        public void Delete()
        {
            Console.WriteLine("MySql Deleted.");
        }

        public void Update()
        {
            Console.WriteLine("MySql UPDATED.");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
