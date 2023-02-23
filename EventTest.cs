//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SampleApp
//{
//    public delegate void MyDeligate(string str);

//    class Program
//    {
//        event MyDeligate MyEvent;

//        public Program()
//        {
//            this.MyEvent += new MyDeligate(this.WriteToConsole);
//        }
//        public void WriteToConsole(string output)
//        {
//            Console.WriteLine(output);
//        }
//        static void Main(string[] args)
//        {
//            Program p = new Program();
//            // its a console so we cannot have a button
//            // explicitly calling the event 
//            p.MyEvent("triggered after click event....!");
//        }
//    }
//}