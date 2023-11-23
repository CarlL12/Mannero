namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej och välkommen!");
            Console.Write("Fyll i ditt förnamn: ");

            string firstName = Console.ReadLine()!;
            Console.Clear();
               
            if(string.IsNullOrEmpty(firstName) ) 
            {
                Console.WriteLine("!!!!!!Du måste ange ett förnamn!!!!!!");
            }
            
            Console.Write("Fyll i ditt efternamn: ");
            string lastName = Console.ReadLine()!;
            Console.Clear();

            if(string.IsNullOrEmpty(lastName) ) 
            {

                Console.WriteLine("!!!!!!Du måste ange ett efternamn!!!!!!");
            }

            Console.WriteLine($"Hej {firstName} {lastName}, kul att ha dig här.");
            Console.Write("Ange ålder: ");
            int age = int.Parse(Console.ReadLine()!);
            Console.Write("Ange stad: ");
            string city = Console.ReadLine()!;

            int birth = DateTime.Now.Year - age;
            Console.Clear();

            Console.WriteLine($"Hej {firstName} {lastName}! Du är {age} gammal och bor i {char.ToUpper(city[0]) + city[1..]}");

            Console.WriteLine("Tryck på valfri tangent för att avsluta programmet");
            

            


            Console.ReadKey();
        }
    }
}
