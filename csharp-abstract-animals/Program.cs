namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var animali = new List<Animale>
            {
                new Cane()
            };

            var cane = new Cane();
            Console.WriteLine($"Il cane quando è stanco ha la faccia così: {cane.Dormi()}");
            Console.WriteLine($"Il cane quando è felice te lo dice così: {cane.Verso()}");
            Console.WriteLine($"Il cane quando ha fame mangia: {cane.Mangia()}");
            
        }
    }
}
