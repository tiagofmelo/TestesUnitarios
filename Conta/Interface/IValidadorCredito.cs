using System;
using System.Collections.Generic;
using System.Text;

namespace Principal
{
    public interface IValidadorCredito
    {
        bool ValidarCredito(string cpf, decimal valor);
    }
}
