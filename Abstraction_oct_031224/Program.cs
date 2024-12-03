using Abstraction_oct_031224.Assignment;
using Abstraction_oct_031224.NewFolder;

namespace Abstraction_oct_031224
{
    abstract class ABclass
    {
        int abVar;
        protected ABclass()
        {
            abVar = 678;
            Console.WriteLine("abstract class constructor called...");
        }
        protected ABclass(int a)
        {
            abVar = a;
        }
        virtual public void show()
        {
            Console.WriteLine("show from ABClass");
        }
        abstract public int sum(int a, int b);//1
        public abstract void total(float a,float b,float c);//2
    }
    class classB : ABclass
    {
        public classB():base(200)
        {
            
        }
        override  public void show()
        {
            Console.WriteLine("show from B");
        }
        public override int sum(int x, int y)
        {
            Console.WriteLine("sum from class B");
            return x+y;
        }
        // override -->  1)  virtual AND override   2) abstract AND override
        public override void total(float a, float b, float c)
        {
            Console.WriteLine("total from class B");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ////classB objB = new classB();
            ////objB.show();
            ////int c=objB.sum(100, 200);
            ////Console.WriteLine(c);

            //ABclass objA = new classB();


            //objA.show();//abstract class ABclass// not run time poly
            //int x = objA.sum(11, 22);// classB  // run time poly
            //objA.total(1.1f, 2.2f, 3.3f);  // run time poly

            //  BB obj1 = new BB();

            classB obB2 = new classB();
            Circle c1 = new Circle();
            c1.area();
            c1.display();
        }
    }
}
