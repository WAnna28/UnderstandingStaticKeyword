using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingStaticKeyword.Models
{
    class Topic
    {
        public string Title;
        // A static point of data.
        public static string LessonDuration = "1:15";
        public static int classCount = 20;

        public static int testStaticConstructor;
        public static int Year;

        public Topic(string title)
        {
            Title = title;
            testStaticConstructor = 2019;
        }

        // A static constructor!
        static Topic()
        {
            Console.WriteLine("In static ctor!");
            Year = 2009;
        }

        public void TestStaticCallFromNonStatic()
        {
            Console.WriteLine($"\nTestStaticCallFromNonStatic :-) {LessonDuration}");
        }

        public static void InfoStaticCallFromNonStatic()
        {
            Console.WriteLine(@"Can we use static variable inside non static method?
Yes, we can. It is important to note that static variable can be used inside non static and static methods.");
        }

        // Methods of a class
        public static void Info()
        {
            Console.WriteLine(@"The static members can be part of any class definition at all. 
Just remember that static members promote a given item to the class level rather than the object level.
The static keyword can be applied to the following:
    • Data of a class
    • Methods of a class
    • Properties of a class
    • A constructor
    • The entire class definition
    • In conjunction with the C# using keyword"
                );
        }

        // Static members to get/set LessonDuration.
        // Using the expression-bodied member syntax.
        public static void SetClassCount(int _classCount) => classCount = _classCount;
        public static int GetClassCount() => classCount;
    }
}
