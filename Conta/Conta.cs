
    public class Conta
    {
        private string cpf;
        private decimal saldo;
        public Conta(string cpf, decimal saldo)
        {
            this.cpf = cpf;
            this.saldo = saldo;

        }

        public decimal GetSaldo()
        {
            return saldo;
        }

        public void Depositar(decimal saldo)
        {
            this.saldo += saldo;
        }

        public bool Sacar(decimal valor)
        {
            if(valor > this.saldo)
            {
               return false;
            }
              this.saldo -= saldo;
              return true;
        
        }
    }

