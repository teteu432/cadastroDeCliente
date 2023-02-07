using ProjetoSenai.interfaces;

namespace ProjetoSenai.Classes
{
    public class Pessoas : IPessoas

    {
        public string ?nome { get; set; }

        public string ?endereco { get; set; }

        public float ?rendimento { get; set; }

        public float PagaImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
    }
}