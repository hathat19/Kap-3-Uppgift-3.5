using System; 
namespace Uppgift3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in två tal med ett mellanslag emellan.");
            string sent = Console.ReadLine();

            int spaceIndex = sent.IndexOf(" "); //Index av mellanslaget
            double number1 = double.Parse(sent[..spaceIndex]); //Tal nummer 1
            double number2 = double.Parse(sent[(spaceIndex + 1)..]); //Tal nummer 2

            Console.WriteLine("Välj ett räknesätt som de två talen ska räknas med.\n1. Addition\n2. Subtraktion\n3. Multiplikation\n4. Division");
            int choice = int.Parse(Console.ReadLine());

            //Vilket räknesätt
            switch (choice)
            {
                case 1: //plus
                    Console.WriteLine($"Summan av {number1} och {number2} är lika med {number1+number2}");
                    break;

                case 2: //minus
                    Console.WriteLine($"Differensen av {number1} och {number2} är lika med {number1 - number2}");
                    break;

                case 3: //gånger
                    Console.WriteLine($"Produkten av {number1} och {number2} är lika med {number1 * number2}");
                    break;

                case 4: //delat med
                    Console.WriteLine($"Kvoten av {number1} och {number2} är lika med {number1 / number2}");
                    break;

            }
        }
    }
}