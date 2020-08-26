using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoUTN.Application.UseCases.Vender
{
 
    public interface IOutputPort
    {
        /// <summary>
        ///     Invalid input.
        /// </summary>
        void Invalid(string message);

        /// <summary>
        ///     Deposited.
        /// </summary>
        void Ok(string message);

        /// <summary>
        ///     Not found.
        /// </summary>
        void NotFound();
    }
}
