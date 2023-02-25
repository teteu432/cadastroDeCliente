using System.Text.RegularExpressions;
using ProjetoSenai.interfaces;

namespace ProjetoSenai.Classes
{
    public  class PessoaJuridica : Pessoas, IPessoaJuridica
    {
        public string ?cnpj { get; set; }

        public string ?razaoSocial {get; set;}
       

        public override float PagarImposto(float rendimento)
        {
            /*
            Rendimento de até 3000 vai pagar 3%
            de 3000 a 6000 vai pagar 5%
            de 6000 a 10000 paga 7%
            acima de 10000 paga 9%
            */

        if(rendimento <= 3000)
            {
                return rendimento  * 0.03f;
            }
            else if(rendimento > 3000 && rendimento <= 6000)
            {
                return (rendimento / 100) * 5;
            }
            else if(rendimento > 6000 && rendimento <= 10000)
            {
                return (rendimento / 100) * 7;
            }
            else
            {
                return (rendimento / 100) * 9;
            }
        
        
        }

        public bool ValidarCnpj(string cnpj)
        {
            if(Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}.\d{4}-\d{2}|(\d{14}))$)"))
            {
                if(cnpj.Length == 18)
                {
                    if(cnpj.Substring(11,4) == "0001")
                    {
                        return true;
                    }
                    
                }
                else if(cnpj.Length == 14)
                {
                    if(cnpj.Substring(8,4) == "0001")
                    {
                        return true;
                    }
                    
                }

            }
            return false;
            
        }
    }
}