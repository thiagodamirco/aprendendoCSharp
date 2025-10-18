namespace HelloWorld;
internal class FuncoesParametrosOpcinais
{

    public void Teste(int valor1, int valor2 = 7) // valor2 é um parâmetro opcional com valor padrão 7 - valores padrão devem ser os últimos na lista de parâmetros
    {
        Console.WriteLine(valor1 + valor2);
    }


}
