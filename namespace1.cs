// to compile this file, we have to compile namespaces.cs which contain MyNamespace namespace otherwise cs compiler has no idea that the namespace exist and what it do.

using MyNamespace;
using System;
class MyProgram{
    static void Main(){
        Myclass a = new Myclass();
        a.SayHello();
    }
}