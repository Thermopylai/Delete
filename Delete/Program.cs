namespace Delete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("\nMissing arguments.\n");
            }
            else if (args.Length == 1 && File.Exists(args[0]))
            {
                File.Delete(args[0]);
                Console.WriteLine($"\nFile '{args[0]}' deleted.\n");
            }
            else
            {
                Console.WriteLine($"\nFile '{args[0]}' doesn't exist or too many arguments.\n");
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
