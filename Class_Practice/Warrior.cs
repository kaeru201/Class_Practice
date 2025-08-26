using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Practice
{
    internal class Warrior : Person
    {
        //コンストラクタ(引数あり）
        public Warrior(string n, int h)
        {
            name = n;
            hp = h;
            info = "強い剣士";
        }

        //コンストラクタ(引数なし)
        public Warrior() : this("タンジーロ", 500) { }

        //継承したメソッドをオーダーライド(上書き)して違う機能に書き換える
        public override void AttackInfo(int x)
        {
            switch (x)
            {
                case 1:
                    Console.WriteLine("技：盾切り");
                    break;
                case 2:
                    Console.WriteLine("技：横切り");
                    break;
                case 3:
                    Console.WriteLine("技：連続切り");
                    break;
                default:
                    Console.WriteLine("技：みねうち");
                    break;

            }
        }
        public override void AttackInfo()
        {
            Console.WriteLine("技：みねうち");
        }


        public string Specail()
        {
            string message = "家族マモル";
            return message;
        }

      

    }
}
