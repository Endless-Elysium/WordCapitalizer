namespace StringConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string g = Convert(Console.ReadLine());
            Console.WriteLine(g);
        }

        static string Convert(string s) 
        { 
            string[] Out = s.Split(" ");
            string c;
            for (int i = 0; i < Out.Length; i++)
            {
                c = Out[i];
                c = c.Replace(c[0], Char.Parse(c[0].ToString().ToUpper()));
                Out[i] = c;
            }
            string result = "";
            for (int i = 0;i < Out.Length;i++)
            {
                result += Out[i] + " ";
            }
            return result;
        }
    }
}