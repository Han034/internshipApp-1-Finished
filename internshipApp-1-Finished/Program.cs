namespace internshipApp_1_Finished
{
    internal class Program
    {
        /*
            |TR|
            9>x>1 ve tek sayı olacak şekilde kontrol et ve piramit oluştur.
            Başına konulacak boşluk = (x-1)/2
            Satır adedi a = (x+1)/2
            Satır başı düşecek yıldız adedi = n+2
            -------------------------------------------------------------------
            |ENG|
            Check as 9>x>1 and odd number and create pyramid.
            Space to start = (x-1)/2
            Number of rows a = (x+1)/2
            Number of stars to drop per line = n+2
         */
        public static int GetNumber()
        {
            Console.Write("Please enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;

        }       //Return the first number
        public static void Menu()
        {
            //1. getPyn     //birden fazla for  
            //2. getPy2     //2 for ile 
            //3. getPyRec   // Recursive ile 
            //4.GetPyBaklava
            //5 GetPyEmptyBaklava
            Console.WriteLine("1. getPyn            -a lot of 'for'");
            Console.WriteLine("2. getPy2            -2 'for'");
            Console.WriteLine("3. getPyRec          -Recursive");
            Console.WriteLine("4. GetPyBaklava      -Turkish Baklava method");
            Console.WriteLine("5. GetPyEmptyBaklava -Empty Baklava");
            Console.WriteLine("Select the action you want to go to in the menu: (Enter your number...)");
            int mNum = Convert.ToInt32(Console.ReadLine());

            switch (mNum)
            {
                case 1:
                    GetPyn();
                    break;
                case 2:
                    GetPy2();
                    break;
                case 3:
                    GetPyRec();
                    break;
                case 4:
                    GetPyBaklava();
                    break;
                case 5:
                    GetPyEmptyBaklava();
                    break;
                default:
                    Console.WriteLine("man go smart");
                    break;
            }
        }           //Menu bar
        public static void GetPyn()
        {
            while (true)
            {
                int num = GetNumber();
                Console.WriteLine("Selected number is : " + num); //output

                if (num > 1 && num < 9 && num % 2 == 1)
                {
                    //Pyramid block
                    for (int i = 1; i <= num; i += 2) //Number of columns
                    {
                        for (int x = i; x <= num; x += 2) //Number of spaces
                        {
                            Console.Write(" ");
                        }
                        for (int j = 1; j <= i; j += 1) //number of stars
                        {
                            Console.Write("*");

                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("Pyramid succesfully created");
                }
                else
                {
                    Console.WriteLine(pointer + "Incorrect entry made");
                    if (num < 1 || num > 9)
                        Console.WriteLine(pointer + "Please enter 1 to 9");
                    else
                    {
                        Console.WriteLine(pointer + "Enter a single number");
                    }

                }
            }
        }         //A lot of for method
        public static void GetPy2()
        {
            while (true)
            {
                int num = GetNumber();
                Console.WriteLine("Selected number is : " + num); //output

                if (num > 0 && num < 100 && num % 2 == 1)
                {
                    for (int i = 1; i <= num; i += 2)
                    {
                        for (int j = 0; j < num; j++) //number of stars
                        {
                            if (j < Math.Abs(num - i) / 2)
                            {
                                Console.Write("s");
                            }
                            else if (j < (Math.Abs(num - i) / 2) + i)// i < Math.Abs(num - j) / 2
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write("s");
                            }
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine(pointer + "Incorrect entry made");
                    if (num < 1 || num > 9)
                        Console.WriteLine(pointer + "Please enter 1 to 9");
                    else
                    {
                        Console.WriteLine(pointer + "Enter a single number");
                    }

                }

            }
        }         //With 2 for method
        public static void GetPyRec()
        {
            int num = GetNumber();
            Recursive(num, 1);
            static void Recursive(int num, int starCount)
            {
                if (starCount > num)
                    return;

                for (int j = 0; j < num; j++)
                {
                    if (j < Math.Abs(num - starCount) / 2)
                    {
                        Console.Write("s");
                    }
                    else if (j < (Math.Abs(num - starCount) / 2) + starCount)// i < Math.Abs(num - j) / 2
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("s");
                    }
                }

                Console.WriteLine();
                Recursive(num, starCount += 2);
            }
        }       //Recursive method 
        public static void GetPyBaklava()
        {
            int num = GetNumber();
            Console.WriteLine("Selected number is : " + num); //output

            if (num > 0 && num < 100 && num % 2 == 1)
            {
                for (int i = 1; i <= num; i++)
                {
                    for (int j = 0; j < Math.Abs(i - (num / 2 + 1)); j++)
                    {
                        Console.Write("s");
                    }

                    for (int j = 0; j < num - Math.Abs(num - (i * 2 - 1)); j++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }
            }
        }   //Turkish baklava method :)
        public static void GetPyEmptyBaklava()
        {
            int num = GetNumber();
            Console.WriteLine("Selected number is : " + num); //output

            if (num > 0 && num < 100 && num % 2 == 1)
            {
                for (int i = 1; i <= num; i++)
                {
                    for (int j = 0; j < Math.Abs(i - (num / 2 + 1)); j++)
                    {
                        Console.Write(" ");
                    }

                    int starCount = num - Math.Abs(num - (i * 2 - 1));
                    for (int j = 1; j <= starCount; j++)
                    {
                        if (j == 1 || starCount == j)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }

                    }

                    Console.WriteLine();
                }
            }
        }
        static string pointer = ">>>";

        static void Main(string[] args)
        {
            Menu();


        }
    }
}
