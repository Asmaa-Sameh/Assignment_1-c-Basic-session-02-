
//Question 1

//using System;

//namespace Assignment_1;

//class Book
//{
//    public string Title;
//    public int Pages;
//}

//class Program
//{
//    static void Main()
//    {
//        Book book = new Book();

//        book.Title = "The Beauty and the Bear";
//        book.Pages = 100;

//        Object obj = book;

//        Console.WriteLine(obj);
//    }
//}


// Question 2

//using System;

//namespace Assignment_1;

//class Book : Object
//{
//    public string Title;
//    public int Pages;
//}

//class Program
//{
//    static void Main()
//    {
//        Book book = new Book();

//        Console.WriteLine(book.ToString());
//        Console.WriteLine(book.Equals(book));
//        Console.WriteLine(book.GetHashCode());
//        Console.WriteLine(book.GetType());
//    }
//}


// Question 3

//namespace Assignment_1
//{
//    class Book
//    {
//        // int pages = "464";  // -> compilation Error

//        // the fix
//        int pages = 464;
//    }
//}

//namespace Assignment_1
//{
//    class Program
//    {
//        static void Main()
//        {
//            int x = 10;
//            int y = 0;

//            try
//            {
//                int result = x / y;
//            }
//            catch (DivideByZeroException)
//            {
//                Console.WriteLine("Cannot divide by zero");
//            }
//            finally
//            {
//                Console.WriteLine("Done");
//            }
//        }
//    }
//}


// Question 5 w 6

//namespace Assignment_1
//{
//    class program
//    {
//        static void main()
//        {
//            int pages = 300;
//            double papers = pages;

//            double price = 49.99;
//            int cost = (int)price;
//        }
//    }
//}


// Question 7

//namespace Assignment_1
//{
//    class Program
//    {
//        static void Main()
//        {
//            string pagesText = "464";
//            int papers = Convert.ToInt32(pagesText);

//            Console.WriteLine(papers);
//        }
//    }
//}


// Question 8

//namespace Assignment_1
//{
//    class Program
//    {
//        static void Main()
//        {
//            string yearText = "2023";
//            int year = int.Parse(yearText);

//            Console.WriteLine(year);

//            string badText = "abc";
//            int num;

//            if (int.TryParse(badText, out num))
//            {
//                Console.WriteLine(num);
//            }
//            else
//            {
//                Console.WriteLine("Invalid number");
//            }
//        }
//    }
//}


// Question 9

//namespace Assignment_1
//{
//    class Program
//    {
//        static void Main()
//        {
//            int pages = 464;
//            string papers = pages.ToString();

//            Console.WriteLine(papers.GetType());
//        }
//    }
//}


// Question 10

//namespace Assignment_1
//{
//    class Program
//    {
//        static void Main()
//        {
//            int copies = 100;
//            Object obj = copies;

//            Console.WriteLine(obj);

//            int copies2 = (int)obj;

//            Console.WriteLine(copies2);
//        }
//    }
//}
