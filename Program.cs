using System.CodeDom.Compiler;

class mains 
{ 



private static void generated(int i)
{
    
    String s = "";
    String ss = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ#____";
    Random rnd = new Random();
    try
    {
        
        for (int j = 0; j < i; j++)
        {

            for (int ii = 0; ii < 12; ii++)
            {
                s = s + ss[rnd.Next(ss.Length - 3)];
            }
            s = s + "\r\n";
        }
        Console.WriteLine(s);
    }
    catch (Exception ex)
    {
            Console.WriteLine("size error");
    }
}

    public static void mainloop(int i) 
    {

        generated(i);
    
    
    
    
    }  



}









class passgene
{
    public static void Main() 
    {
    
    
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        mains.mainloop(10);
    
    
    }

}

