using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoUTN.Application.UseCases.Vender
{
   
        public interface IVenderUseCase
        {
            /// <summary>
            ///     Executes the Use Case.
            /// </summary>
            /// <param name="input">Input</param>
            /// <returns>Task.</returns>
            Task Execute(VenderInput input);

            /// <summary>
            ///     Sets the Output Port.
            /// </summary>
            /// <param name="outputPort">Output Port</param>
            void SetOutputPort(IOutputPort outputPort);
        }
    
}
