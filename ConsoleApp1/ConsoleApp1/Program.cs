using System.Threading.Channels;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {

            SuperDictionary<string, int, string> d = new SuperDictionary<string, int, string>();
            d.Add("Gilad", 15, "info");
            Console.WriteLine(d.Get("info", 0));
            Console.WriteLine(d.Get("info", 1));


        }
    }
    public static class Shit
    {
        //public static void Print(this string s, string m, string n) => Console.WriteLine(s + m + n);
        public static int toInt(this string s) => int.Parse(s);
        public static string ask(this string s) { Console.WriteLine(s); return Console.ReadLine();}
        
    }
    public class SuperDictionary<T1, T3, T2>
    {
        public T1[] vals = new T1[0];
        public T2[] keys = new T2[0];
        public T3[] vals2 = new T3[0];
        public int Length { get { return vals.Length;} }
        public void Add(T1 t1, T3 t3, T2 t2)
        {
            T1[] res1 = new T1[this.vals.Length + 1];
            T3[] res2 = new T3[this.vals2.Length + 1];
            T2[] keys2 = new T2[this.keys.Length + 1];
            int np = this.vals.Length;
            for(int i = 0; i < this.keys.Length; i++)
            {
                res1[i] = this.vals[i];
                res2[i] = this.vals2[i];
                keys2[i] = this.keys[i];
            }
            if (keys.Contains(t2)) { throw new InsufficientMemoryException(); }
            res1[np] = t1;
            res2[np] = t3;
            keys2[np] = t2;
            this.vals = res1;
            this.vals2 = res2;
            this.keys = keys2;
        }
        public object Get(T2 key, int n)
        {
            return (n == 0) ? this.vals[Find(key)] : this.vals2[Find(key)];
        }

        public int Find(T2 Key)
        {
            for (int i = 0; i < this.keys.Length; i++)
                if (this.keys[i].Equals(Key))
                    return i;
            return -1;
        }
        //add delete func
    }
}