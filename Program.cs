using System;
using first;
using first.second;



namespace first
{
    class abc
    {
        public void function()
        {
            Console.WriteLine("first function ");


        }
    }
    namespace second
    {
        class def
        {
            public void fuction()
            {
                Console.WriteLine("second function");

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            abc ob = new abc();
            def obj = new def();
            obj.fuction();
            ob.function();
            Console.ReadKey();


        }
    }
}

