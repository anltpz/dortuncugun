using System;

namespace GenericIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<string> isimler = new MyList<string>();
            isimler.Add("343");
            MyList<int> sayilar = new MyList<int>();
            sayilar.Add(67);

        }
    }
}
