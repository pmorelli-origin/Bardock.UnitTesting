﻿using System;
using System.Collections.Generic;

namespace Bardock.UnitTesting.Samples.SUT.Entities
{
    public class Order
    {
        public int ID { get; set; }

        public int CustomerID { get; set; }

        public Customer Customer { get; set; }

        public List<Product> Products { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}