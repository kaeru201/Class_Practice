using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Practice
{
    internal class Person
    {
        //変数
        String name; //キャラの名前
        int level; //レベル
        int hp; //体力
        string info = "ただの村人";// キャラ属性の特徴

        //実体化した際に基本的な情報は入るように設計
        //引数なしコンストラクタ
        public Person() 
        {
            name = "イッパンジーン";
            level = 1;
            hp = 100;
        }
        //引数ありコンストラクタ
        public Person(String n, int h)
        {
            name = n;
            level = 1;
            hp = h;
        }

        //命令（メソッド）
        //そのキャラの情報を表示するメソッド
        public void InfoDisplay()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("名前:" + name);
            Console.WriteLine("レベル:" + level);
            Console.WriteLine("体力:" + hp);
            Console.WriteLine(info);

        }
    }
}
