namespace StringConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text");
            string g = Convert(Console.ReadLine());
            Console.WriteLine(g);
        }

        static string Convert(string s) 
        { 
            string[] Out = s.Split(" ");
            if (Out == null) return "No vaild text found";
            string c;
            for (int i = 0; i < Out.Length; i++)
            {
                if (Out[i] == "" || Out[i] == " ")
                {
                    i++;
                }
                try
                {
                    if (Out[i] == "" || Out[i] == " ") return "No vaild text found";
                } catch { return "No vaild text found"; }
                
                c = Out[i];
                string b = c[0].ToString().ToUpper();
                c = c.Remove(0, 1);
                c = c.Insert(0, b);
                //c = c.Replace(c[0], Char.Parse(c[0].ToString().ToUpper()));
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