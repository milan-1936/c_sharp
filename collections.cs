using System;
using System.Collections;

class Program{
    static void Main(){
        Hashtable Students = new Hashtable();
        Students.Add(101, "Sabin");
        Students.Add(102, "Subash");
        Students.Add(103, 25);

        foreach(DictionaryEntry entry in Students){
            Console.WriteLine("key"+ entry.Key + "Value" + entry.Value);
        }
    }
}