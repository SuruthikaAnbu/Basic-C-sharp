using System;

        public class Program
        {
            public static void Main(string[] args)
            {
                string a="helloe";
                /*
                string b="";
                for(int i=0;i<a.Length;i++)
                {
                    for(int j=i;j<a.Length;j++)
                    {
                        if(a[i]==a[j] && i!=j)
                        {
                            a=a.Remove(2,1);
                        }
                        
                    }
                }
                */
                Console.WriteLine(a.Remove(1,2));
            }
        }
            