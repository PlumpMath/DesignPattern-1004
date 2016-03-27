using System;

namespace SimDuck
{
    public class Duck
    {
        protected QuackBehavior.QuackBehavior quackBehavior;
        protected FlyBehavior flyBehavior;

        public virtual void PerformFly()
        {
            flyBehavior.DoFly();
        }

        public virtual void PeformQuack()
        {
            quackBehavior.DoQuack();
        }

        public void ShowDisplay()
        {
            Console.WriteLine(this.GetType());
            PeformQuack();
            PerformFly();
            Console.WriteLine();
        }
    }
}
