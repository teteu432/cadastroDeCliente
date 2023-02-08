using ProjetoSenai.interfaces;

namespace ProjetoSenai.Classes
{
    public abstract class Pessoas : IPessoas
    {
        public string ?nome { get; set; }

        public string ?endereco { get; set; }

        public float ?rendimento { get; set; }

        public abstract float PagaImposto(float rendimento);

    }
}