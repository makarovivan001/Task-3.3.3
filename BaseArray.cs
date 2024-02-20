using System;
namespace HomeWork_Makarov_Ivan_number_3._1
{
	public abstract class BaseArray : IBaseArray
	{
		protected BaseArray(bool personGet)
		{
			Create(personGet);
		}
		public void Create(bool personGet)
		{
			if (personGet)
			{
				GetfromPerson();
			}
			else
			{
				GetfromRandom();
			}
		}
		protected abstract void GetfromPerson();
        protected abstract void GetfromRandom();
		public abstract void Print();
        public abstract decimal GetAverage();


    }
}

