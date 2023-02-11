using ProjetoSenai.interfaces;

namespace ProjetoSenai.Classes
{
    public class PessoaFisica : Pessoas, IPessoaFisica 
    {

        public string ?cpf { get; set; }
        public string ?datanascimento { get; set; }
        
        /*
        public bool validarDataNascimento(DateTime dataNasc)
        {
            
            DateTime dataAtual = DateTime.Today;
            double anos = (dataAtual - dataNasc).TotalDays / 365;//TotalDay converte para dias
            //Console.WriteLine($"{anos}");
            if(anos >= 18){
                return true;
        }
            return false; //não precisa do else, pq caso seja verdadeira  o return ja fecha a função
        }
        */


        public bool validarDataNascimento(string dataNasc)
        {
            DateTime dataConvertida;
            //verificar se a string está em formto valio
            if(DateTime.TryParse(dataNasc, out dataConvertida)){ //try parse tenta converter e coloca na saida
            
                
                 DateTime dataAtual = DateTime.Today;
                double anos = (dataAtual - dataConvertida).TotalDays / 365;//TotalDay converte para dias
                //Console.WriteLine($"{anos}");
                if(anos >= 18){
                    return true;
            }
            return false;

         }
            return false; //não precisa do else, pq caso seja verdadeira  o return ja fecha a função
        }
              
        
        public override float PagaImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
    }
}