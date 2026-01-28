using System;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
class Program
{
    public static void mtsk1() //this's the main code for the func-method below, tsk1()
    {
        int x=0;
        for(int i = 0; i < 4; i++)
        {
            System.Console.WriteLine("what's the n of students who attended the lecucher?\n");
            int n=int.Parse(Console.ReadLine());
            System.Console.WriteLine(tsk1(n));
            x+=tsk1(n);    
        }
        System.Console.WriteLine(x/4);
    }
    public static int tsk1(int st)
    {
        int wg1=st/10*180;
        int wg2=(st-(st/10)*10)*5;
        int twg=wg1+wg2;
        return twg;
    }
    public static void tsk2(int n,int d)
    {
        string str1="";
        int n2=n;
        int i=0;
        while (n2 > 0)
        {
            int d2=n2%10;
            i+=1;
            n2/=10;
            if (d == d2)
            {
                str1+=$"{i} ";
                System.Console.WriteLine(i);
            }
        }
        if (str1 == "")
        {
            System.Console.WriteLine(0);
        }

    }
    public static int tsk22(string str,string w) //word swapin'
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
    public static string tsk3(string str,string str2, string str3)// contains code
    {
        if (str.Contains(str2))
        {
            str=str.Replace(str2,str3);
        }   
        return str;
    }
    public static void tsk5(string str)//rvrs str
    {
        int ind=0;
        string s3="";
        string s=str;
        string s4=s.Substring(ind,2);
        for(int n3=0;n3<(s.Length/2);n3++)
        {
            s4=s.Substring(ind,2);
            // System.Console.WriteLine($"s42={s4}");
            for(int i = 1, j = 0; j < s4.Length; j++, i++)
            {
                // System.Console.WriteLine($"s4={s4}");
                s3+=s4[^i];
                // System.Console.WriteLine($"s3={s3}");
            }
            // s.Remove(ind,2);
            ind+=2;
            // System.Console.WriteLine($"s={s}");
            
            // System.Console.WriteLine($"s42={s4}");
            
        }
        System.Console.WriteLine($"inv_str={s3}");
    }
    public static void Main(string[] args)
    {
        // tsk2(5,2);   
        tsk5("abcd");
    }
}