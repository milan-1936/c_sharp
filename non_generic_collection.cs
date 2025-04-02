using System;
using System.Collections.Generic;
class NonGenericCollection{
    static void Main(){
        List<int> numbers = new List<int>();
        numbers.Add(15);
        numbers.Add(25);
        numbers.Add(20);

        foreach(int num in numbers){
            Console.WriteLine("Number"+ num);
        }
    }
}