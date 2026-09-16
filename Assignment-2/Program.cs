using System.Drawing;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region Q1
            ///* Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle.Print
            //   both title and upperTitle to show that title did not change.*/
            //string title = "clean code";
            //Console.WriteLine(title);
            //string upperTitle = title.ToUpper();
            //Console.WriteLine(upperTitle);
            //#endregion
            //#region Q2
            ///*Declare two separate string variables, both set to the literal "Clean Code".Use ReferenceEquals() to check if they point to the same object in memory.*/
            //string title1 = "clean code";
            //string title2 = "clean code";
            //bool sameReference = ReferenceEquals(title1, title2);
            //Console.WriteLine(sameReference);
            //#endregion
            //#region Q3
            ///*Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same object. Print the final result.*/
            //StringBuilder text = new StringBuilder();
            //text.Append("Book List");
            //text.Append(" - Updated");
            //Console.WriteLine(text);
            //#endregion
            //#region Q4 
            /*Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library". Print the result.*/
            //StringBuilder text = new StringBuilder();
            //text.Append("Book List");
            //text.Append(" - Updated");
            //text.Replace("Book List", "Library");
            //Console.WriteLine(text);
            //#endregion
            //#region Q5
            ///*Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code, Pages: 464" using the + operator.*/
            //string title = "Clean Code";
            //int pages = 464;
            //string result = "Book: " + title + ", Pages: " + pages;
            //Console.WriteLine(result);
            //#endregion
            #region Q6
            string title = "Clean Code";
            int pages = 464;
            string result = $"Book:{title},Pages: {pages}";
            Console.WriteLine(result);
            #endregion
        }
    }
}
