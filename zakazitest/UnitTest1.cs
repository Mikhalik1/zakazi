using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using zakazclass;
using zakazitest.Models;

namespace zakazitest
{
    [TestClass]
    public class UnitTest1
    {
        Core db = new Core();
        [TestMethod]
        public void TestMethod1()//Тест на успешное добавление
        {
            string seria = "1234ab11";
            string cost = "123123";
            int vid = 2;
            string prover = "Запись добавлена";
            Zakaziclass zakcl = new Zakaziclass();

            string resulit = zakcl.Add_zakaz(seria, cost, vid);//обращение к методу

            Assert.AreEqual(resulit,prover);//Метод проверки
        }
        [TestMethod]
        public void TestMethod_AllBukva_False()//Тест на буквы в цене
        {
            string seria = "1234ab11";
            string cost = "cisnqd";
            int vid = 2;
            string prover = "Вы ввели буквы";
            Zakaziclass zakcl = new Zakaziclass();

            string resulit = zakcl.Add_zakaz(seria, cost, vid);//обращение к методу

            Assert.AreEqual(resulit, prover);//Метод проверки
        }
        [TestMethod]
        public void TestMethod_Space_False()//Тест на пробел
        {
            string seria = " ";
            string cost = "2202";
            int vid = 2;
            string prover = "поле не заполнено";
            Zakaziclass zakcl = new Zakaziclass();

            string resulit = zakcl.Add_zakaz(seria, cost, vid);//обращение к методу

            Assert.AreEqual(resulit, prover);//Метод проверки
        }

        [TestMethod]
        public void TestMethod_empty_False()//Тест на пустоту
        {
            string seria = "";
            string cost = "2202";
            int vid = 2;
            string prover = "поле не заполнено";
            Zakaziclass zakcl = new Zakaziclass();

            string resulit = zakcl.Add_zakaz(seria, cost, vid);//обращение к методу

            Assert.AreEqual(resulit, prover);//Метод проверки
        }

        [TestMethod]
        public void TestMethod_many_False()//Тест на много цифр
        {
            string seria = "String";
            string cost = "22025555";
            int vid = 1;
            string prover = "Слишком большая сумма";
            Zakaziclass zakcl = new Zakaziclass();

            string resulit = zakcl.Add_zakaz(seria, cost, vid);//обращение к методу

            Assert.AreEqual(resulit, prover);//Метод проверки
        }

        [TestMethod]
        public void TestMethod_manybukv_False()//Тест на много букв в серии
        {
            string seria = "Stringwefsefesfsefsfesfsefesffsf";
            string cost = "2202";
            int vid = 1;
            string prover = "Слишком большая строка";
            Zakaziclass zakcl = new Zakaziclass();

            string resulit = zakcl.Add_zakaz(seria, cost, vid);//обращение к методу

            Assert.AreEqual(resulit, prover);//Метод проверки
        }

        [TestMethod]
        public void TestMethod_NotVid_False()//Тест на неправильный вид
        {
            string seria = "String";
            string cost = "2202";
            int vid = 8;
            string prover = "Такого вида не существует";
            Zakaziclass zakcl = new Zakaziclass();

            string resulit = zakcl.Add_zakaz(seria, cost, vid);//обращение к методу

            Assert.AreEqual(resulit, prover);//Метод проверки
        }




    }
}
