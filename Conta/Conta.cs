namespace Principal
{
    public class Conta
    {
        private string cpf;
        private decimal saldo;

        public Conta (string cpf, decimal saldo)
        {
            this.cpf = cpf;
            this.saldo = saldo;
        }

        public bool Sacar(decimal valor)
        {
            if (saldo < valor) return false;

            this.saldo -= valor;

            return true;
        }
    }
}
