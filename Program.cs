using ProjetoSenai.Classes;

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

