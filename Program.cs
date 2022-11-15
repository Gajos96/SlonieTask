using System.Data;

public class NewClass
{
    public static void Main(string[] args)
    {
        int amout;
        int weigtmin = int.MaxValue;
        long valuecount = 0;
        amout = int.Parse(Console.ReadLine());
        int[] weigth = Console.ReadLine().Split(" ").Select(x => Convert.ToInt32(x)).ToArray();
        weigtmin = weigth.Min();
        int[] firstpostion = Console.ReadLine().Split(" ").Select(x => Convert.ToInt32(x) - 1).ToArray();
        var a = Console.ReadLine().Split(" ").Select(x => Convert.ToInt32(x) - 1).ToArray();
        int[] finalpostion = new int[amout];
        for (int i = 0; i < finalpostion.Length; i++)
        {
            finalpostion[a[i]] = firstpostion[i];
        }
        //
        bool[] arraybool = new bool[amout];
        for (int i = 0; i < amout; ++i)
        {
            if (!arraybool[i])
            {
                int b = i;
                int lenghcycle = 0;
                int sum = 0;
                int cyclemin = int.MaxValue;
                while (true)
                {
                    cyclemin = Math.Min(cyclemin, weigth[b]);
                    sum += weigth[b];
                    b = finalpostion[b];
                    arraybool[b] = true;
                    lenghcycle++;
                    if (b == i) break;
                }
                valuecount += Math.Min(sum + (lenghcycle - 2) * cyclemin, sum + cyclemin + (lenghcycle + 1) * weigtmin);
            }
        }
        Console.WriteLine(valuecount);
    }
}

//Zadanie Rekrutacyjne


