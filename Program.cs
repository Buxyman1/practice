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
char[] leter = new char[] { 'a', 'o', 'b' };
string str = "BAOBAB";
Console.WriteLine(CanBuildFrom(leter, str));