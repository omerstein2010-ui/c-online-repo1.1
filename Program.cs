using System;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
class Program
{
    public static void Main(string[] args)
    {
        bool b=false;
        string str="";
        string psw="";
        while (b!=true)
        {
            System.Console.WriteLine("what psw ya want enter?\n");
            psw=Console.ReadLine();
            for(int i = 0; i < psw.Length; i++)
            {
                if (Convert.ToInt32(psw[i])>=65&&Convert.ToInt32(psw[i])<=90)
                {
                    str+="u";
                }
                else if (Convert.ToInt32(psw[i]) >= 97 && Convert.ToInt32(psw[i]) <= 122)
                {
                    str+="l";
                }
                else if (Convert.ToInt32(psw[i]) >= 48 && Convert.ToInt32(psw[i]) <= 57)
                {
                    str+="n";
                }
                System.Console.WriteLine(str);
                if (str.Contains('l') == true && str.Contains('u') == true && str.Contains('n') == true&&psw.Length>=6)
                {
                    b=true;
                }
            }
        // if (psw.Contains('A' | 'B' | "c" | 'D' | 'E' | 'F' | 'G' | 'H' | 'I' | 'J' | 'K' | 'L' | 'M' | 'N' | 'O' | 'P' | 'Q' | 'R' | 'S' | 'T' | 'U' | 'V' | 'W' | 'X' | 'Y' | 'Z' & 'a' | 'b' | 'c' | 'd' | 'e' | 'f' | 'g' | 'h' | 'i' | 'j' | 'k' | 'l' | 'm' | 'n' | 'o' | 'p' | 'q' | 'r' | 's' | 't' | 'u' | 'v' | 'w' | 'x' | 'y' | 'z' & '0' | '1' | '2' | '3' | '4' | '5' | '6' | '7' | '8' | '9'))
        // {
        //     b=true;
        // }
        }
        // string s="'A'||'B'||'c'||'D'||'E'||'F'||'G'||'H'||'I'||'J'||'K'||'L'||'M'||'N'||'O'||'P'||'Q'||'R'||'S'||'T'||'U'||'V'||'W'||'X'||'Y'||'Z'";
        // string s2="";
        // for(int i = 0; i < s.Length; i++)
        // {
        //     // if()
        //     if (char.IsAsciiLetter(s[i]))
        //     {
        //         s2+=char.ToLower(s[i]);
        //     }
        //     else
        //     {
        //         s2+=s[i];
        //     }
        // }
        // System.Console.WriteLine(s2);
        // string s="'A' | 'B' | 'c' | 'D' | 'E' | 'F' | 'G' | 'H' | 'I' | 'J' | 'K' | 'L' | 'M' | 'N' | 'O' | 'P' | 'Q' | 'R' | 'S' | 'T' | 'U' | 'V' | 'W' | 'X' | 'Y' | 'Z' & 'a' | 'b' | 'c' | 'd' | 'e' | 'f' | 'g' | 'h' | 'i' | 'j' | 'k' | 'l' | 'm' | 'n' | 'o' | 'p' | 'q' | 'r' | 's' | 't' | 'u' | 'v' | 'w' | 'x' | 'y' | 'z' & '0' | '1' | '2' | '3' | '4' | '5' | '6' | '7' | '8' | '9'".Replace("'",""");
        // System.Console.WriteLine(s);
    }
}