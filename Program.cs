using System;

// Import the static members of Console
using static System.Console;

using UnderstandingStaticKeyword.Models;

namespace UnderstandingStaticKeyword
{
    class Program
    {            
        static void Main()
        {
            Topic.Info();
            WriteLine($"\nLesson duration is: {Topic.LessonDuration}");

            WriteLine($"\nClass count is: {Topic.GetClassCount()}");
            Topic.SetClassCount(35);
            WriteLine($"Class count is: {Topic.GetClassCount()}");

            Topic t = new Topic("Understanding Encapsulation");
            WriteLine($"\nClass topic is: {t.Title}");

            t.TestStaticCallFromNonStatic();
            Topic.InfoStaticCallFromNonStatic();

            WriteLine("\n******************************************* Defining Static Constructors *******************************************");
            WriteLine($"\ntestStaticConstructor: {Topic.testStaticConstructor}");
            Topic.testStaticConstructor = 2021;
            WriteLine($"testStaticConstructor: {Topic.testStaticConstructor}");
            Topic t1 = new Topic("Test");
            WriteLine($"testStaticConstructor: {Topic.testStaticConstructor}");

            WriteLine($"\nYear: {Topic.Year}");
            Topic.Year = 2021;
            WriteLine($"Year: {Topic.Year}");
            Topic t2 = new Topic("Test");
            WriteLine($"Year: {Topic.Year}");

            // Compiler Error: Cannot create an instance of the static class
            // InfoCenter i = new InfoCenter();
            InfoCenter.Info1();
            InfoCenter.Info2();

            ReadLine();
        }
    }
}