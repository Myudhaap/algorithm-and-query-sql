using System.Text;

namespace LogicAlgorithm.Services
{
    public class Question2Service
    {
        public static void Question2TypeA(int n){
            for(int row = 1; row <= n; row++){
                StringBuilder res = new StringBuilder();
                for(int col = 1; col <= row; col++){
                    res.Append(Convert.ToString(row).PadRight(4));
                }
                Console.WriteLine(res.ToString());
            }
        } 

        public static void Question2TypeB(int n){
            for(int row = 1; row <= n; row++){
                StringBuilder res = new StringBuilder();
                for(int col = row; col > 0; col--){
                    res.Append(Convert.ToString(col).PadRight(4));
                }
                Console.WriteLine(res.ToString());
            }
        }  

        public static void Question2TypeC(int n){
            int currVal = 1, counter = 0; 

            for(int row = 1; row <= n; row++){
                StringBuilder res = new StringBuilder();
                for(int col = 1; col <= row; col++){
                    if(counter == 0){
                        res.Append(Convert.ToString(currVal++).PadRight(4));
                        if(currVal == n) counter = 1;
                    }else{
                        res.Append(Convert.ToString(currVal--).PadRight(4));
                        if(currVal == 1) counter = 0;
                    }
                }
                Console.WriteLine(res.ToString());
            }
        }

        public static void Question2TypeD(int n){
            for(int row = 1; row <= n; row++){
                StringBuilder res = new StringBuilder();

                for(int col = 1; col <= n; col++){
                    if(col % 2 != 0){
                        if(col == 1) res.Append(Convert.ToString(row).PadRight(4));
                        else{
                            int currVal = n * col - n + row;
                            res.Append(Convert.ToString(currVal).PadRight(4));
                        }
                    }else{
                        int currVal = n * col - (row - 1);
                        res.Append(Convert.ToString(currVal).PadRight(4));
                    }
                }

                Console.WriteLine(res.ToString());
            }
        }
    }
}