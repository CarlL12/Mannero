
Console.WriteLine("Snälla fyll i ditt förnamn");
string firstName = Console.ReadLine()!;


Console.WriteLine("Snälla fyll i ditt Efternamn");
string LastName = Console.ReadLine()!;



Console.WriteLine($"Hej {firstName} {LastName}");


Console.WriteLine("Snälla fyll i ålder");


int age = int.Parse( Console.ReadLine()!);


Console.WriteLine("Snälla fyll i Stad");


string city = Console.ReadLine()!;

int birth = DateTime.Now.Year - age;

Console.WriteLine($"Hej {firstName} du är {age} gammal och är född {birth} och bor i {char.ToUpper(city[0]) + city.Substring(1)} ");



