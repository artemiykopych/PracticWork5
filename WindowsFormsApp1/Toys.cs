using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public class Toy : IComparable
    {
        int price;
        string name;
        int ager;

        public Toy (string name, int price, int ager)
        {
            Price = price;
            this.name = name;
            AgeR = ager;
        }

        public Toy()
        {
            this.name = "Петро";
            var r = new Random();
            this.price = r.Next(200, 1000);
            this.ager = r.Next(0, 18);
        }

        public string Name { get { return this.name; } set { this.name = value; } }

        public int Price { get { return this.price;}
            set 
            { 
                if (value > 0)
                {
                    this.price = value;
                }
                else throw new ArgumentException("Age <= 0");
            }
        }

        public int AgeR { get { return this.ager;}
            set
            {
                if (value > 0)
                {
                    this.ager = value;
                }
                else throw new ArgumentException("Weight <- 0");
            }
        }

        public int CompareTo(object obj)
        {
            Toy p = obj as Toy;

            return ager.CompareTo(p.ager);
        }
    }

    internal class SortByPrice : IComparer<Toy>
    {
        public int Compare(Toy x, Toy y)
        {
            if (x.Price < y.Price) return -1;
            if (x.Price > y.Price) return 1;
            return 0;
        }
    }

    internal class Toys
    {
        public List<Toy> toys = new List<Toy>();

        XmlSerializer serializer = new XmlSerializer(typeof (List<Toy>));

        public void add(Toy toy)
        {
            toys.Add(toy);
        }

        public void remove(int i)
        {
            toys.RemoveAt(i);
        }

        public void sort()
        {
            SortByPrice sa = new SortByPrice();
            toys.Sort(sa);
        }

        public void writeFile(string fileName)
        {
            FileStream fstream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
            serializer.Serialize(fstream, toys);
            fstream.Close();
        }

        public void readFile(string fileName)
        {
            FileStream fstream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.None);
            toys = serializer.Deserialize(fstream) as List<Toy>;
            fstream.Close();
        }
    }
}
