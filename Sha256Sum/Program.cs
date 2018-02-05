using System;

namespace BTH.Sha256Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.Out.WriteLine("Usage: Sha256Sum <filename>");
                return;
            }

            string path = args[0];

            try
            {
                using (var stream = System.IO.File.OpenRead(path))
                {
                    string hashString = Sha256Calculator.Calculate(stream);
                    Console.Out.WriteLine(hashString + " " + path);
                }
            }
            catch (Exception exc)
            {
                Console.Out.WriteLine("Something went wrong: " + exc.Message);
            }
        }
    }
}
