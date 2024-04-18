// See https://aka.ms/new-console-template for more information
float nota1;
float nota2;
float max;

Console.WriteLine("Digite a nota máxima");
max = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota 1");
nota1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota 2");
nota2 = float.Parse(Console.ReadLine());

if(nota1 < 0 || nota1 > max || nota2 < 0 || nota2 > max)
{
    Console.WriteLine("invalido");

} else if((nota1 + nota2)/2 > 5)
{
    Console.WriteLine("Aprovado");

}else if ((nota1 + nota2)/2 > 3)
{
    Console.WriteLine("Exame");
}
else
{
    Console.WriteLine("Reprovado");

}
