using System.Collections;

public class Program
{
    private readonly static FileOutput _outFile = new FileOutput("animals.txt");
    private readonly static FileInput _inFile = new FileInput("animals.txt");
    public static void Main(string[] args)
    {
        ArrayList zoo = new ArrayList();

        zoo.Add(new Dog(true, "Bean"));
        zoo.Add(new Cat(9, "Charlie"));
        zoo.Add(new Teacher(44,"Stacy Read"));

        foreach(ITalkable thing in zoo)
        {
            PrintOut(thing);
        }

        _outFile.FileClose();
        _inFile.FileRead();
        _inFile.FileClose(); 
    }

    public static void PrintOut(ITalkable p)
    {
        Console.WriteLine(p.GetName() + " says=" + p.Talk());
        _outFile.FileWrite(p.GetName() + " | " + p.Talk());
    }
}