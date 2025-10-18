namespace HelloWorld;
internal class OperacoesMatematicas
{
    public int Adicionar(int valor1, int valor2) // public pode ser acessado de qualquer lugar - void significa que o método não retorna valor - variáveis locais são declaradas dentro de métodos
    {
        return valor1 + valor2; // retorna a soma dos valores sem armazenar em uma variável local

    }

    public int Subtrair(int valor1, int valor2) // public pode ser acessado de qualquer lugar - void significa que o método não retorna valor - variáveis locais são declaradas dentro de métodos
    {
        var resultado = valor1 - valor2; // var infere o tipo da variável automaticamente, variável local resultado recebe a subtração dos valores e armazena o resultado

        return resultado; // retorna o valor da variável resultado
    }

    public int Multiplicar(int valor1, int valor2) => valor1 * valor2; // expressão de corpo de método - retorna a multiplicação dos valores sem armazenar em uma variável local

    public (int, string) Subtrair2(int valor1, int valor2) // public pode ser acessado de qualquer lugar - método que retorna uma tupla com dois valores: um int e uma string
    {
        var resultado = valor1 - valor2; // var infere o tipo da variável automaticamente, variável local resultado recebe a subtração dos valores e armazena o resultado

        return (resultado, "Subtrair2"); // retorna uma tupla com o valor da variável resultado e a string "Subtrair2"
    }

    public (int resultadoAdionar2, string funcao) Adicionar2(int valor1, int valor2) // public pode ser acessado de qualquer lugar - método que retorna uma tupla com dois valores: um int e uma string
    {
        var resultado2 = valor1 + valor2; // var infere o tipo da variável automaticamente, variável local resultado recebe a subtração dos valores e armazena o resultado

        return (resultado2, "Adicionar2"); // retorna uma tupla com o valor da variável resultado e a string "Subtrair2"


    }

}
