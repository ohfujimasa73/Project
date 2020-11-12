using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 入力を促すメッセージの表示して、文字を入力してもらう
            Console.Write("あなたのお名前は？ : ");
            var name = Console.ReadLine();

            // 入力を促すメッセージの表示して、数値を入力してもらう
            Console.Write("あなたのお年は？   : ");
            var age = int.Parse(Console.ReadLine());

            // メッセージの出力
            Console.WriteLine("{0} ({1}歳) さん、ようこそお越しくださいました。", name, age);

            masa test = new masa();

            Console.WriteLine("{0}", test.Get_age());

        }

        class masa
        {
            private int age { set; get; }

            public masa()
            {
                this.age = 0;
            }

            public void Set_age(int num)
            {
                this.age = num;
            }

            public int Get_age()
            {
                return this.age;
            }
        }



    }


}
