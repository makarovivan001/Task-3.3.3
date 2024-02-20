using System;
using HomeWork_Makarov_Ivan_number_3;
using HomeWork_Makarov_Ivan_number_3._1;

class program
{
    static bool personChoose()
    {
        bool personschoose = false;
        bool correct_or_incorrect_answer_is_incorrect = true;
        string input;
        while (correct_or_incorrect_answer_is_incorrect)
        {
            input = Console.ReadLine();
            if (input == "да")
            {
                personschoose = true;
                correct_or_incorrect_answer_is_incorrect = false;
            }
            else if (input == "нет")
            {
                personschoose = false;
                correct_or_incorrect_answer_is_incorrect = false;
            }
            else
            {
                Console.WriteLine("Ответ некорректен, ответьте по-другому");
            }
        }
        return personschoose;
    }
    static void Main(string[] args)
    {

        bool personGet;
        personGet = personChoose();
        
        Week week = new Week();
        IPrinter printer_4 = week;
        OneDimensionalArray oneDimensionalArray = new OneDimensionalArray(personGet);
        IBaseArray baseArray = oneDimensionalArray;
        IPrinter printer = oneDimensionalArray;
        TwoDimensionalArray twoDimensionalArray = new TwoDimensionalArray(personGet);
        IBaseArray baseArray_1 = twoDimensionalArray;
        IPrinter printer_1 = twoDimensionalArray;
        SteppedArray steppedArray = new SteppedArray(personGet);
        IBaseArray baseArray_2 = steppedArray;
        IPrinter printer_2 = steppedArray;
        IBaseArray[] arrays = new IBaseArray[3];
        Console.WriteLine("Вы введёте массив с клавиатуры?:  да/нет");
       
        arrays[0] = oneDimensionalArray;
        arrays[1] = twoDimensionalArray;
        arrays[2] = steppedArray;
        for (int i = 0; i < arrays.Length; i++)
        {
           
            Console.WriteLine("Напечатанный массив: ");
            arrays[i].Print();
            Console.WriteLine("Среднее значение элементов массива: ");
            Console.WriteLine(arrays[i].GetAverage());

        }
        IPrinter[] Printer = new IPrinter[4];
        Printer[0] = week;
        Printer[1] = oneDimensionalArray;
        Printer[2] = twoDimensionalArray;
        Printer[3] = steppedArray;
        for (int i = 0; i < Printer.Length; i++)
        {
            Printer[i].Print();

        }





        Console.ReadKey();

    }
}