System.Console.WriteLine("-------------------------------");
System.Console.WriteLine("-----------TABUADA-------------");
System.Console.WriteLine("-------------------------------");


System.Console.WriteLine("Digite o número para descobrir a tabuada até o 10 do mesmo!");
string num = Console.ReadLine();
System.Console.WriteLine("-------------------------------");

for (int i = 1; i <= 10; i++)
{
    System.Console.WriteLine($"{num} x {i} = {Convert.ToInt32(num) * i}");
}