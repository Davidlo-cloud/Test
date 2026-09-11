namespace simpleGit;

class Program
{
    static void Main()
    {
        System.Console.WriteLine("Hello Git!");
        System.Console.WriteLine(DoSomething("David"));
    }
    static string DoSomething(string name)
    {
        return $"Hello {name}";
    }
}