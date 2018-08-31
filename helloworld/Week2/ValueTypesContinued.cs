using System;

namespace helloworld.Week2
{
    public class ValueTypesContinued
    {
        #region Enums
        //enum declaration with default values
        private enum Position { Left, Right, Top, Bottom };

        //enum declaration with defined values
        private enum MovieType {Action = 100, Comedy = 200, Drama = 300};

        //enum declaration with mixed defined and non defined values
        private enum Days {Sun, Mon = 8, Tue = 9, Wed = 10, Thur, Fri, Sat};

        public void EnumSample()
        {
            Console.WriteLine("Value for days not set is {0}", Days.Thur);
            Console.WriteLine("Favorite type of movie value is {0}", MovieType.Action);
        }
#endregion
    }
}