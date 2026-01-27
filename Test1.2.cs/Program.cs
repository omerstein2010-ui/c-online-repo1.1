using System;
class Program
{
    public static void tsk1(string str)
    {
        string str2=$"{str.IndexOf("ab")} {str.IndexOf("bc")} {str.IndexOf("cd")} {str.IndexOf("de")} {str.IndexOf("ef")} {str.IndexOf("fg")} {str.IndexOf("gh")} {str.IndexOf("hi")} {str.IndexOf("ij")} {str.IndexOf("jk")} {str.IndexOf("kl")} {str.IndexOf("lm")} {str.IndexOf("mn")} {str.IndexOf("no")} {str.IndexOf("op")} {str.IndexOf("pq")} {str.IndexOf("qr")} {str.IndexOf("rs")} {str.IndexOf("st")} {str.IndexOf("tu")} {str.IndexOf("uv")} {str.IndexOf("vw")} {str.IndexOf("wx")} {str.IndexOf("xy")} {str.IndexOf("yz")}";
        str2=str2.Replace("-1","");
        System.Console.WriteLine($"len={str2.Length}");
        for(int i = 0; i < str2.Length; i++)
        {
            // System.Console.WriteLine($"str2[i]={str2[i]}");
            if(str2[i]!=' ')
            {
                string str3=str.Substring(int.Parse($"{str2[i]}"),2);
                System.Console.WriteLine($"str3={str3}");
            }
            // if (str2[i])
            // {
            //     System.Console.WriteLine("shalom ani bomer");
            // }
        }
    }
    public static int tsk2(string str,string w)
    {
        int n2=0;
        while (str.Contains(w) == true)
        {
            n2+=1;
            int x=str.IndexOf($"{w}");
            str=$"{str.Substring(0,x-1)} {str.Substring(x+6)}";
            int n=str.Length-str.Substring(0,x).Length;
            if (n == w.Length)
            {
                str=str.Substring(0,x);
            }
            System.Console.WriteLine(str);
            System.Console.WriteLine(n);
            System.Console.WriteLine(x);

        }
        return n2;
    }
    public static string tsk3(string str,string str2, string str3)
    {
        if (str.Contains(str2))
        {
            str=str.Replace(str2,str3);
        }   
        return str;
    }
    public static void Main(string[] args)
    {
        tsk1("abcd");
        tsk2("shalom ani bomer bomer", "bomer");
        System.Console.WriteLine(tsk3("And he told us of his life in the land of submarines.","And","and"));
    }
}