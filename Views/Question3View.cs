using LogicAlgorithm.Services;
using LogicAlgorithm.Utils;

namespace LogicAlgorithm.Views
{
    public class Question3View
    {
        public static void Run(){
            try{
                Console.WriteLine("Enter numbers ex(12,9,13,6,10,4,7,2): ");
                List<string> input = Console.ReadLine().Split(",").ToList();
                List<int> inputInt = Util.ArrayStringToInt(input);

                Question3Service.Question1(inputInt);
            }catch(FormatException){
                Console.WriteLine("Input just accept number and format must have ',' for number divider.");
            }
        }
    }
}