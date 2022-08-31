using System;

//namespaces = a grouping of similar classes to keep like information in scope
// naming convention of namespaces = project name "Cafe" . "description of grouping"
// for examples "Drinks" I could add coffee, Latte, tea etc
// watch out for lessons, it also uses "Model" but it is refering to car Model

namespace Cafe.Drinks
{
    //the keyword "class" declares a class followed by the name
    //UpperCamelCase (PascalCase)
    public class Coffee
    {
        // fields - a variable of any type declared in a class
        public string Name;
        public int Price;
        public int Size;

        // constructor
        public Coffee(string name, int price, int size)
        {
            Name = name;
            Price = price;
            Size = size;
        }

        // static method
        public static string Deals()
        {
            return "Everything half off";
        }

        public void SizeUp()
        {
            if (Size > 4)
            {
                Price = 20;
            }
        }


        //next lesson
        //properties (get and set)
        //access modifer (public)
    }
}