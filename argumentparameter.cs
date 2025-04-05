using System;
class Hello{
    public static void Main(){
        int a, b;
        Console.WriteLine("Enter first number:");
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        b = Convert.ToInt32(Console.ReadLine());

        // Calling sum function
        Console.WriteLine("the sum of "+ a+ " and "+ b + " is " + sum(a, b));
    }

    public static int sum(int a, int b){
        return a+b;
    }
}