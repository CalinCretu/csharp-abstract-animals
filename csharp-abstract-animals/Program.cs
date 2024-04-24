namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cane = new Cane();
            Console.WriteLine($"Il cane quando è stanco ha la faccia così: {cane.Dormi()}");
            Console.WriteLine($"Il cane quando è felice te lo dice così: {cane.Verso()}");
            Console.WriteLine($"Il cane quando ha fame mangia: {cane.Mangia()}");

            var passerotto = new Passerotto();
            Console.WriteLine($"\nIl passerotto quando è stanco ha la faccia così: {passerotto.Dormi()}");
            Console.WriteLine($"Il passerotto quando è felice te lo dice così: {passerotto.Verso()}");
            Console.WriteLine($"Il passerotto quando ha fame mangia: {passerotto.Mangia()}");

            var aquila = new Aquila();
            Console.WriteLine($"\nL'aquila quando è stanco ha la faccia così: {aquila.Dormi()}");
            Console.WriteLine($"L'aquila quando è felice te lo dice così: {aquila.Verso()}");
            Console.WriteLine($"L'aquila quando ha fame mangia: {aquila.Mangia()}");

            var delfino = new Delfino();
            Console.WriteLine($"\nIl delfino quando è stanco ha la faccia così: {delfino.Dormi()}");
            Console.WriteLine($"Il delfino quando è felice te lo dice così: {delfino.Verso()}");
            Console.WriteLine($"Il delfino quando ha fame mangia: {delfino.Mangia()}");
        }
    }
}
