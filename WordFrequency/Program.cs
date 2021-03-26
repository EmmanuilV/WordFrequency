using System;

namespace WordFrequency
{
    class Program
    {

        static void Main(string[] args)
        {
            string text = "If you are running this on your environment, you should follow the instructions for the local version instead. " + 

                        "You have created a list of strings, added three names to that list, and printed out the names in all CAPS. "  + 
                        "You are using concepts that you have learned in earlier tutorials to loop through the list.";
                        //"string, string. for For, FOR.";

            
            Frequency frequency = new Frequency();
            frequency.WordFrequency(text);

        }
    }
}
