﻿using System;
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
        {s
            // 入力を促すメッセージの表示して、lplplpp文字を入力してもらうggghfghfhgfghgfhggggggggggggttttttttttjfgjtgkhktfghfghfgghkgtyrtyrytryrtyttryry11111111111111111111ppppppppppeeeeeserfwesgfew
            Console.Write("あなたのお名前は？ : ");
            var name = Console.ReadLine();

            // 入力を促すメッセージの表示して、数値を入力してもらうoooo
            Console.Write("あなたのお年は？   : ");

sfsfdsgfdgdfgfdgfdgdgkkkkkkkkkkkkkcvghfghfghgfhghgfooooo
sfsfdsgfdgdfgfdgfdgdgkkkkkkkkkkkkkcvghfghfghgfhghgffghrhjytrjtyujtukukku
dfsdffsdfdsfdsfdgfdgdfgdgfdgdgfgdgdfggllllllllllllllllllllllllllooooooooooooooooooooooopppppppppppppppp
zdddddddddddddd
asadadasdadfgdfgdgfdgf
aaaaaaaaaaaaaaaaaaaaaa]]]]]]]sssssssssstttttttttttttrrrrrrrrrrrrrryyyyyyyyyyyyyyyyyyoooooooooo
eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee
ttttttttttt
ppppppppppppppppppppppppppp
dsfsdfsdf
            int age;
            try
            {
                age = int.Parse(Console.ReadLine());
                Console.WriteLine("{0} ({1}歳) さん、ようこそお越しくださいました。", name, age);

            }
            catch (FormatException)
            {

            }

            ohfuji test = new ohfuji(123);

            Console.WriteLine("{0}", test.Get_age());

sssssssssssssssssssssssssssssssssssssssssss
        }

        class masa
        {
            private int age { set; get; }

            public masa()
            {
                this.age = 0;
            }

            public masa(int a)
            {
                this.age = a;
            }

            protected void Set_age(int num)
            {
                this.age = num;
            }

            public int Get_age()
            {
                return this.age;
            }
        }

        class ohfuji : masa
        {
            public ohfuji(int a):base(a)
            {
                Set_age(a);
            }
        }

    }


}
