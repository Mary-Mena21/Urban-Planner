using Planner;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(DateTime.Now.ToShortDateString());
            //Console.WriteLine(DateTime.Now.ToShortTimeString());

            /*--------------------------Test_1- working--------------------------*/
            static void Method_1()
            {
                var buildings = new List<Building>();
                Building building1 = new Building("512 8th Avenue");
                building1.Depth = 1500;
                building1.Width = 3;
                building1.Stories = 4;
                building1.Purchase("Mena");
                building1.Construct();

                //Building.ReferenceEquals(building1, building1);??????????

                Building building2 = new Building("902 8th Avenue");
                building2.Depth = 15;
                building2.Width = 3;
                building2.Stories = 4;
                building2.Purchase("Mariana");
                building1.Construct();

                //building2.Address = "Test";//change the value

                buildings.Add(building1);
                buildings.Add(building2);


                foreach (Building building in buildings)
                {
                    Console.WriteLine("Address :" + building.Address);
                    Console.WriteLine("Designed by: " + building.Designer);
                    Console.WriteLine("Owned by: " + building.Owner);
                    Console.WriteLine("Constructed on: " + building.DateConstructed);
                    Console.WriteLine("Volume " + building.Volume + " cubic meters of space");
                    Console.WriteLine("----------------------------");
                }

            }
            Method_1();
            /*---------------------------Test_2- working--------------------------*/
            static void Method_2()
            {
                var buildings = new List<Building>();
                buildings.Add(new Building("512 8th Avenue") { Depth = 15, Stories = 3, Width = 3 , Owner="Mart"});
                buildings.Add(new Building("902 9th Avenue") { Depth = 10, Stories = 5, Width = 7, Owner = "Mart2" });

                foreach (Building building in buildings)
                {
                    Console.WriteLine("Address :" + building.Address);
                    Console.WriteLine("Designed by: " + building.Designer);
                    Console.WriteLine("Owned by: " + building.Owner);
                    Console.WriteLine("Constructed on: " + building.DateConstructed);
                    Console.WriteLine("Volume " + building.Volume + " cubic meters of space");
                    Console.WriteLine("----------------------------");
                }

                //Console.WriteLine(buildings);
            }
            Method_2();

            Console.ReadLine();

        }
    }
}

//building.VolumeValue(building.Depth,building.Width,building.Stories);

//building.Bulding(building._address);

//building.Bulding(building._dateConstructed.ToShortDateString());


//Building FiveOneTwoEigth = new Building("512 8th Avenue");
//static void displayBuilding()
//{