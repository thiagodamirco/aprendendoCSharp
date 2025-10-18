namespace HelloWorld;

class Program
{
    static void Main()
    {
        var texto = Teste (5); // Call the Teste method with an integer argument

        Console.WriteLine(texto);

    }

    static string Teste(int numero) 
    {
        Console.WriteLine("Início do teste");

        if (numero == 5) 
        {
            Console.WriteLine("Número é cinco");
            return "Final do teste"; // This line returns a string when numero is 5
        }

        Console.WriteLine("Número não é cinco");

        return "Outro valor";
    }
}
