namespace bytebank
{
    public class ContaCorrente
    {
        public string titular;
        public string conta;
        public int numeroAgencia;
        public string nomeAgencia;
        public double saldo;

        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;

            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                return true;
            }    
        }

        public void Depositar(double valor)
        {
            saldo = saldo + valor;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                destino.saldo = destino.saldo + valor;
                return true;
            }
        }

        public void ExibirDadosDaConta()
        {
            Console.WriteLine("Titular: " + titular);
            Console.WriteLine("Conta: " + conta);
            Console.WriteLine("Nome da Agência: " + nomeAgencia);
            Console.WriteLine("Número da Agência: " + numeroAgencia);
            Console.WriteLine("Saldo: " + saldo);
        }
    }   
}