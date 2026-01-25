// Sintaxe para declaração de uma lista do tipo string
List<string> listaMeses = new List<string>();


// .Add é a maneira para inserir coisas dentro dessa lista
listaMeses.Add("Janeiro");
listaMeses.Add("Fevereiro");
listaMeses.Add("Março");
listaMeses.Add("Abril");
listaMeses.Add("Maio");
listaMeses.Add("Junho");
listaMeses.Add("Julho");
listaMeses.Add("Agosto");
listaMeses.Add("Setembro");
listaMeses.Add("Outubro");
listaMeses.Add("Novembro");
listaMeses.Add("Dezembro");

// Percorrendo a lista com FOREACH
int contadorMes = 1;
foreach (var i in listaMeses)
{
    System.Console.WriteLine($"Mês {contadorMes} - {i}");
    contadorMes++;
}