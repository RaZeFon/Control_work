using System;
using static System.Console;

class ControlWork{
    public static void Main(){
        string[] myArray1 = new string[] {"Hello", "2", "world", ":-)"};
        string[] myArray2 = new string[] {"1234", "1567", "-2", "computer science"};
        string[] myArray3 = new string[] {"Russia", "Denmark", "Kazan"};
        int size = 3;

        WriteLine($"Массив из строк не длинее трех символов");
        SearchArray(myArray1, size);
        SearchArray(myArray2, size);
        SearchArray(myArray3, size);

        void SearchArray(string[] myArray, int lenString){
            string[] result = new string [myArray.Length];
            for (int i = 0; i < myArray.Length; i++){
                if (myArray[i].Length <= lenString) {
                    result[i] = myArray[i];
                }
            }

            foreach (string ch in result){
                Write($"{ch} ");
            }
            WriteLine("");
            }
    }
}


