using System;
using HomeWork_Makarov_Ivan_number_3;   
namespace HomeWork_Makarov_Ivan_number_3._1
{
	public sealed class OneDimensionalArray : BaseArray,IOneDimensionalArray
    {
        private int[] array;

        public OneDimensionalArray(bool personGet) : base(personGet)
        {
            
        }

        protected override void GetfromPerson()
        {
            Console.WriteLine("Введите длину массива: ");
            int inputArray = int.Parse(Console.ReadLine());
            array = new int[inputArray];
            Console.Write("Вводите значения массива: ");
            for (int i = 0; i < array.Length; i++)
            {
                int value = int.Parse(Console.ReadLine());
                array[i] = value;
            }
            
        }


        protected override void GetfromRandom()
        {
            Random random = new Random();
            int inputArray = random.Next(2, 10);
            array = new int[inputArray];
            for (int i = 0; i < array.Length; i++)
            {
                int value = random.Next(0, 10);
                array[i] = value;
            }
            
        }


        public override void Print()
        {
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");

            }
            Console.WriteLine();
        }
        


        public override decimal GetAverage()
        {
            decimal sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return  sum / array.Length;
        }
        public void DeliteElementsBigger100()
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 101 && array[i] > -101)
                {
                    count += 1;
                }
            }
            int[] new_array = new int[count];
            int count_1 = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] < 101 && array[j] > -101)
                {

                    new_array[count_1] = array[j];
                    count_1 += 1;
                }
            }
            array = new_array;
        }
        void IOneDimensionalArray.Delite_WhoRepeat()
        {

            int f = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool povtor = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        povtor = true;
                        break;
                    }
                }
                if (!povtor)
                {
                    f++;
                }
            }
            int[] arr_2_new = new int[f];
            int ind = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool povtor_2 = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        povtor_2 = true;
                        break;
                    }
                }
                if (povtor_2 == false)
                {
                    arr_2_new[ind] = array[i];
                    ind++;
                }

            }
            array = arr_2_new;



        }
    }
}

