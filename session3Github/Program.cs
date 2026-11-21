using System.Text;

namespace session3Github
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 
            string title1 = "Clean code";
            string uppertitle = title1.ToUpper();
            Console.WriteLine(title1);
            Console.WriteLine(uppertitle);
            #endregion
            #region Q2
            String s1 = "Clean code";
            string s2 = "Clean code";
            bool sameref = object.ReferenceEquals(s1, s2);
            Console.WriteLine(sameref);

            #endregion
            #region Q3 ,Q4
            StringBuilder sb = new StringBuilder();
            sb.Append("Book list");
            sb.Append("Updated");
            Console.WriteLine(sb.ToString());
            sb.Replace("Book list", "Library");
            Console.WriteLine(sb.ToString());

            #endregion
            #region Q5 , Q6 ,Q7
            string title2 = "Clean code";
            int pages = 464;
            // Q5 stringConcatenation
            Console.WriteLine("Book :" + title2 + ", Pages :" + pages);
            // Q6 String interpolation
            Console.WriteLine($"Book :{title2} , pages :{pages}");
            // Q7 String formate
            string sentenceFormat = string.Format("Book: {0}, Pages: {1}", title2, pages);
            Console.WriteLine(sentenceFormat); // Book: Clean Code, Pages: 464
            #endregion
            #region Q8
            int Pages = 464;
            if (Pages >= 300)
            {
                Console.WriteLine("Long Book");

            }
            else
            {
                Console.WriteLine("Short book ");

            }
            #endregion
            #region Q9
            int p = 464;
            bool is_available = true;
            if (p>300 && is_available)
            {
                Console.WriteLine("you can borrow this book");
            }

            #endregion
            #region Q10
            string title = "Refactoring";
            switch (title)
            {
                case "Clean code":
                    Console.WriteLine("Great Choice");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice pick ");
                    break;
                default:
                    Console.WriteLine("Never heard of it ");
                    break;
            }
            #endregion
            #region Q11
            int Pages3 = 464;
            string sizeLabel = Pages3 > 300 ? "Long Book" : "Short Book";

            Console.WriteLine(sizeLabel); // Long Book
            #endregion
            #region Q12
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {books[i]}");

            }
            #endregion
            #region Q13
            string[] books2 = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            int index = 0;
            while (index < books2.Length)
            {
                Console.WriteLine(books2[index]);
                index++;
            }
            #endregion
            #region Q14
            int checkCount = 0;
            do
            {
                Console.WriteLine("Checking book...");
                checkCount++;
            } while (checkCount < 3);
            #endregion
            #region Q15
            foreach (string book in books)
            {
                Console.WriteLine(book);
            }
            #endregion
            #region Q16
            foreach (string book in books)
            {
                if (book == "Refactoring")
                {
                    break;
                }

                Console.WriteLine(book);
            }
            #endregion
            #region Q17
            foreach (string book in books)
            {
                if (book == "The Pragmatic Programmer")
                {
                    continue;
                }

                Console.WriteLine(book);
            }
            #endregion
            #region Q18
            void PrintFirstBook(string[] bookList)
            {
                if (bookList == null || bookList.Length == 0)
                {
                    return;
                }

                Console.WriteLine(bookList[0]);
            }
            PrintFirstBook(books); 
            PrintFirstBook(Array.Empty<string>());
            #endregion
        }

    }
}
