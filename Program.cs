using System;
using System.Text;

namespace WorkingWithStringData
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicStringManipulation();
            PerformingStringInterpolation();
            DefiningVerbatimStrings();
            ImmutableStrings();
            UsingStringBuilder();

            Console.ReadLine();
        }
                
        static public void BasicStringManipulation()
        {
            Console.WriteLine("******************************* Basic String Manipulation  *******************************\n");
            string title = "Summer School 2021!";
            Console.WriteLine("Show title: {0}", title);
            Console.WriteLine("Title has {0} characters.", title.Length);
            Console.WriteLine("Title in uppercase: {0}", title.ToUpper());
            Console.WriteLine("Title in lowercase: {0}", title.ToLower());
            Console.WriteLine("Title contains the letter \'a\'?: {0}", title.Contains("a"));
            Console.WriteLine("New title: {0}", title.Replace("Summer", "Winter"));
            Console.WriteLine();
        }
                
        static public void PerformingStringInterpolation()
        {
            Console.WriteLine("******************************* Performing String Interpolation *******************************\n");
            // Using curly-bracket syntax.
            // The curly-bracket syntax ({0}, {1}, etc.) has existed within the .NET platform since version 1.0.
            string envInfo = string.Format("Folder path is: {0}\nCurrent directory is: {1}",
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Environment.CurrentDirectory);
            Console.WriteLine("*************** Using curly-bracket syntax ***************");
            Console.WriteLine(envInfo);

            // Using string interpolation
            // Starting with the release of C# 6, C# programmers can use an alternative syntax to build string literals that contain placeholders for variables.
            // Formally, this is called string interpolation.
            string envInfo2 = $"Folder path is: {Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\nCurrent directory is: {Environment.CurrentDirectory}";
            Console.WriteLine("\n*************** Using string interpolation ***************");
            Console.WriteLine(envInfo2);
        }

        static public void DefiningVerbatimStrings()
        {
            // Defining Verbatim Strings
            string interp = "interpolation";
            string verbatimString = $@"This is a very
                very
                   very
                     long string with {interp}!";
            Console.WriteLine("\n*************** Defining Verbatim Strings ***************");
            Console.WriteLine(verbatimString);
        }

        static public void ImmutableStrings()
        {
            Console.WriteLine("\n*************** Immutable Strings ***************");
            // Set initial string value.
            string s1 = "Summer School 2021!";
            Console.WriteLine("s1 = {0}", s1);
            // Uppercase s1?
            string upperString = s1.ToUpper();
            Console.WriteLine("\nupperString = {0}", upperString);
            // Nope! s1 is in the same format!
            Console.WriteLine("s1 = {0}", s1);

            // For ildasm.exe
            // The ldstr opcode of the CIL loads a new string object on the managed heap.
            string s2 = "Summer School 2021!";
            s2 = "Winter School 2021!e";
            int i = 50;
            i = 60;
        }

        static public void UsingStringBuilder()
        {
            // Using the System.Text.StringBuilder Type
            // What is unique about the StringBuilder is that when you call members of this type, you are directly
            // modifying the object’s internal character data(making it more efficient),
            // not obtaining a copy of the data in a modified format.
            Console.WriteLine("\n*************** Using String Builders ***************");
            StringBuilder sb = new StringBuilder("\n**** Sorting Algorithms ****");
            sb.Append("\n");
            sb.AppendLine("Insertion sort");
            sb.AppendLine("Bubble sort");
            sb.AppendLine("Merge sort");
            sb.AppendLine("Quick sort" + "(optional)");
            sb.AppendLine("Heap sort" + "(optional)");
            Console.WriteLine(sb.ToString());
            sb.Replace("sort", "sort algorithm");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb has {0} chars.", sb.Length);
        }
    }
}
