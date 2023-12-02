namespace AdventOfCode2023.obj.day1;

public class day1
{
    public static void Main(string[] args)
    {
        List<string> lines = AdventUtils.ReadTextFile("input.txt", 1);

        int sum = 0;

        foreach (var line in lines)
        {
            int first = -1;
            int last = -1;
            
            foreach (int c in line)
            {
                int value = c - 48;
                if (value < 10)
                {
                    if (first == -1)
                    {
                        first = value;
                        last = value;
                    }
                    else
                    {
                        last = value;
                    }
                }
                
            }

            int number = first * 10 + last;
            sum += number;
        }
        
        Console.WriteLine(sum);
    }
}