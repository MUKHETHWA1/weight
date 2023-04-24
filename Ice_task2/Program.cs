public class Program
{
    public static void Main(string[] args)
    {
        string name;
        double weight ;
        double endWeight ;
        double sum;
       


        Console.Write("Enter name <Or zzz to stop: ");
        name = Console.ReadLine();
       


        while (name != "zzz") {
            Console.Write("Start weight for {0}: ", name);
            weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("End weight for {0}: ", name);
            endWeight = Convert.ToDouble(Console.ReadLine());
            sum = weight - endWeight;

            if (weight > endWeight)
            {
                Console.WriteLine("{0}, you lost {1} kg", name, sum);
                
            }
            else
            {
                if (weight < endWeight)
                {
                    Console.WriteLine("{0}, you gained {1} kg", name, sum);
                    
                }
                else
                {
                    Console.WriteLine("{0}, you lost no weight {1} kg", name , sum);
                    
                }
            }
           


            Console.Write("Enter name <Or zzz to stop: ");
            name = Console.ReadLine();
           
        }
        Console.WriteLine("1 lost weight");
        Console.WriteLine("1 gained weight");
        Console.WriteLine("1 stayed the same");

    }
}