namespace SelectionStatementsExercise2
   {
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your favorite school subject?");
            string userSubject = Console.ReadLine();
            
            switch (userSubject.ToLower())
            {
                case "reading":
                    Console.WriteLine($"{userSubject}? Ahh, a bookworm?");
                    break;

                case "science":
                    Console.WriteLine($"{userSubject}? To infinity and beyond!");
                    break;

                case "math":
                    Console.WriteLine($"{userSubject}? Please excuse my dear Aunt Sally");
                    break;

                case "history":
                    Console.WriteLine($"{userSubject}? I remember a time when ...zzzz");
                    break;

                case "art":
                    Console.WriteLine($"{userSubject}? Yellow and blue make green?");
                    break;

                default:
                    Console.WriteLine($"{userSubject}, is that something new?");
                    break;
                    


            }
        }
    }
}