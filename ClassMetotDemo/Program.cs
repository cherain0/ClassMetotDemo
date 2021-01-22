using System;

namespace ClassMetotDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Customer customer1 = new Customer();
			customer1.Id = "123456789";
			customer1.Name = "Ahmet";
			customer1.Surname = "Kelle";
			customer1.Age = 32;

			Customer customer2 = new Customer();
			customer2.Id = "258639147";
			customer2.Name = "Yonca";
			customer2.Surname = "Sergin";
			customer2.Age = 36;

			Customer customer3 = new Customer 
			{Id = "246824680", Name = "Hasan", 
			Surname = "Dede", Age = 65 };

			Customer[] customers = new Customer[] { customer1, customer2, customer3 };

			Console.WriteLine("-----Müşteriler----------");

			foreach (Customer custom in customers)
			{
				Console.WriteLine(custom.Name + " " + custom.Surname + " &&  " + custom.Age );
			}

			CustomerManager customerManager = new CustomerManager();
			Console.WriteLine("------Yeni müşteri ver-------");
			customerManager.Add(new Customer());

			Console.WriteLine("---------Müşteriyi silin------");
			customerManager.Delete(new Customer());

		}
	}
}
