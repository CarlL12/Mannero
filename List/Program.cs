namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <string> list = new List<string>();
            Boolean running = true;
            


            while (running) 
            {
                Console.WriteLine("####### MENY ######");
                Console.WriteLine("1. Lägg till i varukorg");
                Console.WriteLine("2. Visa varukorg");
                Console.WriteLine("3. Exit");

                int option = int.Parse(Console.ReadLine()!);
                Console.Clear();

                switch (option)
                {
                    case 1:
                        Console.Write("Vad vill du lägga till?: ");
                        list.Add(Console.ReadLine()!);
                        Console.WriteLine($"La till {list[0]} i din varukorg");
                        Console.Write("Vill du lägga till något mer? JA/NEJ: ");
                        string items = Console.ReadLine()!;
                        Console.Clear();
                        if (items == "NEJ")  
                        {

                            break;
                           
                        }
                        else 
                        {
                            Console.Write("Vad vill du lägga till?: ");
                            list.Add(Console.ReadLine()!);
                            Console.Clear();
                            Console.Write("Vill du lägga till något mer? JA/NEJ: ");
                            items = Console.ReadLine()!;

                            if (items == "NEJ")
                            {
                                break;
                            }

                            else
                            {
                                Console.Write("Vad vill du lägga till?: ");
                                list.Add(Console.ReadLine()!);
                                Console.Clear();
                                Console.WriteLine("Tryck valfri knapp för komma till meny");
                                Console.ReadKey();
                                break;
                            }

                        }

                    case 2:

                        foreach (string item in list)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("Tryck valfir knapp för komma till meny");
                        Console.ReadKey();
                        break;
                    case 3:

                        running = false;
                        Environment.Exit(0);
                        break;
                }
            }   


            Console.ReadKey();
        }
    }
}
