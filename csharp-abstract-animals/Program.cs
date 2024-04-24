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

            foreach (var animale in animali)        // ciclo la lista di animali
            {                                                   // GetType().Name prende il nome della classe e lo restituisce in forma di stringa
                var nomeAnimale = animale.GetType().Name;       // il nome della classe lo utilizzo come nome dell'animale
                var dormiAnimale = animale.Dormi();
                var versoAnimale = animale.Verso();
                var ciboAnimale = animale.Mangia();
                Console.WriteLine($"L'animale {nomeAnimale} quando è stanco fa la faccia così: {dormiAnimale}\n");
                Console.WriteLine($"L'animale {nomeAnimale} fa così: {versoAnimale}\n");
                Console.WriteLine($"L'animale {nomeAnimale} mangia: {ciboAnimale}");
                Console.WriteLine("-----");     // linea divisoria per creare ordine quando stampo
            }
        }
    }
}