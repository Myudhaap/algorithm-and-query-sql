using LogicAlgorithm.Utils;

namespace LogicAlgorithm.Services
{
    public class Question3Service
    {
        public static void Question1(List<int> n){
            while(true){
                int counter = 0;
                
                for(int i = 0; i < n.Count; i++){
                    if(n[i] % 3 == 0) {
                        n.RemoveAt(i);
                        counter++;
                    }
                }

                if(counter == 0) break;
            }

            Util.BubbleSort(n, true);
            Util.PrintArray<int>(n);
        }
    }
}