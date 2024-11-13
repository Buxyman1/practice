using Microsoft.AspNetCore.StaticFiles.Infrastructure;

bool CanBuildFrom(char[] leter, string str)
{
    Dictionary<int, int> Dic = new Dictionary<int, int>();
    for (int i = 0; i < leter.Length; i++)
    {
        if (Dic.ContainsValue(Convert.ToInt32(leter[i])))
        {
            continue;
        }
        else
        {
            if (Convert.ToInt32(leter[i]) >= 97)
            {
                Dic.Add(Convert.ToInt32(leter[i]), Convert.ToInt32(leter[i]) - 32);
            }
            else
            {
                Dic.Add(Convert.ToInt32(leter[i]), Convert.ToInt32(leter[i]) + 32);
            }
        }
    }
    for (int i = 0; i < str.Length; i++)
        if (!Dic.ContainsKey(Convert.ToInt32(str[i])) && !Dic.ContainsValue(Convert.ToInt32(str[i])))
        {
            return false;
        }
    return true;
}
Dictionary<char, int>  extractRepeats(char[] charMas)
{
    Dictionary<char, int> returnalDictionary = new Dictionary<char, int>();
    Array.Sort(charMas);
    int Temp = 1;
    for(int i = 0; i < charMas.Length - 1; i++)
    {
        if(charMas[i] == charMas[i+1]) 
            Temp++;
        else
        {
            if(Temp > 1)
            {
                returnalDictionary.Add(charMas[i], Temp);
                Temp = 1;
            }
        }
    }
    return returnalDictionary;
}

char[] a = new char[]{'a'};
Dictionary<char, int> dic = extractRepeats(a);
foreach(var b in dic)
{
    Console.WriteLine(b.Key + "   " + b.Value);
}