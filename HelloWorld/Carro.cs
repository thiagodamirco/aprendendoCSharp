namespace HelloWorld;
public class Carro
{
    public string Modelo { get; set; } // get ; set; auto-implemented property/ required obriga a inicialização da propriedade
    public DateOnly LancadoEm { get; set; }
    public Cor Cor { get; set; }

    public Carro(string modelo) // Constructor to enforce required property initialization
    {
        Modelo = modelo; // Required property initialized in constructor
    }

    public void NomeDoModelo() => Console.WriteLine($"O modelo do carro é {Modelo}");
   
}