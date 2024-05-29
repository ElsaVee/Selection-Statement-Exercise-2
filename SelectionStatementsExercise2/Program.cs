namespace SelectionStatementsExercise2
   {
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your favorite school subject?");
            string userInput = Console.ReadLine();
            
            switch (userInput.ToLower())
            {
                case "reading":
                    Console.WriteLine($"{userInput}? Ahh, a bookworm?");
                    break;

                case "science":
                    Console.WriteLine($"{userInput}? To infinity and beyond!");
                    break;

                case "math":
                    Console.WriteLine($"{userInput}? Please excuse my dear Aunt Sally");
                    break;

                case "history":
                    Console.WriteLine($"{userInput}? I remember a time when ...zzzz");
                    break;

                case "art":
                    Console.WriteLine($"{userInput}? Yellow and blue make green?");
                    break;

                default:
                    Console.WriteLine($"{userInput}, is that something new?");
                    break;
                    


            }
        }
    }
}