using System;

public class Class1
{
	public Class1()
	{
        // P1035 级数求和
        int K = int.Parse(Console.ReadLine());
        double sum = 0;
        double n;
        Console.WriteLine("000");
        for (double i = 0;i<10 ; i++)
        {
            // sum += (1 / i);
            Console.WriteLine("000");
            if(sum>K){
                n = i;
                Console.WriteLine(n);
                break;
            }
        }
        
    }
}
