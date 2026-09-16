namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /* Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle.Print
               both title and upperTitle to show that title did not change.*/
            string title = "clean code";
            Console.WriteLine(title);
            string upperTitle = title.ToUpper();
            Console.WriteLine(upperTitle);
            #endregion
        }
    }
}
