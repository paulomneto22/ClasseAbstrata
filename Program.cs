namespace ClasseAbstrata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Documento D = new Documento();
            D.Salvar();
            Foto F = new Foto();
            F.Salvar();
        }
    }
}

