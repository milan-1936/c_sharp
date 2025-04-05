using System;
class Array_sort{
    public static void Main(){
        string[] name = new string[5];
        Console.WriteLine("Enter the names: ");
        for(int i = 0; i<5; i++){
            name[i] = Console.ReadLine();
        }

        Array.Sort(name);

        Console.WriteLine("Sorted Names are");
        for(int i=0; i<5; i++){
            Console.WriteLine(name[i]);
        }
    }
}