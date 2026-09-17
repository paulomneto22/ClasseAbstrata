namespace ClasseAbstrata
{
    abstract class Arma
    {
        public string Nome { get; set; }
        public double DanoBase { get; set; }

        public Arma(string nome, double danoBase)
        {
            Nome = nome;
            DanoBase = danoBase;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Nome Da Arma: {Nome} | O Dano Base: {DanoBase}");
        }

        public abstract double CalcularAtaqueCritico();
    }

    class Espada : Arma
    {
        public Espada(string nome, double danoBase) : base(nome, danoBase) { }

        public override double CalcularAtaqueCritico()
        {
            return DanoBase * 2;
        }
    }

    class Arco : Arma
    {
        public Arco(string nome, double danoBase) : base(nome, danoBase) { }

        public override double CalcularAtaqueCritico()
        {
            return DanoBase * 3;
        }
    }
}