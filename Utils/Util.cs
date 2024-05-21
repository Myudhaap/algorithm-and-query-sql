namespace LogicAlgorithm.Utils
{
    public class Util
    {
        public static void BubbleSort(List<int> n, bool asc){
            while(true){
                int counter = 0;
                for(int i = 0; i < n.Count - 1; i++){
                    if(asc){
                        if(n[i] > n[i + 1]){
                            (n[i], n[i + 1]) = (n[i+1], n[i]); 
                            counter++;
                        }
                    }else{
                        if(n[i] < n[i + 1]){
                            (n[i], n[i + 1]) = (n[i+1], n[i]); 
                            counter++;
                        }
                    }
                }

                if(counter == 0) break;
            }
        }

        public static void PrintArray<T>(List<T> arr){
            Console.WriteLine($"n: [{string.Join(",", arr).ToString()}]");
        }

        public static List<int> ArrayStringToInt(List<string> arr){
            List<int> resArr = new List<int>();

            foreach(var v in arr){
                resArr.Add(int.Parse(v));
            }

            return resArr;
        }
    }
}