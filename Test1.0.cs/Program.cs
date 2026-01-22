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
    
    public static void tsk3(int num)
    {
        
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
    public static void Main(string[] args)
    {
        tsk2(5,2);   
    }
}