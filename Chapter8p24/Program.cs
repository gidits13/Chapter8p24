namespace Chapter8p24
{
    internal class Program
    {
        static void MoveToRBin()
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(@"/Users/VARGGOTH/Desktop/testFolder");
                string trashPath = "/$Recycle.Bin/testFolder";

                dirInfo.MoveTo(trashPath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            MoveToRBin();
            Console.WriteLine("Hello, World!");
        }
    }
}