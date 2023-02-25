using ProjetoSenai.Classes;
 

Console.WriteLine(@$"
=====================================================================
|                    Bem vindo ao sistema de cadastro de            |  
|                     Pessoa Fisica e Juridica                      |          
=====================================================================
");
BarraCarregamento("Carregando", 120);


string? opcao;

do
{
    Console.Clear();
    Console.WriteLine(@$"
==================================================================
|                    Escolha uma das opções abaixo               | 
|----------------------------------------------------------------| 
|                   1 - Pessoa Fisica                            |   
|                   2 - Pessoa Juridica                          |
|                   0 - sair                                     |       
==================================================================
");

opcao = Console.ReadLine();

switch (opcao)
{
    case "1":
    Console.Clear();
    PessoaFisica obj_PF = new PessoaFisica();
    Endereco novoEnd = new Endereco();
    PessoaFisica metodoPF = new PessoaFisica();

    obj_PF.nome = "Jaiminho";
    obj_PF.datanascimento = "23/08/1947";
    obj_PF.cpf = "40028922019";
    obj_PF.rendimento = 2400.00f;

    novoEnd.logradouro = "Rua tangamandapio";
    novoEnd.numero = 123;
    novoEnd.Complemento = "escola Senai";
    novoEnd.endComercial = true;

    obj_PF.endereco = novoEnd;

    Console.WriteLine(@$"
    Nome: {obj_PF.nome}
    Data de nascimento: {obj_PF.datanascimento}
    cpf: {obj_PF.cpf}
    Rendimento: {obj_PF.rendimento}
    Logradouro: {obj_PF.endereco.logradouro}
    número: {obj_PF.endereco.numero}
    complemento: {obj_PF.endereco.Complemento}
    endereço comercial: {((bool)(obj_PF.endereco.endComercial) ? "sim": "não")}
    Maior de idade? {(metodoPF.validarDataNascimento(obj_PF.datanascimento) ? "sim": "não")}
    Taxa de imposto a ser paga: {metodoPF.PagarImposto(obj_PF.rendimento).ToString("C")}
");
    Console.WriteLine($"Aperte 'Enter' para continuar");
    Console.ReadLine();
    
    
        break;

    case "2":
    Console.Clear();
    PessoaJuridica metodoPj= new PessoaJuridica();
    PessoaJuridica novaPj = new PessoaJuridica ();
    Endereco novoEndPj = new Endereco();
    novaPj.nome = "Nome PJ";
    novaPj.cnpj = "00.000.000/0001-00";
    novaPj.razaoSocial = "Razão Social Pj ";
    novaPj.rendimento = 80000.5f;
    novoEndPj.logradouro = "Eua niterói";
    novoEndPj.numero = 100;
    novoEndPj.Complemento = "Senai";
    novoEndPj.endComercial = true;
    Console.WriteLine(@$"
    Nome: {novaPj.nome}
    razao Social: {novaPj.razaoSocial}
    cnpj: {novaPj.cnpj}
    cnpj é valido ? {(metodoPj.ValidarCnpj(novaPj.cnpj) ? "sim": "não")}
    rendimento: {novaPj.rendimento}
    logradouro: {novoEndPj.logradouro}
    endereço comercial? {novoEndPj.endComercial}
    taxa de imposto a ser paga: {metodoPj.PagarImposto(novaPj.rendimento).ToString("C")}

");
    Console.WriteLine($"Aperte 'Enter' para ccontinuar");
    Console.ReadLine();
        break;
   
    case "0":
    Console.Clear();
    BarraCarregamento("Finaizando", 100);
    Console.Clear();
        break;
    default:
        Console.Clear();
        Console.WriteLine($"Opção inválida, por favor digite outra opção.");
        Thread.Sleep(3000);
        
        break;
}
} while (opcao != "0");

static void BarraCarregamento(string texto, int tempo)
    {
        
        Console.BackgroundColor = ConsoleColor.DarkCyan;
        Console.ForegroundColor = ConsoleColor.Red;

        Console.Write($"{texto}");
        
         for(var contador = 0; contador < 32; contador ++)
    {
        Console.Write(" .");
        Thread.Sleep(tempo);
    }

            Console.ResetColor();

    }









/* Console.WriteLine($"Obrigado por utlizar nosso sistema");
    Console.BackgroundColor = ConsoleColor.DarkCyan;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Finalizando");

for(var contador = 0; contador < 32; contador ++)
{
    Console.Write(" .");
    Thread.Sleep(100);
}

        Console.ResetColor();
        */



/*PessoaJuridica metodoPj= new PessoaJuridica();
PessoaJuridica novaPj = new PessoaJuridica ();
Endereco novoEndPj = new Endereco();

novaPj.nome = "Nome PJ";
novaPj.cnpj = "00.000.000/0001-00";
novaPj.razaoSocial = "Razão Social Pj ";
novaPj.rendimento = 8000.5f;

novoEndPj.Logradouro = "Eua niterói";
novoEndPj.numero = 100;
novoEndPj.Complemento = "Senai";
novoEndPj.endComercial = true;

Console.WriteLine(@$"
Nome: {novaPj.nome}
razao Social: {novaPj.razaoSocial}
cnpj: {novaPj.cnpj}
rendimento: {novaPj.rendimento}
logradouro: {novaPj.endereco.Logradouro}

");

//Console.WriteLine($"{metodoPj.ValidarCnpj("00.000.000/0001-00")}");
//Console.WriteLine($"{metodoPj.ValidarCnpj("00000000000100")}");


PessoaFisica obj_PF = new PessoaFisica();
Endereco novoEnd = new Endereco();
PessoaFisica metodoPF = new PessoaFisica();

obj_PF.nome = "Jaiminho";
obj_PF.datanascimento = "23/08/1947";
obj_PF.cpf = "40028922019";
obj_PF.rendimento = 1650.00f;

novoEnd.Logradouro = "Rua tangamandapio";
novoEnd.numero = 123;
novoEnd.Complemento = "escola Senai";
novoEnd.endComercial = true;

obj_PF.endereco = novoEnd;

Console.WriteLine(@$"
Nome: {obj_PF.nome}
Data de nascimento: {obj_PF.datanascimento}
cpf: {obj_PF.cpf}
Rendimento: {obj_PF.rendimento}
Logradouro: {obj_PF.endereco.Logradouro}
número: {obj_PF.endereco.numero}
complemento: {obj_PF.endereco.Complemento}
endereço comercial: {obj_PF.endereco.endComercial}
Maior de idade? {metodoPF.validarDataNascimento(obj_PF.datanascimento)}

");
*/
