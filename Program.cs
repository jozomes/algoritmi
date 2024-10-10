
internal class Program
{
    private static void Main(string[] args)
    {
      Dictionary<string,int> dict = new Dictionary<string,int>();
        Console.WriteLine("Unos teksta");
        string tekst = Console.ReadLine();
        string rijec = "";
        foreach (char item in tekst)
        {
            if (Char.IsWhiteSpace(item) || item == '.')
            {
                string dodaj = rijec.ToLower();
                if (dict.ContainsKey(dodaj))
                {
                    dict[dodaj]++;
                }
                else
                {
                    dict[dodaj] = 1;
                }
                Console.WriteLine(rijec);
                rijec = "";
                continue;
            }
            else
            {
                rijec += item;
            }

        }
        int maxx = 0;
        string trazena = "";
        foreach (string item in dict.Keys)
        {
            if (dict[item] > maxx)
            {
                trazena = item;
                maxx = dict[item];
            }
        }
        Console.WriteLine(dict[trazena]);
        Console.WriteLine(trazena); 

    }
}