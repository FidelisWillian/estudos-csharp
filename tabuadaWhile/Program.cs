System.Console.WriteLine("-------------------------------");
System.Console.WriteLine("-----------TABUADA-------------");
System.Console.WriteLine("-------------------------------");


System.Console.WriteLine("Digite o número para descobrir a tabuada até o 10 do mesmo!");
string num = Console.ReadLine();
System.Console.WriteLine("-------------------------------");

// A diferença entre o for e while, é que no while temos que realizar o incremento dentro do bloco de código.
int contador = 1;
while (contador <= 10)
{
    System.Console.WriteLine($"{num} x {contador} = {Convert.ToInt32(num) * contador}");
    contador++;
}