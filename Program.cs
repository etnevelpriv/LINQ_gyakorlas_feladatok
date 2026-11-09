namespace LINQ_gyakorlas_feladatok;

class Program()
{
    Diak[] diakok = [];
    private static void FajlBeolvasas ()
    {
        string[] sorok = File.ReadAllLines("./diakok.csv");
        foreach(string sor in sorok)
        {
            Console.WriteLine(sor);
        }
    }
    static void Main()
    {
     FajlBeolvasas();   
    }
}