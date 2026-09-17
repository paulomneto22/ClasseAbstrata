namespace ClasseAbstrata
{
    public abstract class CampoFormulario
    {
        public string NomeDoCampo { get; set; }
        public string Valor { get; set; }

        protected CampoFormulario(string nomeDoCampo, string valor)
        {
            NomeDoCampo = nomeDoCampo;
            Valor = valor;
        }
    }
}