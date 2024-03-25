0.namespace MID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //User Outputs..........................................

            string phrase1 = "Hellow" + "World";
            Console.Write(phrase1);
            string phrase2 = "Hellow";
            Console.Write(phrase2[2]);
            Console.WriteLine("Hello, World!");
            Console.WriteLine(3 + 3);
            Console.Write("Hellow World");

            //Data Types............................................

            int myNum = 5;              //Integer
            double myDoubleNum = 5.95;  //Floating Point Number
            char myletter = 'D';        //Character
            bool myBool = false;        //Boolean
            string myText = "Hellow";   //String

            //User Inputs............................................

            Console.WriteLine("Enter Your Name:");
            string userName = Console.ReadLine();
            Console.WriteLine("username is:" + userName);

            int age = Convert.ToInt32(Console.ReadLine());
            /* Convert.ToBoolean
              Convert.ToDouble */

            //If Statement..........................................

            int time = 12;
            if (time < 12) ;
            {
                Console.WriteLine("Good Morning...");
            }
            else
            {
                Console.WriteLine("Good Evening...");
            }

            //Switch Statement.......................................

            int day = 4;
            switch (day)
            {
                case 6:
                    Console.WriteLine("Today is Saturday.");
                    break;
                case 7:
                    Console.WriteLine("Today is Sunday.");
                    break;
                default:
                    Console.WriteLine("Looking");
                    break;
            }

            //While Loop.............................................

            int i = 0;
            while (i < 5) ;
            {
                Console.WriteLine(i);
                i++;
            }

            //Do/While Loop..........................................

            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);

            //For Loop..............................................

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            //Foreach Loop.........................................

            string[] cars = { "volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            //Array.................................................

            String[] Vehicles = { "volvo", "BMW", "Ford", "Mazda" }
            int[] myNum = { 1, 2, 3, 4, 10, 12 };
            Vehicles[0] = "Audi";
            Console.WriteLine(Vehicles[0]);
            Console.WriteLine(Vehicles.Length);

            //List.................................................

            List<int> num = new List<int>();
            num.Add(1);
            num.Add(20);
            num.Add(50);

            foreach (int num in num)
            { Console.WriteLine(num); }

            //Adding to Numbers Methods...........................

            int Add(int a, int b)
            {
                int sum = a + b;
                return sum;
            }

            //usage..............................................

            int result = Add(5, 10);
            int result = Add(6, 50);


            Console.WriteLine(result);
            Console.WriteLine(result);
            class Program
            {
            static void Main(string[string] args)
                {
                    SayHi("Mike", 35);
                    SayHi("Jhon", 25);

                }
            static void SayHi(string name, int age)
                {
                    Console.WriteLine("Hellow" + name + "You are" + age);
                }
            }

        //class.....................................................
            internal class person
{
    //properties
    public string name { get; set; }

    /*
     public string Name
    {
        get { return name; }
        set { name = value; }
    }
    */

    public int age;
    public double height;
    public double weight;

    //methods

    public void eating()
    {
        Console.WriteLine("i am eating");
        

    }

    public void sleeping()

-----------------------------------------------------------------------------------------------------

    private static void Main(string[] args)
    {
        //creatin objevts
        person person1 = new person();
        person person2 = new person();


        //asssing proppertis for classes

        person1.name = "kamal";
        person1.age = 23;


        person2.name = "nimal";
        person2.age = 25;


        //Assesing to methods
        person1.eating();
           

        Console.WriteLine("name is" + person1.name);
        Console.WriteLine("age is" + person1.age);
    }
}

        }
    }
}
