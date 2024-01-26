using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using zakazclass.Model;

namespace zakazclass
{
    
    public class Zakaziclass
    {
        public string delete_zakaz(int id)
        {

        }
        public string Add_zakaz(string seria,string cost,int vid)
        {  
            Core db = new Core(); //Подключение к бд
            if (!string.IsNullOrWhiteSpace(seria) && !string.IsNullOrWhiteSpace(cost) && vid > 0)//Проверка на пустоту и пробел
            {
                if (cost.All(x => Char.IsDigit(x)))//Проверка что в цене только цифры
                {
                    if (cost.Length <= 6)//Проверка на размер цены
                    {
                        if(seria.Length <= 15)//Проверка на длину серии
                        {
                            if (vid <= 7)//Проверкка на вид
                            {
                                Zakazi zakazi = new Zakazi //Формирование данных для добавления
                                {
                                    seriya = seria,
                                    cost = Convert.ToInt32(cost),
                                    id_servise = vid
                                };
                                db.context.Zakazi.Add(zakazi);//Добавление в бд
                                if (1 < db.context.SaveChanges())//Проверка что данные сохранились
                                {
                                    return "Запись не добавлена";
                                }
                                else
                                {
                                    return "Запись добавлена";


                                }
                            }
                            else
                            {
                                return "Такого вида не существует";
                            }
                            
                        }
                        else
                        {
                            return "Слишком большая строка";
                        }
                        
                    }
                    else
                    {
                        return "Слишком большая сумма";
                    }
                   
                }
                else
                {
                    return  "Вы ввели буквы";
                }

            }
            else
            {
                return  "поле не заполнено";
            }


        }
    }
}
