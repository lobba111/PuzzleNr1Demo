// See https://aka.ms/new-console-template for more information
int[] sampleData = new int[]{199,200,208,210,200,207,240,269,260,263};
List<int> increased = new List<int>();
List<int> decreased = new List<int>();

for (int i = 1; i < sampleData.Length; i++)
{
    
    if (sampleData[i] > sampleData[i-1] )
    {
        Console.WriteLine("{0} . INCREASED",sampleData[i]);

        increased.Add(i);
    }
    else if (sampleData[i] <sampleData[i+1])
    {
        Console.WriteLine("{0} . decreased", sampleData[i]);
        decreased.Add(i);
    }
    
}
Console.WriteLine(increased.Count);
Console.WriteLine(decreased.Count);














































