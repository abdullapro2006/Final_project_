// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main(string[] args)
    {
       Console.Clear();
        int option;


        do
        {
            Console.WriteLine("1. To carry out operations on products");
            Console.WriteLine("2. To carry out operations on sales");
            Console.WriteLine("0. Exit from system");



            Console.WriteLine("-----------------");
            Console.WriteLine("Please enter an option");
            Console.WriteLine("-----------------");

            while(!int.TryParse(Console.ReadLine(), out option)) 
            {
                Console.WriteLine("Invalid option!");
                Console.WriteLine("Enter an option please!");
                Console.WriteLine("-----------------");


                switch (option)
                {
                    case 1:

                    default:
                        Console.WriteLine("No such option!");
                        break;
                }

            }

        } while (option != 0);
    }
}
