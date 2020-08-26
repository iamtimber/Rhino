using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhino
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string CharacterName = "Timber";
            int CharacterAge;
            CharacterAge = 41;
            Comment Using Forward Slash //

            Console.WriteLine("This is " + CharacterName + ". He is " + CharacterAge);
            Console.WriteLine("That is Colton");

            CharacterName = "Dallas";

            Console.WriteLine("She is " + CharacterName);
            Console.WriteLine("Her name is Dior");
            Console.WriteLine("We are the Timbrezas");

            Console.ReadLine();

            string phrase = "The Draft Academy";
            char grade = 'A';
            int age = 40;
            // float | double | decimal
            double gpa = 3.2;
            bool isMale = true;
            // End Statements in SemiColon
            string phrase = "This is a Journey";


            Console.WriteLine("This is some\nText"); // New Line "\n"
            Console.WriteLine("Giraffe\"Academy");
            Console.WriteLine(phrase.ToUpper() );
            Console.WriteLine(phrase.ToLower());
            Console.WriteLine(phrase.Contains("Journey"));
            Console.WriteLine(phrase[0]); //Indexing String Starts with 0
            Console.WriteLine(phrase[8]);
            Console.WriteLine(phrase.IndexOf("Journey"));
            Console.WriteLine(phrase.IndexOf('a'));
            Console.WriteLine(phrase.Substring(5));
            Console.WriteLine(phrase.Substring(5, 4));

            Console.WriteLine( 41 + 9 );
            Console.WriteLine( 5 % 2  );
            Console.WriteLine(4 + 2 * 3);
            Console.WriteLine((4 + 2) * 3);

            int num = 6;
            num--;

            // Methods - Block of Code to perform specific tasks

            Console.WriteLine(Math.Abs(-41));
            Console.WriteLine(Math.Pow(2,3));
            Console.WriteLine(Math.Sqrt(81));
            Console.WriteLine(Math.Max(4, 7));

            Console.WriteLine("Hello");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + ". You are " + age);

            //Converting String to Int

            int num = Convert.ToInt32("45");
            Console.WriteLine(num + 6);


            // Calculator
            Console.Write("Enter a Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num1 + num2);


            //MadLib

            /*
            string color, pluralNoun, celebrity;

            Console.Write("Enter The Color: ");
            color = Console.ReadLine();
            
            Console.Write("Enter Noun: ");
            pluralNoun = Console.ReadLine();
            
            Console.Write("Enter The Name: ");
            celebrity = Console.ReadLine();


            Console.WriteLine("Roses Are " + color);
            Console.WriteLine(pluralNoun + " are Blue.");
            Console.WriteLine("I LOVE " + celebrity);
            */

            // Arrays
            // Open/close Square Bracket [] = array
            // curly brackets = for the values(s) of the array. "elements" of an array
            // Index start with 0

            /*
            int[] luckyNumbers = { 4, 8, 12, 16, 23, 42 };
            string[] friends = new string[5];

            friends[0] = "John";
            friends[1] = "James";

           

            Console.WriteLine(luckyNumbers[1]);
            Console.WriteLine(friends[1]);

            */

            //Methods
            //Block of code that performs specific task. container of code.

            SayHi("Colton");
            Console.ReadLine(); // Pauses the execution of the Program

        }

        // New Method. Starts with Static
        // Methods start with Captial
        // Only code in the Main Program can be run.
        // Call Methods in the Main code block

        static void SayHi(string name)
        {
            Console.WriteLine("Hello " + name);

        }

    }
}
