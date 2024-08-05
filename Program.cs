using System.IO;
class Program{
    static void GetCombinations(string input,string prefix,int start,int length,List<string>combinations)
    {
        if(length==0)
        {
            combinations.Add(prefix);
            return;
        }
        for(int i=start;i<input.Length;i++)
        {
            GetCombinations(input,prefix+input[i],i+1,length-1,combinations);
            GetCombinations(input,input[i]+prefix,i+1,length-1,combinations);

        }

    }

     static void GetPermutations(string input, string prefix, int length, HashSet<string> permutations)
    {
        if (prefix.Length == length)
        {
            permutations.Add(prefix);
            return;
        }

        for (int i = 0; i < input.Length; i++)
        {
            GetPermutations(input, prefix + input[i], length, permutations);
        }
    }
    static void Main()
    {
        string input="0123456789";
        string filePath="combination.txt";
        HashSet<string>permutations=new HashSet<string>();
        GetPermutations(input,"560",4,permutations);
        File.WriteAllLines(filePath,permutations);

        System.Console.WriteLine(string.Join("\n",permutations));

    }
}