using System;
using static System.Console;
class Program
{
    public static void Main(string[] args)
    {
        string input;
        do
        {
            DisplayMenu();
            WriteLine("-----------------------------------------------------");
            WriteLine("Enter the number (1-5) to continue or 0 to exit: ");
            input = ReadLine();
            switch (input)
            {
                case "1":
                    MCDetails();
                    break;
                case "2":
                    MCEff();
                    break;
                case "3":
                    QCReport();
                    break;
                case "4":
                    DefRatio();
                    break;
            }
        } while (input != "0");
    }
    static void DisplayMenu()
    {
        WriteLine("-----------------");
        WriteLine("Main Menu");
        WriteLine("-----------------");
        WriteLine("1) Input Machine Details");
        WriteLine("2) Check Machine Efficiency");
        WriteLine("3) Input Quality Report");
        WriteLine("4) Check Defective Ratio");
        WriteLine("0) To Exit");
    }
    public static void MCDetails()
    {
        Write("Machine No: ");
        string machine = ReadLine();
        Write("Lot Number: ");
        string lot = ReadLine();
        Write("Downtime(mins): ");
        int downtime = Convert.ToInt32(ReadLine());
        Write("Total runtime (mins): ");
        int run = Convert.ToInt32(ReadLine());

        string header1 = "Machine No.";
        string header2 = "Lot Number";
        string header3 = "Downtime";
        string header4 = "Runtime";
        WriteLine("------------------------------------------------");
        WriteLine($"{header1,5}{header2,15}{header3,10}{header4,10}");
        WriteLine($"{machine,5}{lot,21}{downtime,10}{run,10}");
    }
    public static void MCEff()
    {
        WriteLine("Here lies your code for displaying machine efficiency.");
    }
    public static void QCReport()
    {
        WriteLine("Here lies your code for inputting quality report.");
    }
    public static void DefRatio()
    {
        WriteLine("Here lies your code for displaying defective ratio.");
    }

}
