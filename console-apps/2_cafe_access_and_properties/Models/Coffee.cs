using System;

namespace Cafe.Drinks
{
    public class Coffee
    {
        // fields 
        public string Name;
        private int _price;
        // public is an access level modifier,
        // public means this field is accessible anywhere in the app
            // any method anywhere could change the field 
        //not great

        // private means code in this class has access
        // but code outside this class does not.
        // Change Price to private and see what happens
        // doesn't work
        // user getters and setters to access private fields

        // public int Size //public property
        // {
        //     get
        //     {
        //         return _size;
        //     }
        //     set
        //     {
        //         _size = value;
        //     }
        // }

        // or shorthand version if don't need any additional logic


        public int Size { get; set; }


        // public auto-implimented property and no need for a private field
        //So where are our private fields? 
        // When we use auto-implemented properties, C# generates a private anonymous backing field attached to the public property. 

        // constructor
        public Coffee(string name, int price, int size)
        {
            Name = name;
            _price = price;
            Size = size;
        }



        // this is where the lessons get confusing but good to know for students
        // Just ignore all of this because it is better to use properties

        // a getter method, just like any other method but naming convention
        // says use "Get" followed by the name of the field (property?)
        // methods are public and all this one does is return _price
        public int GetPrice()
        {
            return _price;
        }

        // a setter method
        public void SetPrice(int newPrice)
        {
            _price = newPrice;
        }
    }
}