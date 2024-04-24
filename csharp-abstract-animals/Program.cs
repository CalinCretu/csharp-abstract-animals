namespace csharp_abstract_animals
{
    internal class Program
    {
        static void FaiVolare(IVolante animale)
        {
            animale.Vola();
        }

        static void FaiNuotare(INuotante animale)
        {
            animale.Nuota();
        }
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

                if (animale is IVolante volante)        // se l'animale appartiene all'interfaccia IVolante
                {
                    FaiVolare(volante);                 // richiamo il metodo dell'interfaccia
                }

                if (animale is INuotante nuotante)
                {
                    FaiNuotare(nuotante);               // se l'animale appartiene all'interfaccia INuotante
                }

                Console.WriteLine("-----");
            }

            //foreach (var animale in animali)       // ciclo sempre la lista di animali
            //{
            //    if (animale is IVolante volante)        // se l'animale appartiene all'interfaccia IVolante
            //    {
            //        FaiVolare(volante);                 // richiamo il metodo dell'interfaccia
            //    }

            //    if (animale is INuotante nuotante)
            //    {
            //        FaiNuotare(nuotante);               // se l'animale appartiene all'interfaccia INuotante
            //    }

            //    Console.WriteLine("-----");             // richiamo il metodo dell'interfaccia
            //}
        }
    }
}