using LogicAlgorithm.Services;

namespace LogicAlgorithm.Views
{
    public class Question1View
    {
        public static void Run(){
            try{
                Console.Write("Enter number ex(15): ");
                int number = int.Parse(Console.ReadLine());
                Question1Service.Question1(number);

            }catch(FormatException){
                Console.WriteLine("Input not valid, just accept integer number");
            }
        }
    }
}