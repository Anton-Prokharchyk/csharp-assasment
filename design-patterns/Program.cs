using strategy;

public class Program
{
    static void Main()
    {
        Children1 children1 = new Children1(new Action1Perform1());
        Children1 children2 = new Children1(new Action1Perform2());
        children1.performAction1();
        children2.performAction1();
        System.Console.WriteLine("strategy");
    }
}