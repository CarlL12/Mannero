namespace AtmProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean RunningApp = true;
            int accountBalance = 2000;

            while (RunningApp == true)
            {
                Console.Clear();
                Console.WriteLine("Please select a option");
                Console.WriteLine("1.Withdraw funds");
                Console.WriteLine("2.Deposit Funds");
                Console.WriteLine("3.Check account balance");
                int option = int.Parse(Console.ReadLine()!);
                Console.Clear();
                Boolean running = true;
                switch (option)
                {
                    case 1:
                        {
                            Console.Write("Please insert PIN: ");
                            int PIN = int.Parse(Console.ReadLine()!);
                            Console.Clear();
                            if (PIN < 4)
                            {
                                Console.WriteLine("Invalid PIN");
                                break;
                            }
                            else

                            {
                                Console.WriteLine("How much do you want to withdraw?");
                                Console.WriteLine("1. 100$");
                                Console.WriteLine("2. 200$");
                                Console.WriteLine("3. 300$");
                                Console.WriteLine("4. Specific amount");
                                int withDraw = int.Parse(Console.ReadLine()!);
                                Console.Clear();
                                while(running == true) 
                                {
                                    switch (withDraw)
                                    {
                                        case 1:
                                            {
                                                accountBalance -= 100;
                                                Console.WriteLine($"You now have {accountBalance} in your account");
                                                Console.WriteLine("Press any key return to main meny!");
                                                running = false;
                                                break;

                                            }
                                        case 2:
                                            {
                                                accountBalance -= 200;
                                                Console.WriteLine($"You now have {accountBalance} in your account");
                                                Console.WriteLine("Press any key return to main meny!");
                                                running = false;
                                                break;
                                            }
                                        case 3:
                                            {
                                                accountBalance -= 300;
                                                Console.WriteLine($"You now have {accountBalance} in your account");
                                                Console.WriteLine("Press any key return to main meny!");
                                                running = false;
                                                break;
                                            }
                                        case 4:
                                            {
                                                Console.Write("How much do you want to withdraw?: ");
                                                accountBalance -= int.Parse(Console.ReadLine()!);
                                                Console.Clear();
                                                Console.WriteLine($"You now have {accountBalance} in your account");
                                                Console.WriteLine("Press any key return to main meny!");
                                                running = false;
                                                break;
                                            }
                                        default:
                                            {
                                                Console.WriteLine("####You need to select a valid option####");
                                                break;
                                            }
                                    }
                                }
                          
                            }
                        }
                        break;
                    case 2:
                        {
                            Console.Write("Please insert PIN: ");
                            int PIN = int.Parse(Console.ReadLine()!);
                            Console.Clear();
                            if (PIN < 4)
                            {
                                Console.WriteLine("Invalid PIN");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("How much do you want to deposit?");
                                Console.WriteLine("1. 100$");
                                Console.WriteLine("2. 200$");
                                Console.WriteLine("3. 300$");
                                Console.WriteLine("4. Specific amount");
                                int deposit = int.Parse(Console.ReadLine()!);
                                Console.Clear();
                                while(running == true) 
                                {
                                    switch (deposit)
                                    {
                                        case 1:
                                            {
                                                accountBalance += 100;
                                                Console.WriteLine($"You now have {accountBalance} in your account");
                                                Console.WriteLine("Press any key return to main meny!");
                                                running = false;
                                                break;
                                            }
                                        case 2:
                                            {
                                                accountBalance += 200;
                                                Console.WriteLine($"You now have {accountBalance} in your account");
                                                Console.WriteLine("Press any key return to main meny!");
                                                running = false;
                                                break;
                                            }
                                        case 3:
                                            {
                                                accountBalance += 300;
                                                Console.WriteLine($"You now have {accountBalance} in your account");
                                                Console.WriteLine("Press any key return to main meny!");
                                                running = false;
                                                break;
                                            }
                                        case 4:
                                            {
                                                Console.Write("How much do you want to deposit?: ");
                                                accountBalance += int.Parse(Console.ReadLine()!);
                                                Console.Clear();
                                                Console.WriteLine($"You now have {accountBalance} in your account");
                                                Console.WriteLine("Press any key return to main meny!");
                                                running = false;
                                                break;
                                            }
                                        default:
                                            {
                                                Console.WriteLine("####You need to select a valid option####");
                                                break;
                                            }
                                    }
                                }
                            }
                            break;
                        }
                    case 3:
                        {     
                            Console.WriteLine($"You have {accountBalance} in your account");
                            Console.WriteLine("Press any key to return to main meny!");
                            break;
                        }
                }
                Console.ReadKey();
            }

        }
    }
}
