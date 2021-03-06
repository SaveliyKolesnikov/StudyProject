﻿using StudyProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyProject.Domain.Entities
{
    public class Product: EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float Weight { get; set; }

        public ICollection<ClientProductValue> ClientsProductsValues { get; set; }

        public Product()
        {
            this.ID = Guid.NewGuid();
            this.DateModified = DateTime.Now;
            this.CreationDate = DateTime.Now;
            this.ClientsProductsValues = new HashSet<ClientProductValue>();
        }
    }
}