using System;

namespace challenge
{
    class Pie
    {

//option 1, simplest way to complete the challenge, with values inputted as parameters.
        public bool equalSlices(int total, int recipients, int slices)
        {
            if (recipients * slices > total)
            {
                Console.WriteLine(false);
                return false;
            }
            else
            {
                Console.WriteLine(true);
                return true;
            }
        }

   //option 2, asking the user for values to do the challenge. 
        public int total;

        public int recipients;

        public int slices;
    
        public bool userSlices()
        {   Console.WriteLine("how many slices of pie in total?");
            total = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("how many people want pie?");
            recipients = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("how many slices of pie does each person want?");
            slices = Convert.ToInt32(Console.ReadLine());

            if (recipients * slices > total)
            {
                Console.WriteLine($"Nope, there's not enough pie for {recipients} people to have {slices} slices each");
               return false;
            }
            else
            {
                Console.WriteLine($"sweet, pie for everyone!");
               return true;
            }
        }


    }


class Program
{
    static void Main(string[] args)
    {   
        Pie slice = new Pie();

    //option 1 various options with their expected outputs 
    
        slice.equalSlices(15, 5, 3); //true
        slice.equalSlices(8, 3, 2); //expect true
        slice.equalSlices(24, 12, 2); //expect true
        slice.equalSlices(8, 3, 3); //expect false
        slice.equalSlices(8, 0, 0); //expect true
        slice.equalSlices(3, 5, 5); //expect false

    //option 2 user can have input their pie pieces!
         slice.userSlices();
        
    }
}
}
