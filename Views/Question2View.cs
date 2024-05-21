using LogicAlgorithm.Services;

namespace LogicAlgorithm.Views
{
    public class Question2View
    {
        public static void Run(){
            bool isMenuQuestion2 = true;
            while(isMenuQuestion2){
                Console.WriteLine("==========================================");
                Console.WriteLine("-------------Menu Question 1--------------");
                Console.WriteLine("1. Type A");
                Console.WriteLine("2. Type B");
                Console.WriteLine("3. Type C");
                Console.WriteLine("4. Type D");
                Console.WriteLine("5. Exit");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("==========================================");

                Console.Write("Enter menu: ");
                string? menu = Console.ReadLine();

                switch(menu){
                    case "1":
                        TypeA();
                    break;
                    case "2":
                        TypeB();
                    break;
                    case "3":
                        TypeC();
                    break;
                    case "4":
                        TypeD();
                    break;
                    case "5":
                        isMenuQuestion2 = false;
                    break;
                    default:
                        Console.WriteLine("Menu is invalid, Please enter menu again.");
                    break;
                }
                
                Console.Write("Enter any key...");
                Console.ReadKey();
            }
        }

        private static void TypeA(){
            try{
                Console.Write("Enter number ex(5): ");
                int number = int.Parse(Console.ReadLine());
                Question2Service.Question2TypeA(number);
            }catch(FormatException){
                Console.WriteLine("Input not valid, just accept integer number");
            }
        }

        private static void TypeB(){
            try{
                Console.Write("Enter number ex(5): ");
                int number = int.Parse(Console.ReadLine());
                Question2Service.Question2TypeB(number);
            }catch(FormatException){
                Console.WriteLine("Input not valid, just accept integer number");
            }
        }

        private static void TypeC(){
            try{
                Console.Write("Enter number ex(5): ");
                int number = int.Parse(Console.ReadLine());
                Question2Service.Question2TypeC(number);
            }catch(FormatException){
                Console.WriteLine("Input not valid, just accept integer number");
            }
        }

        private static void TypeD(){
            try{
                Console.Write("Enter number ex(5): ");
                int number = int.Parse(Console.ReadLine());
                Question2Service.Question2TypeD(number);
            }catch(FormatException){
                Console.WriteLine("Input not valid, just accept integer number");
            }
        }
    }
}