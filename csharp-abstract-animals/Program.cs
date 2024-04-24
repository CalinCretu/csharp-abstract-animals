namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var animali = new List<Animale>
            {
                new Cane(),
                new Passerotto(),
                new Aquila(),
                new Delfino()
            };

            foreach (var animale in animali)
            {
                var nomeAnimale = animale.GetType().Name;
                var dormiAnimale = animale.Dormi();
                var versoAnimale = animale.Verso();
                var ciboAnimale = animale.Mangia();
                Console.WriteLine($"L'animale {nomeAnimale} quando è stanco fa la faccia così: {dormiAnimale}\n");
                Console.WriteLine($"L'animale {nomeAnimale} fa così: {versoAnimale}\n");
                Console.WriteLine($"L'animale {nomeAnimale} mangia: {ciboAnimale}");
                Console.WriteLine("-----");
            }
        }
    }
}