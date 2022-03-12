using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.ComplexTypes;
using ConsoleApp1.DatabaseObjects;
using Common;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Main Method");
            Console.WriteLine("******************************************************************");
            #region Commented
            //GreetUser();
            //ApplyConditions();
            //DisplayRowsWithAstrix();
            //ProcessArray();
            //ProcessCollections();
            //ProcessProduct();
            //ProductCollection();
            //ProcessProductOverloadedConstructor();
            //ProcessProductMethods();
            //DisplayFictionBookDetails();
            //DisplayBookTags();


            //CourseBook newBook =new CourseBook();
            //newBook.Subject = "Maths";
            //newBook.ID = 2;
            //newBook.Author = "Author";
            // newBook.Title = "Title";

            // string details=newBook.GetDetails();

            //Console.WriteLine(details);
            //DisplayBookTags();
            //
            #endregion Commented
            //AddNewFictionBook(); 
            ProcessCourseBookInvoice();

            ProcessProductInvoice();

            Console.WriteLine("******************************************************************");
            //Console.WriteLine("Back to Main Method");

            Console.ReadKey();
        }

        private static void ProcessProductInvoice()
        {
            var product = ProcessProduct();

            InvoiceManager invoiceManager = new InvoiceManager(product);
            invoiceManager.GenerateInvoice();
        }

        private static void ProcessCourseBookInvoice()
        {
            //Crreate a coursebook
            var book = AddNewCourseBook();

            //Generate Invoice for course book
            InvoiceManager invoiceManager = new InvoiceManager(book);
            invoiceManager.GenerateInvoice();
        }

        #region << Already Covered >>

        private static void AddNewFictionBook()
        {
            FictionBook fiction1 = new FictionBook()
            {
                ID = 2,
                Author = "Alistair Macneil",
                Title = "Guns from Navaron",
            };

            fiction1.AddTag("mystery");
            fiction1.AddTag("crime");

            TagsManager tagsManager = new TagsManager(fiction1, fiction1);
            tagsManager.SaveTags();
        }

        private static CourseBook AddNewCourseBook()
        {
            CourseBook coursebook = new CourseBook(4, "ABC of Mathematics", "Chris Ferrie", "Maths");

            //coursebook.AddTag("maths");
            //coursebook.AddTag("fundamentals");
            //coursebook.AddTag("senior secondary");

            //TagsManager tagsManager = new TagsManager(coursebook, coursebook);
            //tagsManager.SaveTags();

            return coursebook;
        }

        private static void DisplayBookTags()
        {
            FictionBook fiction = new FictionBook()
            {
                ID = 1,
                Author = "Joseph Heller",
                Title = "Catch22",
                Type = "War Satire"
            };

            fiction.AddTag("war");
            fiction.AddTag("satire");
            fiction.AddTag("fiction");
            fiction.AddTag("yossarian");
            Console.WriteLine(fiction.GetDetails());
            Console.WriteLine("tags: " + fiction.GetTags());
        }

        private static void DisplayFictionBookDetails()
        {
            FictionBook fiction = new FictionBook()
            {
                ID = 1,
                Author = "Joseph Heller",
                Title = "Catch22",
                Type = "War Satire"
            };
            Console.WriteLine(fiction.GetDetails());
        }

        private static void ProcessProductMethods()
        {
            //Product p = new Product(1, "C# Step By Step", "Book");

            try
            {
                Product p = new Product();

                string description = p.GetProductDescription();

                Console.WriteLine(description);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occured: " + ex.Message);
            }
        }

        private static void ProcessProductOverloadedConstructor()
        {
            Product product = new Product(1, "microwave", "kitchen appliance");


            Console.WriteLine();
            Console.WriteLine("ProcessProduct Method");
            Console.WriteLine("******************************************************************");

            Console.WriteLine("Product properties");
            DisplayProductDetails(product);
        }
       
        private static Product ProcessProduct()
        {
            Product product = new Product(1, "book", "reading");

            Console.WriteLine();
            Console.WriteLine("ProcessProduct Method");
            Console.WriteLine("******************************************************************");

            Console.WriteLine("Product properties");
            DisplayProductDetails(product);

            return product;
        }

        private static void ProductCollection()
        {
            Console.WriteLine();
            Console.WriteLine("ProcessProduct Method");
            Console.WriteLine("******************************************************************");

            List<Product> listProduct = new List<Product>()
            {
                new Product(3, "Keyboard", "input"),
                new Product() { ID = 4, Name = "monitor", Type = "display" },
                new Product() { ID = 5, Name = "mouse", Type = "input" },
                new Product() { ID = 3, Name = "table", Type = "space" }
            };

            listProduct.Add(new Product() { ID = 10, Name = "flashdrive", Type = "memory" });

            listProduct.ForEach(p => DisplayProductDetails(p));
        }

        private static void DisplayProductDetails(Product p)
        {
            Console.WriteLine("The type of the product: " + p.Type + ". ID: " + p.ID + " And the name of the product is: " + p.Name);
        }

        private static void ProcessCollections()
        {
            Console.WriteLine();
            Console.WriteLine("ProcessCollections Method");
            Console.WriteLine("******************************************************************");


            List<int> numbersList = new List<int> { 1, 2, 3, 4, 5, 10, 13 };
            //List<string> stringList = new List<string> { "apple","orange" };


            //Console.WriteLine("The First element in Array is: " + numbersList.First());

            //var numGT3= stringList.Where(x => x =="orange").First();

            //Console.WriteLine("This is the first element greater than 3: "+numGT3);


            Console.WriteLine();
            Console.WriteLine("Displaying all elements in List.....");

            numbersList.ForEach(x =>
            {
                if (x > 5)
                {
                    Console.WriteLine(x + 100);
                }

            });

            Console.WriteLine("Adding new elements to the list");
            numbersList.Add(500);
            numbersList.Insert(1, 550);
            numbersList.AddRange(new List<int> { 2000, 4000 });

            Console.WriteLine("Displaying all elements in List.....");
            numbersList.ForEach(x => { Console.WriteLine(x); });

            //Console.WriteLine();
            //Console.WriteLine("The third element in Array is: " + numbersList[3]);
        }

        private static void ProcessArray()
        {
            Console.WriteLine();
            Console.WriteLine("ProcessArray Method");
            Console.WriteLine("******************************************************************");

            int[] numbersArray = new int[3];
            numbersArray = new int[3] { 1, 2, 3 };

            DisplayArrayElementsUsingForeach(numbersArray);

            WriteAllArrayElements(numbersArray);

            Console.WriteLine();
            Console.WriteLine("The First element in Array is: " + numbersArray[0]);

            Console.WriteLine();
            Console.WriteLine("Changing the first element value to 6......");
            numbersArray[0] = 6;
            Console.WriteLine("The First element in Array is now: " + numbersArray[0]);

            WriteAllArrayElements(numbersArray);
            DisplayArrayElementsUsingForeach(numbersArray);
        }

        private static void DisplayArrayElementsUsingForeach(int[] numbersArray)
        {
            Console.WriteLine();
            Console.WriteLine("Displaying all elements in array using foreach.....");
            foreach (var x in numbersArray)
            {
                Console.WriteLine(x);
            }
        }

        private static void WriteAllArrayElements(int[] numbersArray)
        {
            Console.WriteLine();
            Console.WriteLine("Displaying all elements in array.....");


            for (int i = 0; i < numbersArray.Length; i++)
            {
                Console.WriteLine(numbersArray[i]);
            }
            Console.WriteLine("ALL ELEMENTS ARE DISPLAYED");
        }

        private static void DisplayRowsWithAstrix()
        {
            Console.WriteLine();
            Console.WriteLine("DisplayRowsWithAstrix Method");
            Console.WriteLine("******************************************************************");

            Console.Write("Enter number of rows: ");
            string number = Console.ReadLine();
            int num = Convert.ToInt32(number);
            int i = 0;
            for (; i < num;)
            {
                Console.WriteLine("*");
                i++;
            }

            Console.WriteLine("Loop Ends here.");
        }

        private static void ApplyConditions()
        {
            Console.WriteLine();
            Console.WriteLine("ApplyConditions Method");
            Console.WriteLine("******************************************************************");
            Console.Write("Please enter a number: ");
            string number = Console.ReadLine();
            int num = Convert.ToInt32(number);

            if (num < 10)
            {
                Console.WriteLine($"Entered number {num} is less than 10");
            }
            else
            {
                Console.WriteLine($"Entered number {num} is equals to or greater than 10");
            }
            Console.WriteLine("******************************************************************");
        }

        static void GreetUser()
        {
            Console.WriteLine();
            Console.WriteLine("GreetUser Method");
            Console.WriteLine("******************************************************************");
            Console.Write("Please type your Name here: ");
            string name = Console.ReadLine();
            string message = GetMessage(name);
            Console.WriteLine("Welcome Message: ");
            Console.WriteLine(message);
            Console.WriteLine();
            Console.WriteLine("******************************************************************");
        }

        static string GetMessage(string name)
        {
            return "HELLO " + name + " Good Morning";
        }
        #endregion << Already Covered >>
    }
}
