namespace ClasseAbstrata
{
    public class CampoTexto : CampoFormulario, IValidavel
    {
        public CampoTexto(string nomeDoCampo, string valor) : base(nomeDoCampo, valor) { }

        public bool Validar()
        {
            return !string.IsNullOrEmpty(Valor);
        }
    }
}