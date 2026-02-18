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
    public static void tsk5(string str)
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
    public static void tsk6()
    {
        string s="";
        int n2=0;
        int[] l1={1,32,64,128,128,127,128,128};
        int mx=l1[0];
        int mn=l1[0];
        for(int i = 1; i < l1.Length; i++)
        {
            int n=l1[i];
            mx=Math.Max(mx,n);
            mn=Math.Min(mn,n);
        }
        System.Console.WriteLine($"mn={mn}, mx={mx}");
        for(int j = 0; j < l1.Length; j++)
        {
            if (l1[j] == mx)
            {
                s+=$"{j} ";
                n2+=1;
            }
        }
        System.Console.WriteLine(n2);
        System.Console.WriteLine(s);
    }   
    public static void tsk7()
    {
        int n3=0;
        int[] a=new int[10];
        for(int i = 0,j=1,x=3; i < 10 ; i++,j+=x,x+=2)
        {
            // System.Console.WriteLine(j);
            a[i]=j;
            n3+=1;
        }
        foreach(int n in a)
        {
            System.Console.WriteLine($"n={n}");
        }
        System.Console.WriteLine($"n3={n3}");
    } 
    public static void tsk8()
    {
        int[] a=new int[10];
        for(int i = 0, j = 2; i < 10; i++)
        {
            if (i % 2 != 0 && i > 0)
            {   j+=2;
                j*=-1;
            }
            if(i%2==0&&i>0)
            {
                if (j < 0)
                {
                  j*=-1;
                  j+=2;      
                }
                // j*=-1;
            }
            a[i]=j;
        }
    }
    public static void tsk9()
    {
        int[] a=new int[10];
        for(int i = 0, j = 7, k = 1; i < 10; i++, j += k, k++)
        {
            a[i]=j;
        }
        foreach(int n in a)
        {
            System.Console.WriteLine(n);
        }
    }
    public static void tsk10()
    {
        bool b=false;
        int[] l1={1,2,3,4,5,6,7,8,9,10};
        int mx=l1[0];
        for(int i = 1; i < 9; i++)
        {
            if (mx < l1[i])
            {
                mx=l1[i];
                b=true;
            }
            else
            {
                System.Console.WriteLine("it ain't ordered upwards");
            }
        }
        if (b == true)
        {
            System.Console.WriteLine("it's ordered upwards");
        }
    }
    public static void tsk11()
    {
        Random r=new Random();
        int r2=r.Next(3,13);
        System.Console.WriteLine($"r2={r2}");
        int[] l1=new int[r2];
        int nl2=r2/3;
        int nl3=nl2*2;
        int[] l2=new int[nl2];
        int[] l3=new int[nl2];
        int[] l4=new int[nl2];
        int[] rlt=new int[nl2];
        for(int i = 0; i < r2; i++)
        {
            if (i % 3 == 0)
            {
                int n3=r.Next(1,3);
                l1[i]=n3;
            }
            else
            {
                int n=r.Next();
                // System.Console.WriteLine(n);
                if (n % 3 == 0&&n>0)
                {
                    l1[i]=n;
                }
                else
                {
                    while (n % 3 != 0)
                    {
                        if (n != 0)
                        {
                            n=r.Next();
                            // System.Console.WriteLine($"n.sec={n}");    
                        }
                    }
                    if (n % 3 == 0)
                    {
                        l1[i]=n;
                    }                                     
                }
            }
        }
        for(int j = 0,j2=0; j2 < (l1.Length / 3); j += 3,j2++)
        {
            l2[j2]=l1[j];    
        }
        for(int j = 1,j2=0; j2 < (l1.Length / 3); j += 3,j2++)
        {
            l3[j2]=l1[j];    
        }
        for(int j = 2,j2=0; j2 < (l1.Length / 3); j += 3,j2++)
        {
            l4[j2]=l1[j];    
        }
        for(int l = 0; l < nl2; l++)
        {
            if (l2[l] == 1)
            {
                rlt[l]=l3[l]+l4[l];
            }
            else if (l2[l] == 2)
            {
                rlt[l]=l3[l]-l4[l];
            }
        }
        System.Console.WriteLine("shalom ani bomer");
        foreach(int n2 in l1)
        {
            System.Console.Write($"n2={n2} ");
        }
        System.Console.WriteLine("\n");
        foreach(int n4 in l2)
        {
            System.Console.WriteLine($"n4={n4}");
        }
        System.Console.WriteLine("\n");
        foreach(int n8 in l3)
        {
            System.Console.WriteLine($"n8={n8}");
        }
        System.Console.WriteLine("\n");
        foreach(int n9 in l4)
        {
            System.Console.WriteLine($"n9={n9}");
        }
        System.Console.WriteLine("\n");
        foreach(int n10 in rlt)
        {
            System.Console.WriteLine($"n10={n10}");
        }       
    }
    public static void Main(string[] args)
    {
        tsk1("abcd");
        tsk2("shalom ani bomer bomer", "bomer");
        System.Console.WriteLine(tsk3("And he told us of his life in the land of submarines.","And","and"));
        tsk5("abcd");
    }
}