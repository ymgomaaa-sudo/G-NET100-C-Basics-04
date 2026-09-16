using System.Drawing;
using System.Text;

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
            #region Q2
            /*Declare two separate string variables, both set to the literal "Clean Code".Use ReferenceEquals() to check if they point to the same object in memory.*/
            string title1 = "clean code";
            string title2 = "clean code";
            bool sameReference = ReferenceEquals(title1, title2);
            Console.WriteLine(sameReference);
            #endregion


        }
    }
}
