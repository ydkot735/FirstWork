using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caalog.Model
{
    class TCatalog
    {
        string nameCatalog;
        int numPhone;
        TPhone[] phones;
        TPhone[] smart;
        int day, month, year;
        string res;
        string p;
        public TCatalog(StreamReader sr, string path)
        {
            try
            {
                //String path = "D:\\listp.txt";
                // StreamReader sr = new StreamReader(path, System.Text.Encoding.Default);
                //StreamReader sr = OpenDlg.OpenFile()
                p = path;
                nameCatalog = sr.ReadLine();
                numPhone = int.Parse(sr.ReadLine());
                phones = new TPhone[numPhone];
                string company;
                string model;
                int ram;
                string color;
                int price;
                day = int.Parse(sr.ReadLine());
                month = int.Parse(sr.ReadLine());
                year = int.Parse(sr.ReadLine());
                DateTime date = new DateTime(year, month, day);
                for (int i = 0; i < phones.Length; i++)
                {
                    company = sr.ReadLine();
                    model = sr.ReadLine();
                    ram = int.Parse(sr.ReadLine());
                    color = sr.ReadLine();
                    price = int.Parse(sr.ReadLine());
                    phones[i] = new TPhone(company, model, ram, color, price);
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public string ShowCatalog()
        {
            res= $"Список телефонов: { nameCatalog}";
            res+= "\n";
            res += $"Дата формирования: {day}.{month}.{year}\n";
            res += "\n";
            int i;
            for (i = 0; i < phones.Length; i++)
            {
                res += $"#{i+1}\n";
                res +=phones[i].ShowPhone();
               
            }
            return res;
        }
        public string ShowMaxMin()
        {
            int min = phones[0].Price();
            int max = phones[phones.Length - 1].Price();
            int number1 = 0;
            int number2 = 0;
            string q = "";
            for (int i = 0; i < phones.Length; i++)
            {
                if (max < phones[i].Price()) { number1 = i; max = phones[i].Price(); }
                if (min > phones[i].Price()) { number2 = i; min = phones[i].Price(); }
                if (i == phones.Length - 1)
                {
                    q+="Самый дорогой телефон:\n";
                    q+=phones[number1].ShowPhone();
                    q+="Самый дешевый телефон:\n";
                    q+=phones[number2].ShowPhone();
                }
            }
            return q;
        }
        public string ShowMedprice()
        {
            res += "\nСредняя цена по компании\n";
            string comcheck = " ";
            StreamReader sr = new StreamReader(p, System.Text.Encoding.Default);
            int med = 0;
            int z=1;
            for (int q = 0; q < 35; q++)
            {
             sr.ReadLine();
             if (q == 34) { comcheck = sr.ReadLine(); }
            }
            res += $"Компания: {comcheck}";
            for (int i = 0; i < phones.Length; i++)
            {
                if (comcheck == phones[i].Company()) { med = med + phones[i].Price(); z++; }
            }
            z--;
            res += $"\nСумма: { med}\n";
            res += $"\nКоличество телефонов: { z}\n";
            med = med / z;
            res+= $"\nСредняя цена: { med}\n";
            return res;
            
        }
        public string ShowColorList()
        {
            string colcheck="";
            StreamReader sr = new StreamReader(p, System.Text.Encoding.Default);
            for (int q = 0; q < 37; q++)
            {
                sr.ReadLine();
                if (q == 35) { colcheck = sr.ReadLine(); }
            }
            res += $"\nСписок телефонов: {nameCatalog} по цвету {colcheck}\n";
            for (int i = 0; i < phones.Length; i++)
            {
                if (colcheck == phones[i].Color())
                {
                   res+= phones[i].ShowPhone();
                }
            }
            return res;
        }
        public string ShowRAMList()
        {
            smart = new TPhone[numPhone];
            for (int i = 0; i < phones.Length; i++)
            {
                for (int j = i + 1; j < phones.Length; j++)
                {
                    if (phones[i].RAM() > phones[j].RAM())
                    { (phones[i], phones[j]) = (phones[j], phones[i]); }
                }
                smart[i] = phones[i];
            }
            string a= "";
            for (int i = 0; i < phones.Length; i++)
            {
                a+=smart[i].ShowPhone();
            }
            a+="";
            return a;
        }
    }
}
