using System;
using System.Text;

namespace helloworld.Week2
{
    public class ReferenceTypes
    {
        private string _testString = "Test String";
        private string _testString2 = "is awesome";

    

        public void JoingStrings()
        {
            string secondTest = "written test";
            Console.WriteLine("This is a " + _testString);
            Console.WriteLine(_testString + secondTest);

        }
        public void JoingStringsWithBuilder()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(_testString)
            .Append(_testString2)
            .Append(" and super cool.");

            //in order to use the builder, you have to call the
            //ToString method so it converts
            Console.WriteLine(builder.ToString());
        }


        #region Placeholder and compare strings
        public void PlaceHolderString()
        {
            string sampleFour = "forth";
            //this is third test string
            Console.WriteLine("This is a third {0}", _testString);
            Console.WriteLine("This {0} is {2} the {1} , _testString, sampleFour,35");
        }
        public void CompareStrings()
        {
            string ab = "Test String";
            Console.WriteLine(_testString == ab);

        }
        #endregion

        #region Char
        public void CharType()
        {
            char ab = 'A';
            char de = 'B';
            char copyWriteSymbol = '\u00A9';

            Console.WriteLine(ab == de); //false
            Console.WriteLine("The copywrite symbol looks like {0}, copyWriteSymbol");
        }
        #endregion

    
        /**
        *Arrays represent a fixted number of variables or elements of a type
        *Arrays can be made up of Strings or Value Types
        *They start with an index of 0. If you exceed the size of the an array, you will trigger
        *an IndexOutOfRangeException. Their can be multidemensional arrays.
        * **/
        public void ArraySingleSample()
        {
            string[] cars = new string[3];
            cars[0] = "camaro";
            cars[1] = "mustang";
            cars[2] = "chevelle";
            //or
            string[] names = {"Tom", "Roger", "Matt"};

            Console.WriteLine(cars[1]);
            Console.WriteLine(names[0]);

        }
    
        public void ArrayRectangularSample()
        {
            int[,] sampleInt = new int[2, 2];
            sampleInt[0, 2] = 5;
            sampleInt[0, 1] = 10;
            sampleInt[1, 0] = 2;
            sampleInt[1, 1] = 4;

            Console.WriteLine(sampleInt[1, 0]);

        }
        public void ArrayJaggedSample()
        {
            int[][] sampleJagged = new int[2][];
            sampleJagged[0] = new int[] {2, 3, 4 }; //int[3]
            sampleJagged[1] = new int[] {5, 6};

            //or

            int[][] secondSample = new int[][]
            {
                new int[] {1,2,3,4,5},
                new int[] {6,7,8,9},
                new int[] {10,11,12},

            };
            
        }
    }

}
