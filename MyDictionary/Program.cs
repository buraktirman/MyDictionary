using System;

namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> dict = new MyDictionary<string, int>();

            dict.Add("Burak", 5);
            dict.Add("Berkay", 3);
            dict.Add("Burak", 8); // Hata mesajı verir ve sözlüğe eklemez çünkü aynı key'e sahip olamaz.
            dict.Add("Samet", 3); // Ancak aynı değere sahip olabilir.

            Console.WriteLine(dict.Count);

            dict.ShowDictionary();

        }
    }
}
