namespace TodoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Todos = [];

            Boolean running = true;
            int count = 0;

            while (running)
            {
                Console.WriteLine("######## TODO LIST ########");
                Console.WriteLine("1. Lägg till todo");
                Console.WriteLine("2. Markera todo klar");
                Console.WriteLine("3. Visa todos");

                int option = int.Parse(Console.ReadLine()!);
                Console.Clear();

                switch (option)
                {

                    case 1:
                        {
                            Console.Write("Vad vill du lägga till?:");
                            Todos.Add(Console.ReadLine()!);
                            Console.Clear();
                            Console.WriteLine("Tryck valfri knapp för att komma till meny");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
  
                    case 2: 
                        {
                            count = 0;
                            Console.WriteLine("Vilken todo vill du markera som klar?");
                            foreach (string todo in Todos)
                            {
                                
                                count++;
                                Console.WriteLine($"{count}. {todo}");
                            }

                            int finished = int.Parse(Console.ReadLine()!);
                            Console.Clear();

                            switch (finished)
                            {
                                case 1:
                                    {
                                        Console.WriteLine($"Markerar {Todos[0]} som klar");
                                        Todos[0] += "- KLAR";                                    
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine($"Markerar {Todos[1]} som klar");
                                        Todos[1] += "- KLAR";
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.WriteLine($"Markerar {Todos[2]} som klar");
                                        Todos[2] += "- KLAR";
                                        break;
                                    }
                            }

                            break;
                        }
                    case 3:
                        {
                            count = 0;
                            Console.WriteLine("#### TODOS ####");
                            foreach (string todo in Todos)
                            {
                                
                                count++;
                                Console.WriteLine($"{count}. {todo}");
                            }
                            Console.WriteLine("Tryck valfri knapp för att komma till meny");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                }   



            }
        }
    }
}
