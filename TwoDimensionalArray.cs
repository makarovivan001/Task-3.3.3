using System;
namespace HomeWork_Makarov_Ivan_number_3._1
{
	public sealed class TwoDimensionalArray : BaseArray,ITwoDimensionalArray
	{
        private int[,] array;

        public TwoDimensionalArray(bool personGet) : base(personGet)
        {
           
        }
        public override void Print()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");

                }
                Console.Write("\n");

            }
        }
        protected override void GetfromPerson()
        {
            Console.Write("Введите длину: ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Введите ширину: ");
            int width = int.Parse(Console.ReadLine());
            array = new int[length, width];
            Console.WriteLine("Вводите значения: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int value = int.Parse(Console.ReadLine());
                    array[i, j] = value;
                }
            }
            
        }
        protected override void GetfromRandom()
        {
            Random random = new Random();

            int length = random.Next(2, 10);
            int width = random.Next(2, 10);
            array = new int[length, width];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    int value = random.Next(0, 10);
                    array[i, j] = value;
                }
            }
            
        }
        

        public override decimal GetAverage()
        {
            decimal summa = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    summa += array[i, j];
                }
            }
            return summa / array.Length ;
        }
        void ITwoDimensionalArray.PrintAsMatrix()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($"{array[i, j]} ");
                    }
                    else
                    {
                        Console.Write($"{array[i, array.GetLength(1) - j - 1]} ");
                    }

                }
                Console.Write("\n");
            }


        }
    }
}

