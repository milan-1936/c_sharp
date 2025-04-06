using System;
using System.IO;

class MyIoStreams{
    static void Main(){
        string path = "D:\\C#\\c_sharp\\text.txt";
        // Create a file and write to it
        File.WriteAllText(path, "Hello World!\nThis is a test file");
        string [] lines = File.ReadAllLines(path);

        // display the content of the file
        Console.WriteLine("Contents of te file:");
        foreach(string line in lines){
            Console.WriteLine(line);
        }
    }
}