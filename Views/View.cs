using LogicAlgorithm.Services;

namespace LogicAlgorithm.Views
{
    public class View
    {
        public static void Run(){
            Menu();
        }

        private static void Menu(){
            bool isMenu = true;
            while(isMenu){
                Console.WriteLine("==========================================");
                Console.WriteLine("------------------Menu--------------------");
                Console.WriteLine("1. Question 1. Algoritma OK/YES/OKYES");
                Console.WriteLine("2. Question 2. Algoritma print number");
                Console.WriteLine("3. Question 3. Algoritma delete multiply 3");
                Console.WriteLine("4. Question 4. Query Data");
                Console.WriteLine("5. Exit");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("==========================================");

                Console.Write("Enter menu: ");
                string? menu = Console.ReadLine();

                switch(menu){
                    case "1":
                        Question1View.Run();
                    break;
                    case "2":
                        Question2View.Run();
                    break;
                    case "3":
                        Question3View.Run();
                    break;
                    case "4":
                        Console.WriteLine("Question 4 is a Database PostgreSQL, for the result of query you can see in file path ./Services/Question$Service.psql .");
                    break;
                    case "5":
                        Environment.Exit(0);
                    break;
                    default:
                        Console.WriteLine("Menu is invalid, please choose menu again.");
                    break;
                }
                Console.Write("Enter any key...");
                Console.ReadKey();
            }
        }
    }
}