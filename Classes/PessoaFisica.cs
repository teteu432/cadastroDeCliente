using ProjetoSenai.interfaces;

namespace ProjetoSenai.Classes
{
    public class PessoaFisica : Pessoas, IPessoaFisica
    {

        public string ?cpf { get; set; }
        public DateTime ?datanascimento { get; set; }
        public bool validarDataNascimento(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }
              
        
        public override float PagaImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
    }
}