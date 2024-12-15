using System;
using System.Text;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string message1;
            message1 = "some value";
            Console.WriteLine(message1);

            string message2 = null;


            string message3 = string.Empty;

            string text = "He said: \"Hi\"";

            string windowLocation = "c:\\windows";

            string fontFolder = @"c:\windows\fonts";

            string concatenated = string.Concat(text, " to ", "me");
            string concatenated2 = text + " to " + "me";
            Console.WriteLine(concatenated);
            Console.WriteLine(concatenated2);

            string interpolated = $"{text} to me";
            Console.WriteLine(interpolated);

            StringBuilder sb = new StringBuilder("This");
            sb.Append(" is");
            sb.Append(" a");
            sb.Append(" program.");

            string result = sb.ToString();
            Console.WriteLine(sb);


        }
    }
}
