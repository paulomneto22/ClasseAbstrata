namespace ClasseAbstrata
{
    internal interface ISalvavel
    {
        void Salvar();
    }
         public class Documento : ISalvavel
        {
            public void Salvar()
            {
                Console.WriteLine("Salvando o documento em formato .doc");
            }
        }
        public class Foto : ISalvavel
        {
            public void Salvar()
            {
                Console.WriteLine("Salvando a foto em formato .jpg");
            }
        }
    }





