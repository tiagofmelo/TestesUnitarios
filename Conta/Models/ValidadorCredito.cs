using System;
using System.Collections.Generic;
using System.Text;

namespace Principal
{
    class ValidadorCredito : IValidadorCredito
    {
        private readonly string cpf;

        public ValidadorCredito(string cpf)
        {
            this.cpf = cpf;
        }

        public bool ValidarCredito(string cpf, decimal valor)
        {
            bool statusSerasa = VarificaSituacaoSerasa(cpf);
            bool statusSPC = VarificaSituacaoSPC(cpf);

            return (statusSerasa && statusSPC);
        }

        private bool VarificaSituacaoSPC(string cpf)
        {
            //chamada a um webservice
            return true;
        }

        private bool VarificaSituacaoSerasa(string cpf)
        {
            //chamada a um webservice
            return true;
        }
    }
}
