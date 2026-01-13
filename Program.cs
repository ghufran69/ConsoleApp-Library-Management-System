using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;

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
            bool[]availability=new bool[100];
            int LastBookIndextracker = -1;

            titles[0] = "sciences";
            ISBN[0] = "A0";
            Authors[0] = "Ghufran";
            borrowerNames[0] = "Ahlam";
            availability[0] = false;
            LastBookIndextracker++;

            titles[1] = "Math";
            ISBN[1] = "A1";
            Authors[1] = "Ahmed";
            borrowerNames[1] = " ";
            availability[1] = false;
            LastBookIndextracker++;
             
            titles[2] = "food";
            ISBN[2] = "A2";
            Authors[2] = "fatima";
            borrowerNames[2] = "";
            availability[2] = true;
            LastBookIndextracker++;

            bool exit=false;
            
            while(!exit)
            {
                Console.WriteLine("Welcome to Library ManagementSystem ");
                Console.WriteLine("1.Add New Book");
                Console.WriteLine("2.Borrow Book");
                Console.WriteLine("3.Return Book");
                Console.WriteLine("4.Search Book");
                Console.WriteLine("5.List All Available Books");
                Console.WriteLine("6.Transfer Book");
                Console.WriteLine("7.Exit");
                Console.WriteLine("Please select the option:");
                int option =int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the title :");
                        titles[LastBookIndextracker + 1] = Console.ReadLine();

                        Console.WriteLine("Enter Author :");
                        Authors[LastBookIndextracker + 1] = Console.ReadLine();
                        ISBN[LastBookIndextracker + 1] = "A" + (LastBookIndextracker + 1);

                        //output
                        Console.WriteLine(" Add Book successfully");
                        Console.WriteLine(" Book ISBN :" + ISBN[LastBookIndextracker + 1]);
                        availability[LastBookIndextracker + 1] = true;
                        LastBookIndextracker++;

                        break;


                    case 2:
                        Console.WriteLine("Enter the title Book or ISBN");
                        string keyBook = Console.ReadLine();



                        //processing
                        bool Bookavailability = false;
                        for (int i = 0; i < 100; i++)
                        {
                            if (keyBook == titles[i] || keyBook == ISBN[i])
                            {
                                Bookavailability = true;
                                if (availability[i] == true)
                                {
                                    Console.WriteLine("Enter Borrower Name:");
                                    borrowerNames[i] = Console.ReadLine();
                                    availability[i] = false;
                                    Console.WriteLine("Book Borrowed Successfuly");
                                }
                                else
                                {
                                    Console.WriteLine("Book Borrowed already");
                                }
                                break;

                            }

                        }
                        if (Bookavailability == false)
                        {
                            Console.WriteLine("sorry Book not found");
                        }
                        break;




                    case 3:
                        Console.WriteLine("Enter the Book ISBN");
                        string returnBook = Console.ReadLine();



                        //processing
                        bool BookAvailability = false;
                        for (int i = 0; i < 100; i++)
                        {
                            if (returnBook == ISBN[i])
                            {
                                BookAvailability = true;

                                if (availability[i] == false)
                                {
                                    Console.WriteLine("Enter Borrower Name:");
                                    string BorrowerName = Console.ReadLine();
                                    availability[i] = true;
                                    Console.WriteLine("Book return Successfuly");
                                    borrowerNames[i] = " ";
                                }
                                else
                                {
                                    Console.WriteLine("This book was not borrowed");
                                }
                                break;

                            }

                        }
                        if (BookAvailability == false)
                        {
                            Console.WriteLine("sorry Book not found");
                        }
                        break;



                    case 4:
                        Console.WriteLine("Enter the title Book or ISBN");
                        string searchBook = Console.ReadLine();

                        bool SearchBookAvailability = false;
                        for (int i = 0; i < 100; i++)
                        {
                            if (searchBook == ISBN[i] || searchBook == titles[i])
                            {
                                SearchBookAvailability = true;
                                Console.WriteLine(" the book details :");
                                Console.WriteLine(" titles :" + titles[i]);
                                Console.WriteLine(" Authors :" + Authors[i]);
                                Console.WriteLine(" ISBN Book :" + ISBN[i]);

                                if (availability[i] == true)
                                {
                                    Console.WriteLine(" this book is available");

                                }
                                else
                                {
                                    Console.WriteLine("this book is not available");
                                }
                                break;
                                if (BookAvailability = false) ;
                                {
                                    Console.WriteLine("the book is not found");
                                }
                            }
                        }


                        break;


                    case 5:
                        bool BookFound = false;
                        for (int i = 0; i < 100; i++)
                        {
                            if (availability[i] == true)
                            {
                                BookFound = true;

                                Console.WriteLine("the available book is " + titles[i]);
                                Console.WriteLine("the Author book is " + Authors[i]);

                            }

                        }
                        break;
                        if (BookFound == false)
                        {
                            Console.WriteLine("the book not found");
                        }




                    case 6:
                        Console.Write("Enter first borrower name:");
                        string firstBorrower = Console.ReadLine();


                        Console.Write("Enter second borrower name:");
                        string secondBorrower = Console.ReadLine();


                        bool firstBorrowerFound = false;
                        int firstBorrowerIndex = 0;

                        for (int i = 0; i <100; i++)
                        {
                            if (firstBorrower == borrowerNames[i])
                            {
                                firstBorrowerIndex = i; // 


                                firstBorrowerFound = true;
                                break;

                            }
                        }
                        if (firstBorrowerFound == false)
                        {
                            Console.WriteLine("current borrower name not found");
                        }
                        else
                        {
                            bool secondBorrowerFound = false;
                            int secondBorrowerIndex = 0;
                            for (int i = 0; i < 100; i++)
                            {
                                if (secondBorrower == borrowerNames[i])
                                {
                                    secondBorrowerIndex = i;//مكان / رقم تواجد الشخص التانى

                                    secondBorrowerFound = true;
                                    break;

                                }
                            }
                            if (secondBorrowerFound == false)
                            {
                                Console.WriteLine("New borrower name not found");
                            }
                            else
                            {

                                string temp = "";

                                temp = borrowerNames[firstBorrowerIndex];

                                borrowerNames[firstBorrowerIndex] = borrowerNames[secondBorrowerIndex];

                                borrowerNames[secondBorrowerIndex]= temp;

                                Console.WriteLine("Borrower transfer completed successfully");
                                Console.WriteLine("Borrower updated from " + firstBorrower + " to " + secondBorrower);
                            }

                        
                        }

                

                            break;





                                    case 7:
                                        Console.WriteLine("Thank you for using the libarary System, press any key");

                                        exit = true;
                                        break;

                                       if (exit == true)
                                       {
                                       Console.ReadLine();
                                       Console.Clear();
                                        }
                                       break;

                                      }






            }







        }
    }
}
