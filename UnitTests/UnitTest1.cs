using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ПрактическаяРабота_5;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        // Тест на проверку метода получения из номера месяца его названия (на корректный результат)
        [TestMethod]
        public void GetMonthByNumber_5_return_May()
        {
            int a = 5;
            string except = "Май";
            string actual = WorkCSV.GetMonthByNumber(a);
            Assert.AreEqual(except, actual);
        }
        // Тест на проверку метода получения из номера месяца его названия (на не корректный результат)
        [TestMethod]
        public void GetMonthByNumber_1_return_December()
        {
            int a = 5;
            string except = "Декабрь";
            string actual = WorkCSV.GetMonthByNumber(a);
            Assert.AreNotEqual(except, actual);
        }
        // Тест для проверки метода определяющий корректность дня и месяца (на false)
        [TestMethod]
        public void GetProverkaDay_29_November_return_false()
        {
            int a = 29;
            string b = "Ноябрь";
            string c = "";
            bool except = false;
            bool actual = MainWindow.GetProverkaDay(a, b, ref c);
            Assert.AreEqual(except, actual);
        }
        // Тест для проверки метода определяющий корректность дня и месяца (на true)
        [TestMethod]
        public void GetProverkaDay_30_February_return_true()
        {
            int a = 30;
            string b = "Февраль";
            string c = "";
            bool except = true;
            bool actual = MainWindow.GetProverkaDay(a, b, ref c);
            Assert.AreEqual(except, actual);
        }
        // Тест для проверки метода определяющий корректность дня и месяца (на некорректный результат)
        [TestMethod]
        public void GetProverkaDay_35_September_return_false()
        {
            int a = 35;
            string b = "Сентябрь";
            string c = "";
            bool except = false;
            bool actual = MainWindow.GetProverkaDay(a, b, ref c);
            Assert.AreNotEqual(except, actual);
        }
        // Тест для проверки метода определяющий знак зодиака по дню и месяцу (на корректный результат)
        [TestMethod]
        public void GetZodiazcSingl_20_November_return_Scorpion()
        {
            int a = 20;
            string b = "Ноябрь";
            string except = "Скорпион";
            string actual = MainWindow.GetZodiazcSingl(a, b);
            Assert.AreEqual(except, actual);
        }

        // Тест для проверки метода определяющий знак зодиака по дню и месяцу (на корректный результат, проверка граничного значения)
        [TestMethod]
        public void GetZodiazcSingl_20_January_return_Kozerog()
        {
            int a = 20;
            string b = "Январь";
            string except = "Козерог";
            string actual = MainWindow.GetZodiazcSingl(a, b);
            Assert.AreEqual(except, actual);
        }
        // Тест для проверки метода определяющий знак зодиака по дню и месяцу (на не корректный результат)
        [TestMethod]
        public void GetZodiazcSingl_15_March_return_Strelec()
        {
            int a = 15;
            string b = "Марта";
            string except = "Стрелец";
            string actual = MainWindow.GetZodiazcSingl(a, b);
            Assert.AreNotEqual(except, actual);
        }

        // Тест для проверки метода определяющий знак зодиака восточному календарю (на корректный результат)
        [TestMethod]
        public void GetSignEasternHoroscope_2003_return_Ovca()
        {
            int a = 2003;
            string except = "Овца";
            string actual = MainWindow.GetSignEasternHoroscope(a);
            Assert.AreEqual(except, actual);
        }
        // Тест для проверки метода определяющий знак зодиака восточному календарю (на не корректный результат)
        [TestMethod]
        public void GetSignEasternHoroscope_2014_return_Krolic()
        {
            int a = 2014;
            string except = "Кролик";
            string actual = MainWindow.GetSignEasternHoroscope(a);
            Assert.AreNotEqual(except, actual);
        }
    }
}
