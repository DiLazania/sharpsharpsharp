using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    public class Duck
    {
        public virtual void quack()
        {
            Console.WriteLine("Quack!");
        }

        public void random_duck()
        {
            var r = new Random();
            var value = r.Next(0, 5);
            switch (value)
            {
                case 0:
                    var ordinaryDuck = new OrdinaryDuck();
                    ordinaryDuck.quack();
                    break;
                case 1:
                    var greyDuck = new GreyDuck();
                    greyDuck.quack();
                    break;
                case 2:
                    var lovefulDuck = new LovefulDuck();
                    lovefulDuck.quack();
                    break;
                case 3:
                    var blackDuck = new BlackDuck();
                    blackDuck.quack();
                    break;
                case 4:
                    var redDuck = new RedDuck();
                    redDuck.quack();
                    break;
                case 5:
                    var rubberDuck = new RubberDuck();
                    rubberDuck.quack();
                    break;
            }
        }
    }

    public class OrdinaryDuck : Duck
    {
        public override void quack() { }
    }

    public class BlackDuck : Duck
    {
        public override void quack()
        {
            Console.WriteLine("I am a black duck");
        }
    }

    public class GreyDuck : Duck
    {
        public override void quack()
        {
            Console.WriteLine("Hello! I am a grey duck");
        }
    }

    public class RedDuck : Duck
    {
        public override void quack()
        {
            Console.WriteLine("Hey! I am a red duck");
        }
    }

    public class RubberDuck : Duck
    {
        public override void quack()
        {
            Console.WriteLine("Hi! I am a rubber duck");
        }
    }


    public class LovefulDuck : Duck
    {
        public override void quack()
        {
            var r = new Random();
            var val = r.Next(0, 5);
            switch (val)
            {
                case 0:
                    Console.WriteLine("I am a loveful duck and my favorite team is Sharpei");
                    break;
                case 1:
                    Console.WriteLine("I am a loveful duck and my favorite team is Reticolo");
                    break;
                case 2:
                    Console.WriteLine("I am a loveful duck and my favorite team is Aktio");
                    break;
                case 3:
                    Console.WriteLine("I am a loveful duck and my favorite team is Yey");
                    break;
                case 4:
                    Console.WriteLine("I am a loveful duck and my favorite team is Hedgehogs");
                    break;
            }
        }
    }
}
