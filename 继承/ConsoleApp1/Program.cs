using System;

namespace ConsoleApp1
{
    abstract class Shape
    {
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
        protected int width;
        protected int height;
        // 抽象方法
        public abstract int test();
        //虚方法
        public virtual void Virtual()
        {
            Console.WriteLine("override0");
        }
    }

    public interface PaintCost
    {
        int getMoneyCost(int area);

        //int getMaterialCost(int area);
    }

    class Rectangle : Shape, PaintCost  //继承shape，调用接口PaintCost,实现多重继承
    {
        public int getArea()
        {
            return width * height;
        }
        
        public int getMoneyCost(int area)
        {
            return area * 70;
        }
        // 抽象方法需要重写
        public override int test()
        {
            return 0;
        }
        public virtual void Virtual()
        {
            Console.WriteLine("override1");
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Rectangle wall = new Rectangle();
            wall.setWidth(5);
            wall.setHeight(6);
            int area = wall.getArea();
            Console.WriteLine(area);
            int cost = wall.getMoneyCost(area);
            Console.WriteLine(cost);
            wall.Virtual();

            Console.ReadKey();
        }
    }
}
