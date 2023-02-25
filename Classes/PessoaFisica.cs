using ProjetoSenai.interfaces;

namespace ProjetoSenai.Classes
{
    public class PessoaFisica : Pessoas, IPessoaFisica 
    {
        public string ?cpf { get; set; }
        public string ?datanascimento { get; set; }
        
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
        public override float PagarImposto(float rendimento)
        {
            /*até 1900 isento
                de 1901 a 3500 vai pagar 2%
                Entre 3501 e 6000 paga 3,5%
                acima de 6000 paga 5%
            */

            if(rendimento <= 1900)
            {
                return 0;
            }
            else if(rendimento > 1900 && rendimento <= 3500)
            {
                return (rendimento / 100) * 2;
            }
            else if(rendimento > 3500 && rendimento <= 6000)
            {
                return (rendimento / 100) * 3.5f;
            }
            else
            {
                return (rendimento / 100) * 5;
            }

        }
    }
}
