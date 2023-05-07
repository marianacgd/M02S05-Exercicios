namespace contas_do_banco.Model
{
    public class PessoaJuridica : Cliente 
    {
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }

         public override string ResumoCliente(){
            return $"{base.ResumoCliente()} - CNPJ: {CNPJ} - Razão Social: {RazaoSocial}" ;
        }
    }
}