namespace Homework3;
class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("------Question 1------");
        Console.WriteLine("Input an integer:");
        int N = Convert.ToInt16(Console.ReadLine());
        int a = 0;
        for(int i=1; i<= N;i++){
            if(N%i==0){
                a++;
            }
        }
        if(a==2){
            Console.WriteLine("N is Prime");
        }
        else{
            Console.WriteLine("N is non-prime");
        }
    
        }
}
class Program2
{
    static void Main(string[] args)
    {
      Console.WriteLine("------Question 2------");
        Console.WriteLine("Assign an int value to N:");
        int N = Convert.ToInt16(Console.ReadLine());
    for(int row =0 ;row<N; row++){
        for(int col= 0; col<N; col++)
    {
        Console.Write('#');
    }
    Console.WriteLine("");
    }
    }
}

class Program3
{
    static void Main(string[] args)
    {
      Console.WriteLine("------Question 3------");
        Console.WriteLine("Assign an int value to N:");
        int N = Convert.ToInt16(Console.ReadLine());
    for(int row =0 ;row<N; row++){
        for(int col= 0; col<N; col++)
    {
        if(row>=col)
        Console.Write('*');
    }
    Console.WriteLine("");
    }
    }
}