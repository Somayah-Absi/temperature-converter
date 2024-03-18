using System;

class Program
{
    public static string TempConvert (int x, string y)
    {
          int converter=0;
        string newTemp="";
    if(y=="c"){
converter=(x*9/5)+32;
newTemp="f";
        
    }else if(y=="f"){
        converter=(x-32)*9/5;
newTemp="c";
    }
    return $"{converter} {newTemp}";
    }
    

    public static void Main(string[] args)
    {
       
        
        Console.WriteLine(TempConvert(100,"c"));

       
        
    }
}