namespace 字母异位词分组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Resolution
    {
            public IList<IList<string>> GroupAnagrams(string[] strs)
            {
                Dictionary<string, IList<string>> dict = new Dictionary<string, IList<string>>();
                foreach (string str in strs)
                {
                    char[] chars = str.ToCharArray();
                    Array.Sort(chars);
                    string key = new string(chars);
                    if (!dict.ContainsKey(key))
                    {
                        dict.Add(key, new List<string>());
                    }
                    dict[key].Add(str);
                }
                return new List<IList<string>>(dict.Values);
        }
    }
}
