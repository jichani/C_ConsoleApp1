using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello C#");
            // 출력되고 바로 꺼져버리므로 그걸 막기 위해서 키 1개를 입력할 때 까지 기다리게 만든다.
            HelloName(new string[] { "jichan" });

            Console.ReadKey();
        }

        static void HelloName(string[] args)
        {
            Console.WriteLine("Hello " + args[0]);
        }
    }
}   