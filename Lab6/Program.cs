//Grading ID: K1791
//Lab 6
//25 October 2020
//CIS 199-02
//Creating triangles with asterisks from nested loops




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        const string asterisk = "*"; //How we draw shapes
        const string spaceTheFinalFrontier = " "; //Empty space when needed
        const int maxRows = 10; //The maximum number rows in this lab


        static void Main(string[] args)
        {
            patternA(); //First pattern
            patternB(); //Second pattern
            patternC(); //Third pattern
            patternD(); //Fourth pattern


        }
        //Drawing pattern A
        static public void patternA()
        {

            Console.WriteLine("Pattern A"); //Displays the name of pattern
            Console.WriteLine("");    //Space
            for (int rows = 0; rows < maxRows; rows++) //Defines rows as 0, when rows is less than 10, increase the row count

            {
                for (int star = 0; star <= rows; star++) //Defines stars as equal to zero, when stars is less than or equal to rows, increases number of asterisks by one each loop
                    Console.Write(asterisk); //Writes an asterisk
                Console.WriteLine("");    //new line after  every row
            }
            Console.WriteLine("");    //Space
        }

        //Drawing pattern B
        static public void patternB()
        {


            Console.WriteLine("Pattern B"); //Writes the name of pattern
            Console.WriteLine("");    //Space
            for (int rows = maxRows; rows > 0; rows--) //Defines rows as 10, when rows is greater than zero, decreases row count each loop

            {
                for (int stars = 0; stars < rows; stars++) //Defines stars as zero, when stars is less than rows, increases the asterisk count each loop
                    Console.Write(asterisk); //Writes an asterisk
                Console.WriteLine("");    //new line after every row
            }
            Console.WriteLine();    //new line after pattern B
        }

        //Drawing pattern C
        static public void patternC()
        {

            Console.WriteLine("Pattern C"); //Writes the name of the pattern
            Console.WriteLine("");    //Space

            for (int rows = 0; rows < maxRows; rows++) //Defines rows as zero, when rows is less than 10, increase the row count by 1 each loop
            {
                for (int stars = 0; stars < rows; stars++) //Defines stars as zero, when stars is less than rows, increase the space count by 1 each loop
                    Console.Write(spaceTheFinalFrontier); //Increases space

                for (int stars = 0; stars < maxRows - rows; stars++) //Defines stars as zero, when stars is less than 10, increase asterisk count by 1 each loop
                    Console.Write(asterisk); //Increase asterisks 
                Console.WriteLine("");    //new line after every row
            }
            Console.WriteLine("");    //Space

        }


        //Drawing pattern D
        static public void patternD()
        {

            Console.WriteLine("Pattern D"); //Writes the name of the pattern
            



            for (int rows = maxRows; rows >= 0; rows--)//Defines row as equal to 10, when rows is great than or equal to 0, decreases by 1 each loop.
            {
                for (int stars = 0; stars < rows; stars++) //Defines stars as equal to 0, when stars is less than rows, increases empty space by 1 each loop.
                    Console.Write(spaceTheFinalFrontier); //Adds empty space

                for (int stars = 0; stars < maxRows - rows; stars++) //Defines star as equal to zero, when stars is less than 10, adds a new asterisk each loop
                    Console.Write(asterisk); //Adds an asterisk
                Console.WriteLine("");    //new line after every row
            }
            Console.WriteLine("");    //Space
        }

       
    }
}


