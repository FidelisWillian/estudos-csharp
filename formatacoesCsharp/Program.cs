using System.Globalization;

// Define a cultura do "sistema" inteiro como pt-BR
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal valorMonetario = 1582.40M;

// É possível utilizar o método "ToString" para formatar uma visualização em especifica, nesse caso o valor será exibido como dolár por conta da formatação da cultura em "en-US"
System.Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

// Outros exemplos de formatações com o ToString

// O C1 vai deixar o valor com apenas uma casa decimal
System.Console.WriteLine(valorMonetario.ToString("C1"));


// Porcentagens

double porcentagem = .3421;

System.Console.WriteLine(porcentagem.ToString("P"));

int numero = 123456;
System.Console.WriteLine(numero.ToString("##-##-##"));


// DateTime

DateTime data = DateTime.Now;
System.Console.WriteLine(data);
System.Console.WriteLine(data.ToShortDateString());
System.Console.WriteLine(data.ToShortTimeString());
System.Console.WriteLine(data.ToString("dd/MM/yyyy"));
System.Console.WriteLine(data.ToString("HH:mm"));

DateTime data2 = DateTime.Parse("17/04/2026 17:00");
System.Console.WriteLine(data2);

string dataString = "2026-12-17 18:00";
bool conversao = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date);

if (conversao)
{
    System.Console.WriteLine("Conversão realizada com sucesso!");
} else
{
    System.Console.WriteLine("Não foi possível realizar a conversão");
}
