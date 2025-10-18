namespace HelloWorld;
public static class StaticMatematica // classe estática não pode ser instanciada e o valor dela é compartilhado em toda a aplicação
{
    public static int Somar(int valor1, int valor2) => valor1 + valor2; // método estático que retorna a soma de dois valores inteiros

    public static int Subtrair(int valor1, int valor2) => valor1 - valor2; // todas as funções dentro de uma classe estática obrigatoriamente precisam ser estáticas
}
