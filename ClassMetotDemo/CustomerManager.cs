using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
	class CustomerManager
	{
		public Customer Add(Customer customer)
		{
			Console.WriteLine("Eklemek İstediğiniz müşteri adını giriniz");
			customer.Name = Console.ReadLine();
			Console.WriteLine(customer.Name + "İsimli müşteri eklendi.");
			return customer;
		}

		public Customer Delete(Customer customer)
		{
			Console.WriteLine("Silmek İstediğiniz müşteri Adını giriniz");
			customer.Name = Console.ReadLine();
			Console.WriteLine(customer.Name + "İsimli müşteri silindi.");
			return customer;
		}
	}
}
