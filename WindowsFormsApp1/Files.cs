using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal interface IRead
    {
        void read(string patch, ArraysAB a);
    }

    internal interface IWrite
    {
        void write(string patch, ArraysAB a);
    }

    internal class FileRead : IRead
    {
        public void read(string patch, ArraysAB a)
        {
            using (StreamReader sr = new StreamReader(patch, System.Text.Encoding.Default)) 
            {
                string line = "";
                try
                {
                    int i = 0;

                    while ((line = sr.ReadLine()) != null)
                    {
                        a.a[i] = Convert.ToInt32(line);
                        i++;
                    }
                    a.Length = i;
                    sr.Close();
                }
                catch
                {
                    throw new AccessViolationException("Error in a file");
                }
            }
        }
    }

    internal class FileWrite : IWrite
    {
        public void write(string patch, ArraysAB a)
        {
            using (StreamWriter sw = new StreamWriter(patch, false, System.Text.Encoding.Default))
            {
                foreach (var item in a.b)
                {
                    sw.WriteLine(item.ToString());
                }
                sw.Close();
            }
        }
    }

    public class ArraysAB
    {
        public int[] a;
        public int[] b;
        int length = 0;

        public int Length { get { return length;} set { length = value;} }

        public ArraysAB(int n)
        {
            a = new int[n];
        }

        public void calculate()
        {
            Array.Resize(ref a, length);
            int j = 0, jj = 0;
            int[] b1 = new int[length];
            int[] b2 = new int[length];
            int MaxIndex = 0;
            int MaxValue = a[0];

            for (int i = 1; i < length; i++)
            {
                if (a[i] > MaxValue)
                {
                    MaxValue = a[i];
                    MaxIndex = i;
                }
            }

            for (int i = 0; i < length; i++)
            {
                if (i == MaxIndex)
                {
                    b2[jj] = a[i];
                    jj++;
                }
                else
                {
                    b1[j] = a[i];
                    j++;
                }
            }

            Array.Resize(ref b1, j);
            Array.Resize(ref b2, jj);
            b = new int[length];

            b = b1.Concat(b2).ToArray();
        }
    }

    internal class ShowArray
    {
        public string writeArray(int[] array)
        {
            string s = "";
            foreach (int i in array)
            {
                s += i.ToString()+" ";
            }

            return s;
        }
    }
}
