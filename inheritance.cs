using System;
class Veichel{
    public void two_wheeler(){
        Console.WriteLine("This parent class");
    }
}

class Bike:Veichel{
    public void TVS(){
        Console.WriteLine("This is child class");
    }

    public static void Main(){
        Bike b= new Bike();
        b.TVS();
        b.two_wheeler();
    }
}