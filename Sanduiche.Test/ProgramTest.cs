namespace Sanduiche.Test;

public class ProgramTest
{
    [Fact]
    public void MainTest()
    {
        /// expected é o valor esperado ao executar o programa
        string expected = "Sanduíche de Mortadela com Queijo está pronto!";
        /// StringWriter tem a função de armazenar a saída do nosso programa
        using (StringWriter saida = new StringWriter())
        {
            /// Aqui definimos que a saída do console será nosso StringWriter
            Console.SetOut(saida);
            /// Simulamos a chamada do nosso programa
            Sanduiche.Program.Main(null);
            /// Testamos se a saída do programa é a que esperamos
            Assert.Contains(expected, saida.ToString());
        }
    }

    [Fact]
    public void PegarFatiaDeQueijo(){
        string expected = "Peguei uma fatia de queijo.\n";

        string actual = Program.PegarFatia("queijo", 1);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PegarFatiaDeMortadela(){
        string expected = "Peguei uma fatia de mortadela.\nPeguei uma fatia de mortadela.\n";

        string actual = Program.PegarFatia("mortadela", 2);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PegarFatiaNegativa(){
        Assert.Throws<ArgumentOutOfRangeException>(() => Program.PegarFatia("presunto", -2));
    }

}