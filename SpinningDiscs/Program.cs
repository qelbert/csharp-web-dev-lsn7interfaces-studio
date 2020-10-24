using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.

            CD myCd = new CD("Rockin' Oldies USA");
            DVD myDvd = new DVD("Rockin Oldie Movies about the USA");

            myCd.SpinDisc();
            myDvd.SpinDisc();

            // TODO: Call each CD and DVD method to verify that they work as expected.
        }
    }
}
