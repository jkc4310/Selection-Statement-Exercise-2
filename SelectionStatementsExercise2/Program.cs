namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello,what is your favorite subject in school?");

            var Subject = Console.ReadLine();

            switch (Subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is very challenging!");
                    break;

                case "science":
                    Console.WriteLine("You must be very smart to enjoy science!");
                    break;

                case "history":
                    Console.WriteLine("It's always interesting to study how we got here!");
                    break;

                case "gym":
                    Console.WriteLine("You must be an athlete!");
                    break;

                case "spanish":
                    Console.WriteLine("Being bilingual is a great skill to have!");
                    break;

                default:
                    Console.WriteLine("Hmm, I haven't hear of that subject!");
                    break;
            }
        }
    }
}