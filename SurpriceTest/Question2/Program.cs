using System;
namespace Question2;

        public class Program
        {
            public static void Main(string[] args)
            {

                string a="hello naeh";
                char[] ch=a.ToCharArray();
                string res="";
                for(int i=0;i<ch.Length;i++)
                {
                    for(int j=i+1;j<ch.Length;j++)
                    {
                        if(a[i]==a[j] && i!=j)
                        {
                            char z=a[i];
                            int ascii=(int)z;
                            ascii-=32;
                            char z1=(char)ascii;
                            a.Replace(z,z1);

                        }
                    }
                }
                foreach(char i in a)
                {
                    Console.WriteLine(i);
                }
            }
        }
            