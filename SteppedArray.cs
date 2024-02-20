using System;
namespace HomeWork_Makarov_Ivan_number_3._1
{
	public sealed class SteppedArray : BaseArray,ISteppedArray
    {
        private int[][] array;
        public SteppedArray(bool personGet) : base(personGet)
        {

        }
        protected  override void GetfromPerson()
        {

            
            Console.WriteLine("Введите количество ступеней массива: ");
            int inputArray = int.Parse(Console.ReadLine());
            array = new int[inputArray][];
            for (int i = 0; i < array.Length; i++)
            {

                Console.Write("Введите длину ступени массива: ");
                array[i] = new int[int.Parse(Console.ReadLine())];
                Console.WriteLine("Вводите значения массива: ");
                for (int j = 0; j < int.Parse(Console.ReadLine()); j++)
                {
                    int value = int.Parse(Console.ReadLine());
                    array[i][j] = value;
                }


            }
            Console.WriteLine(array);

        }
        protected override void GetfromRandom()
        {
            Random random = new Random();
            int inputArray = random.Next(2, 10);
            array = new int[inputArray][];
            int length;
            for (int i = 0; i < inputArray; i++)
            {
                length = random.Next(2, 10);
                array[i] = new int[length];
                for (int j = 0; j < array[i].Length; j++)
                {
                    int value = random.Next(0, 10);
                    array[i][j] = value;
                }
            }
            
        }
        
        public override decimal GetAverage()
        {
            decimal summa = 0;
            decimal count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    summa += array[i][j];
                    count++;

                }
            }
            return summa / count;
        }
        public decimal GetAverageValueFromArraysInSteppedArray()
        {
            decimal summa = 0;
            int counter = 0;
            double[] averages = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {

                int length = array[i].Length;
                int sum = array[i].Sum();
                counter += array[i].Length;
                for (int j = 0; j < array[i].Length; j++)
                {
                    summa += array[i][j];

                }

            }
            decimal result = summa / counter;


            return result;
        }
        int[][] ISteppedArray.Change()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] % 2 == 0)
                    {
                        array[i][j] = i * j;
                    }
                }
            }
            return array;
        }
        public override void Print()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write($"{array[i][j]}");
                }
                Console.Write("\n");    
            }
        }
    }
}

