static void Main(string[] args)
        {
            int sum, numb1, numb2, numb3, numb4;
            Console.Write("Please input your first number: ");
            numb1 = int.Parse(Console.ReadLine());
            if (!(numb1 == 10))
            {
                Console.Write("Please input the number again: ");
                numb2 = int.Parse(Console.ReadLine());
                if (!(numb1 + numb2 == 10))
                {
                    Console.Write("Please input the number again: ");
                    numb3 = int.Parse(Console.ReadLine());
                    if (!(numb1 + numb2 + numb3 == 10))
                    {
                        Console.Write("Please input the number again: ");
                        numb4 = int.Parse(Console.ReadLine());
                        if (numb1 + numb2 + numb3 + numb4 <= 10 || numb1 + numb2 + numb3 + numb4 >= 10)
                        {
                            Console.WriteLine("Your number is {0}", numb1 + numb2 + numb3 + numb4);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Your number is {0}", numb1 + numb2 + numb3);
                    }
                }
                else
                {
                    Console.WriteLine("Your number is {0}", numb1 + numb2);
                }
            }
            else
            {
                Console.WriteLine("Your number is {0}", numb1);
            }
            Console.ReadLine();
        }
