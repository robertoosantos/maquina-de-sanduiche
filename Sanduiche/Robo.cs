public class Robo
{
    public static string PegarFatia(string ingrediente, int quantidade)
    {
        if (quantidade <= 0)
        {
            throw new ArgumentOutOfRangeException("quantidade", quantidade, "A quantidade precisa ser positiva!");
        }
        else
        {
            string fatias = "";

            for (int i = 0; i < quantidade; i++)
            {
                fatias += string.Format("Peguei uma fatia de {0}.\n", ingrediente);
            }

            return fatias;
        }
    }
}