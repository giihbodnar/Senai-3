using Encontro_Remoto_7.Classes;

List<PessoaFisica> listaPf = new List<PessoaFisica>();

Console.Clear();
Console.WriteLine(@$"
=============================================
|                                           |
|    Bem-Vinda ao Sistema de Cadastro de    |
|        Pessoas Físicas & Juridícas        |
|                                           |
=============================================
");


Utils.BarraCarregamento("Iniciando", 100, 40);


string? opcao;
do
{
    Console.Clear();
    Console.WriteLine(@$"
=============================================
|                                           |
|        Escolha uma das opções abaixo      |
|                                           |
|-------------------------------------------|
|           1 - Pessoa Física               |
|                                           |
|           2 - Pessoa Juridíca             |
|                                           |
|           0 - Sair                        |
=============================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":

            string? opcaoPf;

            do
            {
                Console.Clear();
                Console.WriteLine(@$"
=============================================
|                                           |
|        Escolha uma das opções abaixo      |
|                                           |
|-------------------------------------------|
|        1 - Cadastrar Pessoa Física        |
|                                           |
|        2 - Listar Pessoa Física           |
|                                           |
|        0 - Voltar ao menu anterior        |
=============================================
");
                opcaoPf = Console.ReadLine();
                PessoaFisica metodosPf = new PessoaFisica();

                switch (opcaoPf)
                {
                    case "1":
                        Console.Clear();

                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEndPf = new Endereco();

                        Console.WriteLine($"Nome Pessoa Física: ");
                        novaPf.Nome = Console.ReadLine();

                        bool dataValida;
                        do
                        {
                            Console.WriteLine($"Data de Nascimento Ex: DD/MM/AAAA");
                            string? dataNascimento = Console.ReadLine();

                            dataValida = novaPf.ValidarDataNasc(dataNascimento);

                            if (dataValida)
                            {
                                DateTime.TryParse(dataNascimento, out DateTime dataConvertida);
                                novaPf.dataNasc = dataConvertida;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"Data inválida! Digite novamente um valor válido, Ex: DD/MM/AAAA");
                                Console.ResetColor();
                                Thread.Sleep(6000);
                            }

                        } while (dataValida == false); // Continuar loop até encontar uma data válida

                        Console.WriteLine($"Digite o CPF: ");
                        novaPf.Cpf = Console.ReadLine();

                        Console.WriteLine($"Digite o valor do Rendimento Mensal da Pessoa Física (somente números): ");
                        novaPf.Rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o Logradouro: ");
                        novoEndPf.logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o Número: ");
                        novoEndPf.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o Complemento:");
                        novoEndPf.complemento = Console.ReadLine();

                        Console.WriteLine($"O Endereço é Comercial? S ou N ");
                        String endCom = Console.ReadLine().ToUpper();

                        if (endCom == "S")
                        {
                            novoEndPf.endComercial = true;
                        }
                        else
                        {
                            novoEndPf.endComercial = false;
                        }

                        novaPf.Endereco = novoEndPf;

                        listaPf.Add(novaPf);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Cadastrado com Sucesso! Uhuu");
                        Console.ResetColor();
                        Thread.Sleep(6000);



                        break;

                    case "2":
                        Console.Clear();

                        if (listaPf.Count > 0)
                        {
                            foreach (PessoaFisica cadaPessoa in listaPf)
                            {
                                Console.Clear();
                                Console.WriteLine(@$"
Nome: {cadaPessoa.Nome}
Endereço: {cadaPessoa.Endereco.logradouro}
Número: {cadaPessoa.Endereco.numero}
Complemento: {cadaPessoa.Endereco.complemento}
Renda Mensal: {cadaPessoa.Rendimento.ToString("C")}
Imposto: {metodosPf.PagarImposto(cadaPessoa.Rendimento).ToString("C")}
Data de Nascimento: {cadaPessoa.dataNasc.ToString("d")}
                                ");

                                Console.WriteLine($"Aperte ENTER para continuar!");
                                Console.ReadLine();
                            }

                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"Lista vazia, cadastre uma nova Pessoa Física!");
                            Console.ResetColor();
                            Thread.Sleep(10000);
                        }

                        break;

                    case "0":
                        Console.Clear();
                        Console.WriteLine($"Voltando ao Menu anterior!");
                        Thread.Sleep(6000);
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Opção Inválida, por favor digite uma opção válida!");
                        Console.ResetColor();
                        Thread.Sleep(6000);

                        break;
                }


            } while (opcaoPf != "0");

            break;

        case "2":
            PessoaJuridica novaPj = new PessoaJuridica();
            PessoaJuridica metodosPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            novaPj.Nome = "Nome pj";
            novaPj.RazaoSocial = "Razão Social PJ";
            novaPj.Cnpj = "00000000000100";
            novaPj.Rendimento = 10000.5f;

            novoEndPj.logradouro = "Rua Exemplo";
            novoEndPj.numero = 281;
            novoEndPj.complemento = "Complemento Exemplo";
            novoEndPj.endComercial = true;

            novaPj.Endereco = novoEndPj;

            Console.Clear();
            Console.WriteLine(@$"
Nome: {novaPj.Nome}
Razão Social: {novaPj.RazaoSocial}
CNPJ: {novaPj.Cnpj}
Válido: {metodosPj.ValidarCnpj(novaPj.Cnpj)}
Endereço: {novaPj.Endereco.logradouro}
Número: {novaPj.Endereco.numero}
Complemento: {novaPj.Endereco.complemento}
            ");

            Console.WriteLine($"Aperte ENTER para continuar!");
            Console.ReadLine();

            break;

        case "0":
            Console.Clear();
            Console.WriteLine($"Obrigada por utilizar nosso sistema!");
            Thread.Sleep(6000);

            Utils.BarraCarregamento("Finalizando", 500, 6);

            break;

        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Opção inválida, por favor digite uma opção válida!");
            Console.ResetColor();
            Thread.Sleep(6000);
            break;
    }

} while (opcao != "0");