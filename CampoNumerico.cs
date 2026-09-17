namespace ClasseAbstrata
{
    public class CampoNumerico : CampoFormulario, IValidavel
    {
        public CampoNumerico(string nomeDoCampo, string valor) : base(nomeDoCampo, valor) { }

        public bool Validar()
        {
            return int.TryParse(Valor, out _);
        }
    }
}