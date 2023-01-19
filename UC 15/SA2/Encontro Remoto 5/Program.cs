using Encontro_Remoto_5.Classes;

// PessoaFisica novaPF = new PessoaFisica();
// Endereco novoEndPf = new Endereco();

// novaPF.nome = "Tamires";
// novaPF.cpf = "000.000.000-00";
// novaPF.rendimento = 6600.5f; // f => float
// novaPF.dataNasc = new DateTime(2000, 10, 01);

// novoEndPf.logradouro = "Rua Exemplo";
// novoEndPf.numero = 280;
// novoEndPf.complemento = "Exemplo Complemento";
// novoEndPf.endComercial = true;

// novaPF.endereco = novoEndPf;

// Console.WriteLine(@$"
//     Nome: {novaPF.nome}, 
//     Rendimento: {novaPF.rendimento} 
//     CPF: {novaPF.cpf} 
//     Logradouro: {novaPF.endereco.logradouro}
//     Complemento: {novaPF.endereco.complemento}
//     Número: {novaPF.endereco.numero}
//     Endereço Comercial: {novaPF.endereco.endComercial}
// ");



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
// float impostaPagar = novaPF.CalcularImposto (novaPF.rendimento);
// Console.WriteLine($"{impostaPagar:0.00}");
// Console.WriteLine(impostaPagar.ToString("C")); // valor em R$


// =======================================================================

// Pessoa Juridica:
// PessoaJuridica novaPJ = new PessoaJuridica();
// Console.WriteLine(novaPJ.CalcularImposto(6600.5f));


// =======================================================================


// Data:
// DateTime temp = new DateTime (2005, 01, 01);
// Console.WriteLine(novaPF.ValidarDataNasc("2000/03/15"));
 

// =======================================================================


// Encontro Remoto 5:
PessoaJuridica novaPJ = new PessoaJuridica();
Endereco novoEndPJ = new Endereco();

novaPJ.nome = "Nome Pessoa Jurídica";
novaPJ.razaoSocial = "Razão Social Pessoa Jurídica";
novaPJ.cnpj = "00.476.645/0001-03";

novoEndPJ.logradouro = "Rua Exemplo";
novoEndPJ.numero = 280;
novoEndPJ.complemento = "Exemplo Complemento";

novaPJ.endereco = novoEndPJ;

Console.WriteLine(@$"
Nome: {novaPJ.nome}
Razão Social: {novaPJ.razaoSocial}
CNPJ: {novaPJ.cnpj}
Valido: {novaPJ.ValidarCnpj(novaPJ.cnpj)}

Rua: {novoEndPJ.logradouro}
Número: {novoEndPJ.numero}
Complemento: {novoEndPJ.complemento}
");
