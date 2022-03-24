using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace NodorumSolutio.ApplicationFramework.Demos.ViewInjectionDemo
{
    class Customer
    {
        public Customer()
            : this(string.Empty)
        {
        }

        public Customer(string name)
        {
            _name = name;
            _orders = new OrderList();
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private OrderList _orders;

        public OrderList Orders
        {
            get { return _orders; }
        }

    }

    class OrderList : List<Order>
    {
    }
}
