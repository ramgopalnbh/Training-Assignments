using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace filesdirectory
{
    public class Program
    {
        static void Main(string[] args)
        {

            //File.Create("abc.txt");
            //Console.WriteLine(File.Exists("abc.txt"));

            List<string> list = new List<string>
            {
                "Ram Gopal",
                "Rahul",
                "Rohit",
                "Ravi Roshan"
            };

            //string s = "";
            //list.ForEach(i => s = s + i);
            //File.AppendAllText("abc.txt", s);
            //Console.WriteLine(File.ReadAllText("abc.txt"));
            //var p = File.ReadLines("abc.txt").ToList();
            //p.ForEach(i => Console.WriteLine(i));

            //File.WriteAllText("abc.txt", "Overwriting the file");
            //File.AppendAllText("abc.txt", "\nAppend the new line to this file!");

            //Directory.CreateDirectory("input");
            //Directory.CreateDirectory("output");

            //File.Copy("abc.txt", @"C:\Trainning\CSharpAssignments\filesdirectory\filesdirectory\bin\Debug\netcoreapp3.1\input\input.txt");
            //File.Move("abc.txt", @"C:\Trainning\CSharpAssignments\filesdirectory\filesdirectory\bin\Debug\netcoreapp3.1\output\abc.txt");
            //File.Move(@"C:\Trainning\CSharpAssignments\filesdirectory\filesdirectory\bin\Debug\netcoreapp3.1\output\abc.txt", "abc.txt");

            string dir = Directory.GetCurrentDirectory();
            var allDir = Directory.GetDirectories(dir);
            //var files=Directory.GetFiles(@"C:\Trainning\CSharpAssignments\filesdirectory\filesdirectory\bin\Debug\netcoreapp3.1");
            //Console.WriteLine(files[0]);
            ////Directory.Delete(allDir[2]);
            //foreach(string ad in allDir)
            //{
            //    Console.WriteLine(ad);
            //}

            //Directory.EnumerateDirectories(dir).ToList().ForEach(i => Console.WriteLine(i));
            //Console.WriteLine(File.GetAttributes("abc.txt"));

            //File.SetAttributes(@"C:\Trainning\CSharpAssignments\filesdirectory\filesdirectory\bin\Debug\netcoreapp3.1\input\input.txt",FileAttributes.ReadOnly);
            File.Encrypt(@"C:\Trainning\CSharpAssignments\filesdirectory\filesdirectory\bin\Debug\netcoreapp3.1\input\input.txt");

            Console.WriteLine("Operation Successful!!");
        }
    }
}
