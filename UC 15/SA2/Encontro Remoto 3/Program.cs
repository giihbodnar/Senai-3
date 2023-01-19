using Encontro_Remoto_3.Classes;

PessoaFisica novaPF = new PessoaFisica();

novaPF.nome = "Tamires";
novaPF.cpf = "000.000.000-00";
novaPF.rendimento = 6600.5f; // f => float

// exemplos:
// Console.WriteLine(novaPF.nome);
// Console.WriteLine(novaPF.cpf);
// Console.WriteLine("Bem-vinda");

// concatenação: 
// Console.WriteLine("Nome - " + novaPF.nome);

// interpolação:
// Console.WriteLine($"Bem-vinda: {novaPF.nome} de CPF: {novaPF.cpf}");

// =======================================================================


// Pessoa Fisica:
float impostaPagar = novaPF.CalcularImposto (novaPF.rendimento);
// Console.WriteLine($"{impostaPagar:0.00}");
Console.WriteLine(impostaPagar.ToString("C")); // valor em R$


// =======================================================================

// Pessoa Juridica:
PessoaJuridica novaPJ = new PessoaJuridica();
Console.WriteLine(novaPJ.CalcularImposto(6600.5f));
