using System;
namespace HomeWork_Makarov_Ivan_number_3._1
{
	class Week : IPrinter
	{
		void IPrinter.Print()
		{
			Console.WriteLine("Понедельник " + "вторник " + "среда "+"четверг "+"пятница "+"суббота "+"воскресенье ");
		}
		
	}
}

