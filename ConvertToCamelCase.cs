using System;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Converter.ToCamelCase(args[0]));
    }
}

public static class Converter
{
    public static string ToCamelCase(string arg)
    {
        string result = "";
        string[] splitArg = arg.Split('-', '_');
        for(int i = 0; i < splitArg.Length; i++)
        {
            StringBuilder sb = new StringBuilder(splitArg[i]);

            if(i != 0)
            {
                sb[0] = char.ToUpper(sb[0]);
            }
            splitArg[i] = sb.ToString();
        }
        result = string.Join("", splitArg);
        return result;
    }
}