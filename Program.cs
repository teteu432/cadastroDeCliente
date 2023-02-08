
using ProjetoSenai.Classes;

PessoaFisica obj_pf = new PessoaFisica();

obj_pf.nome = "lozano";
obj_pf.cpf = "10001000100";
obj_pf.endereco = "Rua paulistinha 220";
obj_pf.rendimento = 1000.00f;

Console.WriteLine($"Nome; "+ obj_pf.nome);
Console.WriteLine($"CPF; "+ obj_pf.cpf);
Console.WriteLine($"Endereço; "+ obj_pf.endereco);
Console.WriteLine($"Rendimento; "+ obj_pf.rendimento);

Console.WriteLine($"***************************************************");

PessoaJuridica obj_pJ = new PessoaJuridica();
obj_pJ.nome = "Via Varejo";
obj_pJ.cnpj = "40028922440022";
obj_pJ.razaoSocial = "Via cb";
obj_pJ.rendimento = 100000.00f;

Console.WriteLine(@$"
nome: {obj_pJ.nome}
CNPJ: {obj_pJ.cnpj} 
razao social: {obj_pJ.razaoSocial}
Rendimento: {obj_pJ.rendimento}");



