using System;
using System.Collections.Generic;
using System.Text;

namespace Principal
{
    public class ValidadorCreditoFake : IValidadorCredito
    {
        public bool ValidarCredito(string cpf, decimal valor)
        {
            //Não acessa nenhum webservice
            return true;
        }
    }
}
