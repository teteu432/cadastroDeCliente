using ProjetoSenai.interfaces;

namespace ProjetoSenai.Classes
{
    public class PessoaFisica : Pessoas, IPessoaFisica
    {

        public string ?cpf { get; set; }
        public DateTime ?datanascimento { get; set; }
        
        public bool validarDataNascimento(DateTime dataNasc)
        {
            DateTime dataAtual =DateTime.Today;
            double anos = (dataAtual - dataNasc).TotalDays / 365;//TotalDay converte para dias
            //Console.WriteLine($"{anos}");
            if(anos >= 18){
                return true;
        }
            return false; //não precisa do else, pq caso seja verdadeira  o return ja fecha a função
        }
              
        
        public override float PagaImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
    }
}