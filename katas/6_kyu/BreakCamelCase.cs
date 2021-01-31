using static System.Text.RegularExpressions.Regex;

namespace CodeWarsKatas.katas._6_kyu
{
    // https://www.codewars.com/kata/5208f99aee097e6552000148/train/csharp
    public class BreakCamelCase
    {
        public static string BreakCamelCasE(string str)=> Replace(str, "([A-Z])", " $1");
    }
}