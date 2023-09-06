using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




public class MyBaseClass
{
    protected void MyProtectedMethod()
    {
        Console.WriteLine("This is a protected method.");
    }
}


public class MyDerivedClass : MyBaseClass
{
    public void AccessProtectedMethod()
    {
        
        MyProtectedMethod();
    }
}

class Program
{
    static void Main()
    {
       
        MyDerivedClass derivedObj = new MyDerivedClass();

        
        derivedObj.AccessProtectedMethod();

        
    }
}
