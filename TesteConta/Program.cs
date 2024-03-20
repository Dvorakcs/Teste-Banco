
class ContaTeste
{
    static void Main(string[] args)
    {
        TesteContaSacar();
        TesteContaSacarSemSaldo();
    }

    private static void TesteContaSacarSemSaldo()
    {
        //arrange
        var conta = new Conta("0001", 0);
        bool resultadoEsperado = false;

        //act
        bool resultado = conta.Sacar(50);

        //assert
        if (resultado == resultadoEsperado)
        {
            Console.WriteLine("TestarContaSacar: Success");
        }
        else
        {
            Console.WriteLine("TestarContaSacar: Failled");
        }
    }

    private static void TesteContaSacar()
    {
        var conta = new Conta("0001", 100);
        bool resultadoEsperado = true;

        bool resultado = conta.Sacar(50);

        if(resultado == resultadoEsperado)
        {
            Console.WriteLine("TestarContaSacar: Success");
        }
        else
        {
            Console.WriteLine("TestarContaSacar: Failled");
        }
    }
}