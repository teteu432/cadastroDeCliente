using System.Text.RegularExpressions;
using ProjetoSenai.interfaces;

namespace ProjetoSenai.Classes
{
    public  class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string ?cnpj { get; set; }

        public string ?razaoSocial {get; set;}

        public string caminho {get; private set;} = "Database/Pessoajuridica.csv";
       

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

        public void inserir(PessoaJuridica pj)
        {
            VerificarPstaArquivo(caminho);

            string[] pjString = {$"{pj.nome}, {pj.cnpj}, {pj.razaoSocial}"};

            File.AppendAllLines(caminho, pjString);
        }

        private void VerificarPstaArquivo(string caminho)
        {
            throw new NotImplementedException();
        }

        public List<PessoaJuridica> Ler()
        {
            List<PessoaJuridica> ListaPj = new List<PessoaJuridica>();

            string[] linhas = File.ReadAllLines(caminho);

            foreach(string cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(",");

                PessoaJuridica cadaPj = new PessoaJuridica();

                cadaPj.nome = atributos[0];
                cadaPj.cnpj = atributos[1];
                cadaPj.razaoSocial = atributos[2];
                
                
                ListaPj.Add(cadaPj);
            }
            return ListaPj;
        }

        internal void Inserir(PessoaJuridica novaPj)
        {
            throw new NotImplementedException();
        }
    }
}