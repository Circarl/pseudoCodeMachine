class Program
{

    public static void DisplayMenu()
    {
        Console.WriteLine("\n-----------------");
        Console.WriteLine("Main Menu");
        Console.WriteLine("-----------------");
        Console.WriteLine("1) Input Machine Details");
        Console.WriteLine("2) Display Machines Stored");
        Console.WriteLine("3) Check Machine Efficiency");
        Console.WriteLine("4) Input Quality Report");
        Console.WriteLine("5) Check Defective Ratio");
        Console.WriteLine("0) To Exit");
        inputFromMenu();

    }
    public static void inputFromMenu() //problem if input 0 on next 2 to 3 displays repeats itself before it exits
    {
        int i = 0;
        string[] input = new string[20];
        do
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.Write("Enter the number (1-5) to continue or 0 to exit: ");
            input[i] = Console.ReadLine();
            switch (input[i])
            {
                case "1":
                    saveMCDetails();
                    break;
                case "2":
                    displayMachineList();
                    break;
                case "3":
                    QCReport();
                    break;
                case "4":
                    DefRatio();
                    break;
            }
        } while (input[i] != "0");
        i++;
    }

    public static void saveMCDetails()
    {
        int ctr = 0;

        string[] machine = new string[10];
        string[] lot = new string[10];
        int[] downtime = new int[10];
        int[] run = new int[10];

        bool saved = false;
        char rep = ' ';
        do
        {
            Console.Write("Machine No: ");
            machine[ctr] = Console.ReadLine();
            Console.Write("Lot Number: ");
            lot[ctr] = Console.ReadLine();
            Console.Write("Downtime(mins): ");
            downtime[ctr] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Total runtime (mins): ");
            run[ctr] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Machine Details Saved!");
            Console.WriteLine("Showing Description below");
            showMachineDescription(machine[ctr], lot[ctr], downtime[ctr], run[ctr]);
            saveMachineList(machine[ctr], lot[ctr], downtime[ctr], run[ctr]);
            ctr++;

            Console.WriteLine("Do you want to print Machine info? y/n");
            rep = Convert.ToChar(Console.ReadLine());
            if (rep == 'y')
                displayMachineList(machine[ctr], lot[ctr], downtime[ctr], run[ctr]);
            else
                break;
            saved = false;
        } while (saved == true);
    }

    private static void saveMachineList(string v1, string v2, int v3, int v4)
    {
        throw new NotImplementedException();
    }
    private static void displayMachineList(string v1, string v2, int v3, int v4)
    {
        throw new NotImplementedException();
    }

    public static void showMachineDescription(string machine, string lot, int downtime, int run)
    {
        string header1 = "Machine No.";
        string header2 = "Lot Number";
        string header3 = "Downtime";
        string header4 = "Runtime";
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine($"{header1,5}{header2,15}{header3,10}{header4,10}");
        Console.WriteLine($"{machine,5}{lot,21}{downtime,10}{run,10}");
        Console.Write("Enter Any to key - back to Menu: ");
        Console.ReadKey();
        DisplayMenu();
    }
    public static void displayMachineList()
    {
        Console.WriteLine("Here lies your code for displaying machine efficiency.");
    }
    public static void QCReport()
    {
        Console.WriteLine("Here lies your code for inputting quality report.");
    }
    public static void DefRatio()
    {
        Console.WriteLine("Here lies your code for displaying defective ratio.");
    }
    static void fileCheck()
    {
        String path = @"C:\Users\circa\OneDrive\Documents\[Software Engineering Fundamentals]\python coding tests\pseudoCo_Project\pseudoCo_Project\Example.txt";

        if (File.Exists(path))
            Console.WriteLine("Data Loaded File Exists . . .");
        else
            Console.WriteLine("File not found.");
    }
    static void saveMachineList(string[] machine, string[] lot, int[] down, int[] run)
    {
        int ctr1 = 0;
        string[] saveMachine = new string[10];
        string[] saveLot = new string[10];
        int[] saveDowntime = new int[10];
        int[] saveRun = new int[10];

        saveMachine[ctr1] = machine[ctr1];
        saveLot[ctr1] = lot[ctr1];
        saveDowntime[ctr1] = down[ctr1];
        saveRun[ctr1] = run[ctr1];
        ctr1++;
    }
    static void displayMachineList(string[] machine, string[] lot, int[] down, int[] run)
    {
        int ctr1 = 0;
        string[] saveMachine = new string[10];
        string[] saveLot = new string[10];
        int[] saveDowntime = new int[10];
        int[] saveRun = new int[10];

        saveMachine[ctr1] = machine[ctr1];
        saveLot[ctr1] = lot[ctr1];
        saveDowntime[ctr1] = down[ctr1];
        saveRun[ctr1] = run[ctr1];
        ctr1++;
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Machine: {saveMachine[ctr1]},Lot#: {saveLot[ctr1]}, DT: {saveDowntime[ctr1]}, RUN: {saveRun[ctr1]}");

        }
        Console.WriteLine();
    }
    public static void Main(string[] args)
    {
        fileCheck();
        DisplayMenu();

    }

}