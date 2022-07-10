using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caalog.Model
{
    class TPhone
    {
		string company;
		string model;
		int ram;
		string color;
		int price;
		public TPhone(string company, string model, int ram, string color,int price)
		{

			this.company = company;
			this.model = model;
			this.ram = ram;
			this.color = color;
			this.price = price;
		}
		public int Price() { return price; }
		public string Company() { return company; }
		public string Color() { return color; }
		public string Model() { return model; }
		public int RAM() { return ram; }
		public string ShowPhone()
		{
			string s;
			s= $"Фирма: {company}\n";
			s+=$"Модель: {model}\n";
			s += $"ОЗУ: {ram}\n";
			s += $"Цвет: {color}\n";
			s += $"Цена: {price}\n";
			s += "\n";
			return s;
		}
	}
}
