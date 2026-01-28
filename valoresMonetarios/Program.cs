using System.Globalization;

// Define a cultura do "sistema" inteiro como pt-BR
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal valorMonetario = 1582.40M;

// É possível utilizar o método "ToString" para formatar uma visualização em especifica, nesse caso o valor será exibido como dolár por conta da formatação da cultura em "en-US"
System.Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

// Outros exemplos de formatações com o ToString

// O C1 vai deixar o valor com apenas uma casa decimal
System.Console.WriteLine(valorMonetario.ToString("C1"));
