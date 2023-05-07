using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace contas_do_banco.Model
{
    public class PessoaFisica : Cliente
    {     
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Nome { get; set; }

        public bool EhMaior() 
        {
            int idade = DateTime.Now.Year  - DataNascimento.Year;

            if(DateTime.Now.DayOfYear < DataNascimento.DayOfYear)
            {
                idade = idade - 1;
            }

            return idade >= 18;
        }

         public override string ResumoCliente(){
            return $"{base.ResumoCliente()} - Cpf: {CPF} - Nome: {Nome} - DataNascimento: {DataNascimento.ToShortDateString()}" ;
        }
    }
}