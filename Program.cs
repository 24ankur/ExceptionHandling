using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Mathematics Game ");
            Executor.GameDriver();
        }

    }
        public class Executor
        {
            public static void GameDriver()
            {
                int count = 1;
                do
                {
                    count++;
                    Console.WriteLine("Enter any number between 1 to 5");

                    int choice = 0;
                    try
                    {
                        choice = int.Parse(Console.ReadLine());
                        if (choice < 1 || choice > 5)
                            throw new CustomException("Please Input Between 1 to 5");
                    }
                    catch (CustomException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch
                    {
                        Console.WriteLine("Invalid Input");
                    }
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter even number");
                            try
                            {
                                int num = int.Parse(Console.ReadLine());
                                EvenNumber(num);
                            }
                            catch (CustomException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            catch
                            {
                                Console.WriteLine("Invalid Input");
                            }
                            break;
                        case 2:
                            Console.WriteLine("Enter odd number");
                            try
                            {
                                int num = int.Parse(Console.ReadLine());
                                OddNumber(num);
                            }
                            catch (CustomException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            catch
                            {
                                Console.WriteLine("Invalid Input");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Enter prime number");
                            try
                            {
                                int num = int.Parse(Console.ReadLine());
                                PrimeNumber(num);
                            }
                            catch (CustomException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            catch
                            {
                                Console.WriteLine("Invalid Input");
                            }
                            break;
                        case 4:
                            Console.WriteLine("Enter Negative number");
                            try
                            {
                                int num = int.Parse(Console.ReadLine());
                                NegativeNumber(num);
                            }
                            catch (CustomException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            catch
                            {
                                Console.WriteLine("Invalid Input");
                            }
                            break;
                        case 5:
                            Console.WriteLine("Enter  Zero");
                            try
                            {
                                int num = int.Parse(Console.ReadLine());
                                ZeroNumber(num);
                            }
                            catch (CustomException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            catch
                            {
                                Console.WriteLine("Invalid Input");
                            }
                            break;
                    }
                }
                while (count <= 5);
            }

            static void EvenNumber(int num)
            {
                if (num % 2 == 0)
                    Console.WriteLine("Success");
                if (num % 2 != 0)
                    throw new CustomException("Invalid Even NUmber");
            }
            static void OddNumber(int num)
            {
                if (num % 2 != 0)
                    Console.WriteLine("Success");
                if (num % 2 == 0)
                    throw new CustomException("Invalid Odd NUmber");

            }
            static void PrimeNumber(int num)
            {
                int m = num / 2;
                int flag = 0;
                for (int i = 2; i <= m; i++)
                {
                    if (num % i == 0)
                    {
                        flag = 1;
                        throw new CustomException("Invalid Prime NUmber");
                       
                    }
                }
                if (flag == 0)

                    Console.Write("Success");

            }
            static void NegativeNumber(int num)
            {

                if (num < 0)
                    Console.WriteLine("Success");
                if (num > 0)
                    throw new CustomException("Invalid Negative Number");



            }
            static void ZeroNumber(int num)
            {
                if (num == 0)
                    Console.WriteLine("Success");
                if (num != 0)
                    throw new CustomException("Invalid zero NUmber");

            }
        }
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {

        }
    }


}      
        //public class InvalidEvenNumberException : Exception
        ///{
        ///   public InvalidEvenNumberException(string message) : base( message)
        ///   {

        ///    }
       ///similarly all error.
 



