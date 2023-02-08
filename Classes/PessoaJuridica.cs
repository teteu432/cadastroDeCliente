using ProjetoSenai.interfaces;

namespace ProjetoSenai.Classes
{
    public class PessoaJuridica : Pessoas, IPessoaJuridica
    {
        public string ?cnpj { get; set; }

        public string ?razaoSocial {get; set;}

        public override float PagaImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}