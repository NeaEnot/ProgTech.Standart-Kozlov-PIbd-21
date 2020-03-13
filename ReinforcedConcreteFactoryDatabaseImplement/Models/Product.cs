﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ReinforcedConcreteFactoryDatabaseImplement.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public decimal Price { get; set; }

        public virtual ProductComponent ProductComponent { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}
