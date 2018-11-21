using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp24
{
    class List<T>
    {
        T[] list = new T[0];
        int cur = 0;
        public void Add(T data)
        {
            Array.Resize(ref list, list.Length + 1);
            list[cur] = data;
            ++cur;
        }
        public bool Contains(T data)
        {
            bool isContains = list.Contains(data);
            return isContains;
        }
        public void ShowAll()
        {
            foreach (var item in list)
            {
                Console.Write($" {item} ");
            }
        }

    }
    class MyDictionary<Tkey, Tvalue>
    {
        Tkey[] listkey = new Tkey[0];
        Tvalue[] listvalue = new Tvalue[0];
        int cur = 0;
        public void Add(Tkey keydata, Tvalue data)
        {
            bool isContains = listkey.Contains(keydata);
            if (!isContains)
            {
                Array.Resize(ref listvalue, listvalue.Length + 1);
                Array.Resize(ref listkey, listkey.Length + 1);
                listvalue[cur] = data;
                listkey[cur] = keydata;
                ++cur;
            }
            else
            {
                throw new Exception("KeyValue must be unique");
            }

        }
        public Tvalue this[Tkey keydata]{
            get
            {
                var data = Array.IndexOf(listkey, keydata);
                return listvalue[data];
            }
            set
            {
                bool isContains = listkey.Contains(keydata);
                var data = Array.IndexOf(listkey, keydata);
                if (isContains)
                {
                    listvalue[data] = value;
                }
                
            }
        }


        public void ShowAll()
        {
            foreach (var item in listkey)
            {
                Console.Write($" {item} ");
            }
            Console.WriteLine();
            foreach (var item in listvalue)
            {
                Console.Write($" {item} ");
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            //1
            //List<int> list = new List<int>();
            //list.Add(1); list.Add(2); list.Add(3); list.Add(4); list.Add(5);
            //list.ShowAll();
            //Console.WriteLine();
            //if (list.Contains(1))
            //{
            //    Console.WriteLine(" Yes");
            //}
            //else
            //{
            //    Console.WriteLine(" No");
            //}
            //2
            //MyDictionary<string, string> list = new MyDictionary<string, string>();
            //try
            //{
            //    list.Add("Kitab", "Book");
            //    list.Add("Alma", "Apple");
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}
            //list.ShowAll(); Console.WriteLine();
            //Console.WriteLine(list["Kitab"]);
            //list["Kitab"] = "Booookkk";
            //Console.WriteLine(list["Kitab"]);
            //Console.WriteLine();
        }
    }
}
