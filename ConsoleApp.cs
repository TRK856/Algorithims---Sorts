namespace ConsoleApp
{
    public class Sort
    {
        static public void bubble(int[] anArray) {
            for (int numCompare = anArray.Length - 1; numCompare > 0; numCompare--) {
                for (int f = 0; f < numCompare; f++) {
                    if(anArray[f] > anArray[f+1]){
                        Utility.swap(anArray, f, f+1);
                    }
                }   
            }
        } 
        static public void bubble(string[] anArray) {
             for (int numCompare = anArray.Length - 1; numCompare > 0; numCompare--) {
                for (int f = 0; f < numCompare; f++) {
                    if(String.Compare(anArray[f], anArray[f+1]) > 0){
                        Utility.swap(anArray, f, f+1);
                    }
                }   
            }
        } 
        static public void selection(int[] anArray) {
            for (int i = 0; i < anArray.Length - 1; i++) {
                // Search for minimum
                int minPos = i;
                for (int f = minPos+1; f < anArray.Length; f++) {
                    if (anArray[minPos] > anArray[f]) {
                        minPos = f;
                    }
                }
                Utility.swap(anArray, i, minPos);
            }
        }
        static public void selection(string[] anArray) {
            for (int i = 0; i < anArray.Length - 1; i++) {
                // Search for minimum
                int minPos = i;
                for (int f = minPos+1; f < anArray.Length; f++) {
                    if (String.Compare(anArray[minPos], anArray[f]) > 0) {
                        minPos = f;
                    }
                }
                Utility.swap(anArray, i, minPos);
            }
        }
    }
    public class Utility
    {
        static public void writeAll(int[] anArray){
            Console.Write("[");
            for(int i = 0; i < anArray.Length-1; i++){
                Console.Write($"{anArray[i]}, ");
            }
            Console.WriteLine($"{anArray[anArray.Length - 1]}]");
        }
        static public void writeAll(string[] anArray){
            Console.Write("[");
            for(int i = 0; i < anArray.Length-1; i++){
                Console.Write($"{anArray[i]}, ");
            }
            Console.WriteLine($"{anArray[anArray.Length - 1]}]");
        }
        static public void swap(int[] anArray, int pos1, int pos2){
            int swap = anArray[pos1];
            anArray[pos1] = anArray[pos2];
            anArray[pos2] = swap;
        }
        static public void swap(string[] anArray, int pos1, int pos2){
            string swap = anArray[pos1];
            anArray[pos1] = anArray[pos2];
            anArray[pos2] = swap;
        }
    }
}