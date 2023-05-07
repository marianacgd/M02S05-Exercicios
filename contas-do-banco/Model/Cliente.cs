using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace contas_do_banco.Model
{
    public class Cliente
    {

        public int NumeroConta { get; set; }
        public decimal  Saldo { get; set; }
        public string Endereco { get; set; }
        
        public virtual string ResumoCliente()
        {
            return $"Nr {NumeroConta} - Saldo {Saldo} - Endereço {Endereco}";
        }
    }
}