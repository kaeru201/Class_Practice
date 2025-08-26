using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //自作したPersonクラス(Person型)の実体化(インスタンス)
            Person p1 = new Person("ムラビート",150);
            p1.InfoDisplay(); //p1にメソッドを使わせてみる
        }
    }
}
