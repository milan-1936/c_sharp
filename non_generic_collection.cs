using System;
using System.Collections.Generic;
class NonGenericCollection{
    static void Main(){
        // this is generic actual ma ulto vayexa
        List<int> numbers = new List<int>();
        numbers.Add(15);
        numbers.Add(25);
        numbers.Add(20);

        foreach(int num in numbers){
            Console.WriteLine("Number: "+ num);
        }
    }
}