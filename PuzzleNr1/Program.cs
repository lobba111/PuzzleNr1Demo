// See https://aka.ms/new-console-template for more information
int[] sampleData = new int[]{103,106,107,106,121,132,147,148,144,141};
List<int> increased = new List<int>();
List<int> decreased = new List<int>();

for (int i = 0; i < sampleData.Length-1; i++)
{
    
    if (sampleData[i] < sampleData[i+1])
    {
        Console.WriteLine("INCREASED");

        increased.Add(i);
    }
    else if (sampleData[i] >sampleData[i+1])
    {
        Console.WriteLine("decreased");
        decreased.Add(i);
    }
}
Console.WriteLine(increased.Count);
Console.WriteLine(decreased.Count);














































