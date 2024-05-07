internal class Program
{
    private static void Main(string[] args)
    {
        int M;
        Random random = new Random();

        int N = random.Next(0, 9);

        Console.WriteLine("Nhap 1 so M bat ky tu ban phim co gia tri 0 den 9:");
        M = Convert.ToInt32(Console.ReadLine());
        if (N==M)
        {
            Console.WriteLine("Du doan dung");
        }
        else
        {
            Console.WriteLine("Du doan sai");
        
        }    
        Console.WriteLine("Vi so ngau nhien la: {0} , va so ban cho la {1}", N, M) ;
    }
}