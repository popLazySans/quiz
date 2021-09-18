using System;
using System.Collections.Generic;
namespace quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Total Rose : ");
            int roseAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Total Sun Flower : ");
            int sunAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Rose");
            flower flow = new flower(0, "", "", 0, "", "");
            Rose roseTree = new Rose(0, "", "", 0, "", "");
            SunFlower sunTree = new SunFlower(0, "", "", 0, "", "");
           
                /*Console.WriteLine("ID : ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Name : ");
                string name = Console.ReadLine();
                Console.WriteLine("Description : ");
                string des = Console.ReadLine();
                Console.WriteLine("Amount : ");
                int amount = int.Parse(Console.ReadLine());
                Console.WriteLine("Height : ");
                string tall = Console.ReadLine();
                Console.WriteLine("Circumference : ");
                string around = Console.ReadLine();*/
                
                flowerInput(roseTree);
                flowerInput(sunTree);
                flow.AddList(roseTree,sunTree);
                 flow.getList();
            
        }
        static void flowerInput(flower tree)
        {
            Console.WriteLine("ID : ");
            tree.ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Name : ");
            tree.TreeName = Console.ReadLine();
            Console.WriteLine("Description : ");
            tree.TreeDescription = Console.ReadLine();
            Console.WriteLine("Amount : ");
            tree.TreeAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("Height : ");
            tree.TreeTall = Console.ReadLine();
            Console.WriteLine("Circumference : ");
            tree.TreeAround = Console.ReadLine();
        }
    }
    class flower
    {
        public int ID;
        public string TreeName;
        public string TreeDescription;
        public int TreeAmount;
        public string TreeTall;
        public string TreeAround;
        public List<Rose> RoseOrder;
        public List<SunFlower> SunFlowersOrder;
        public flower(int id,string name,string description,int amount,string tall,string around)
        {
            ID = id;
            TreeName = name;
            TreeDescription = description;
            TreeAmount = amount;
            TreeTall = tall;
            TreeAround = around;
        }
        public void AddList(Rose rose,SunFlower sunflower)
        {
            RoseOrder.Add(rose);
            SunFlowersOrder.Add(sunflower);
        }
        public void getList()
        {
            
            RoseOrder.ForEach(value => { Console.WriteLine("RoseName : "+value.TreeName); });
            SunFlowersOrder.ForEach(value => { Console.WriteLine("SunFlowerName : " + value.TreeName); });
        }
    }
    class Rose : flower
    {
        public Rose(int id, string name, string description, int amount, string tall, string around):base(id, name, description,amount,tall,around) {
            this.ID = id;
            this.TreeName = name;
            this.TreeDescription = description;
            this.TreeAmount = amount;
            this.TreeTall = tall;
            this.TreeAround = around;
        }
    }
    class SunFlower : flower
    {
        public SunFlower(int id, string name, string description, int amount, string tall, string around) : base(id, name, description, amount, tall, around)
        {
            this.ID = id;
            this.TreeName = name;
            this.TreeDescription = description;
            this.TreeAmount = amount;
            this.TreeTall = tall;
            this.TreeAround = around;
        }
    }

}
