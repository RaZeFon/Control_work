using System;
using static System.Console;

class ControlWork{
    static void Main(){
        string[] myArray1 = new string[] {"Hello", "2", "world", ":-)"};
        //string[] myArray2 = ["1234", "1567", "-2", "computer science"];
        //string[] myArray3 = ["Russia", "Denmark", "Kazan"];
        //string[] myArray = new static[] {};
        int lenString = 3;


        string[] result = new string [myArray1.Length];
        for (int i = 0; i < myArray1.Length; i++){
            if (myArray1[i].Length <= lenString) {
                result[i] = myArray1[i];
            }
        }

        WriteLine($"Массив из строк не длинее трех символов");
        foreach (string ch in result){
            Write($"{ch} ");
        }
        WriteLine("");
    }
}


