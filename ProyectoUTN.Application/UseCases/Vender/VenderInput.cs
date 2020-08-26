using System;
using System.Collections.Generic;
using System.Text;
using ProyectoUTN.Domain.ValueObject;

namespace ProyectoUTN.Application.UseCases.Vender
{
    public class VenderInput
    {
        internal ProductId AccountId { get; }

        public VenderInput(Guid accountId, decimal amount)
        {



            if (accountId != Guid.Empty)
            {
                this.AccountId = new ProductId(accountId);
            }
            else
            {
                //this.ModelState.Add(nameof(accountId), "AccountId is required.");
            }
        }
    }
}
