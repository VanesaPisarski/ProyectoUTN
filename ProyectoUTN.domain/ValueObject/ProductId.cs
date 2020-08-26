using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoUTN.Domain.ValueObject
{
    public class ProductId
    {
        public Guid Id { get; }

        public ProductId(Guid id) =>
               this.Id = id;

    }
}
