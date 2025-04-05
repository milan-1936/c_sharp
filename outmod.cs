using System;
class OutModifier{
    public static void OutMod(out int x, out int y){
        
        
        x = 10;
        y= 20;
        // add pointer of variable x


        Console.WriteLine("after editing on Main() function");
        Console.WriteLine(x);
        Console.WriteLine(y);
    }
    public static void Main(){
        int a, b;
        OutMod(out a, out b);
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b); 
        a++;
        b++;
       
        
    }
}