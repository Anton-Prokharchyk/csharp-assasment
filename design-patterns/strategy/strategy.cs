using System;

namespace strategy
{
    public interface Action1
    {
        public void move1();
    }
    public interface Action2
    {
        public void move2();
    }
    public class Action1Perform1 : Action1
    {
        public void move1()
        {
            System.Console.WriteLine("Action1 perform 1");

        }
    }
    public class Action1Perform2 : Action1
    {
        public void move1()
        {
            System.Console.WriteLine("Action1 perform 2");
        }
    }
    public class Action1Perform3 : Action1
    {
        public void move1()
        {
            System.Console.WriteLine("Action1 not performed");
        }
    }
    public class Action2Perform1 : Action2
    {
        public void move2()
        {
            System.Console.WriteLine("Action2 perform 1");
        }
    }
    public class Action2Perform2 : Action2
    {
        public void move2()
        {
            System.Console.WriteLine("Action2 perform 2");
        }
    }
    public class Action2Perform3 : Action2
    {
        public void move2()
        {
            System.Console.WriteLine("Action1 not performed");
        }
    }
    public abstract class Parent
    {
        public Action1 action1;
        public Action2 action2;

        public void performAction1()
        {
            this.action1.move1();
        }
        public void performAction2()
        {
            this.action2.move2();
        }
    }
    public class Children1 : Parent
    {
        public Children1(Action1 a1)
        {
            this.action1 = a1;
        }

    }
    public class Children2 : Parent
    {
        public Children2(Action2 a2)
        {
            this.action2 = a2;
        }
    }
}
