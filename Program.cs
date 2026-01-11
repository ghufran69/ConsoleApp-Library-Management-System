using System.Diagnostics;

namespace ConsoleApp_Library_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] titles = new string[100];
            string[] ISBN = new string[100];
            string[] Authors = new string[100];
            string[] borrowerNames= new string[100];
            int LastBookIndextracker = -1;

            titles[0] = "sciences";
            ISBN[0] = "A0";
            Authors[0] = "Ghufran";
            borrowerNames[0] = "Ahlam";
            LastBookIndextracker++;

            titles[0] = "Math";
            ISBN[0] = "A1";
            Authors[0] = "Ahmed";
            borrowerNames[0] = "Omar";
            LastBookIndextracker++;

            bool exit=false;
            
            while(true)
            {
                Console.WriteLine("Welcome to Library ManagementSystem ");
                Console.WriteLine("1.Add New Book");
                Console.WriteLine("2.Borrow Book");
                Console.WriteLine("Return Book");
                Console.WriteLine("Search Book");
                Console.WriteLine("List All Available Books");
                Console.WriteLine("Transfer Book");
                Console.WriteLine("Exit");
                Console.WriteLine("Please select the option:");
                int option =int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                        Console.WriteLine("Enter the title :");
                        titles[LastBookIndextracker+1]=Console.ReadLine(); 

                        Console.WriteLine("Enter Author :");
                        Authors[LastBookIndextracker + 1] = Console.ReadLine();
                        ISBN[LastBookIndextracker + 1] = "A" + (LastBookIndextracker + 1);

                        //output
                        Console.WriteLine(" Add Book successfully");
                        Console.WriteLine(" Book ISBN :" + ISBN[LastBookIndextracker + 1]);
                        LastBookIndextracker++;



                        break;




                        case 2:
                        break;





                        case 3:
                        break;
                        case 4:
                        break;
                        case 5:
                        break;
                        case 6:
                        break;

                }






            }







        }
    }
}
