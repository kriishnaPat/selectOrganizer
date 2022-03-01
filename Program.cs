using System;

namespace selectionSort
{
    class Program
    {
        static int selectionSort(int[] anArray){
            for(int i=0; i<anArray.Length-1; i++){
                int min = i;
                for(int n=i+1; n<anArray.Length; n++){
                    if(anArray[n] < anArray[min]){
                        min = n;
                    }
                }
                int t = anArray[min];
                anArray[min] = anArray[i];
                anArray[i] = t;
            }
            foreach (int x in anArray)
                Console.Write(x + "  ");
            return 0;
        }
        static int selectionSortStr(string[] anArray){
            for(int i=0; i<anArray.Length-1; i++){
                int min = i;
                for(int n=i+1; n<anArray.Length; n++){
                    if(anArray[n].CompareTo(anArray[min])> 0){
                        min = n;
                    }
                }
                string t = anArray[min];
                anArray[min] = anArray[i];
                anArray[i] = t;
            }
            foreach (string x in anArray)
                Console.Write(x + "  ");
            return 0;
        }
        static void Main(string[] args)
        {
            int[] nums = {10, 70, 30, 100, 40, 45, 90, 80, 85};
            selectionSort(nums);
        }
    }
}
