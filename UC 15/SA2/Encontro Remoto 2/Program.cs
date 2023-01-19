using Encontro_Remoto_2.Classes;

PessoaFisica novaPF = new PessoaFisica();

novaPF.nome = "Tamires";
novaPF.cpf = "000.000.000-00";

// exemplos:
// Console.WriteLine(novaPF.nome);
// Console.WriteLine(novaPF.cpf);
// Console.WriteLine("Bem-vinda");

// concatenação: 
Console.WriteLine("Nome - " + novaPF.nome);

//interpolação:
Console.WriteLine($"Bem-vinda: {novaPF.nome} de CPF: {novaPF.cpf}");