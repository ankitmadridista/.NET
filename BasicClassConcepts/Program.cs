using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClassConcepts
{
    class Program
    {
        //static void oldMain()
        //{
        //    System.Console.WriteLine("HEllo world");
        //    System.Console.ReadLine();
        //}
        static void Main() {
            class1 obj = new class1();
            obj.display();

            obj.display("hello");
            

            Console.WriteLine(obj.sum());
            Console.WriteLine(obj.sum(1, 2)); Console.WriteLine(obj.sum(1, 2, 3)); Console.WriteLine(obj.sum(1, 2, 3, 4));

            Console.WriteLine(obj.sum());

            Console.ReadLine();
        }
    }
    public class class1 {
        public void display() {
            System.Console.WriteLine("from class1 display");
        }
        //fun overloading
        public void display(String s)
        {
            System.Console.WriteLine("from class1 display " + s);
        }

        public int sum(int a=0, int b=0, int c=0, int d=0) {
            return a + b + c + d;
        }
        //public int sum(int a) {
        //    return a ;
        //}
        //public int sum(int a, int b)
        //{
        //    return a + b;
        //}
        //public int sum(int a, int b, int c)
        //{
        //    return a + b + c;
        //}
        //public int sum(int a, int b, int c, int d)
        //{
        //    return a + b + c + d;
        //}
    }

}

