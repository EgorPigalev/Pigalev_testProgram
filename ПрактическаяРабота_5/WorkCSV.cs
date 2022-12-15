using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ПрактическаяРабота_5
{
    public struct Data
    {
        public string day;
        public string month;
        public string year;
        public string zodiacSign; // Знак зодиака по дню и месяцу
        public string signEasternHoroscope; // Знак зодиака по восточному гороскопу

        public string concat()
        {
            return day + ";" + month + ";" + year + ";" + zodiacSign + ";" + signEasternHoroscope;
        }
    }
    public class WorkCSV
    {
        public static string startPath; // Ссылка на .csv файл где хранятся входные данные
        public static string endPath; // Ссылка на .csv файл для вывода результата

        public static void GetNameFileOpen() // Выбор .csv файла где хранятся входные данные
        {
            while (true)
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.DefaultExt = ".csv";
                openFile.Filter = "File (.csv)|*.csv";
                if (openFile.ShowDialog() == true)
                {
                    startPath = openFile.FileName;
                    break;
                }
                else
                {
                    return;
                }
            }
        }

        public static void GetNameFileSave() // Выбор .csv файла где будет храниться результат
        {
            while (true)
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.DefaultExt = ".csv";
                saveFile.Filter = "File (.csv)|*.csv";
                if (saveFile.ShowDialog() == true)
                {
                    endPath = saveFile.FileName;
                    break;
                }
                else
                {
                    return;
                }
            }
        }

        public static string GetMonthByNumber(int number) // Получение из номера месяца его названия (чтобы воспользоваться методами из MainWindows)
        {
            string month = "";
            switch (number)
            {
                case 1:
                    month = "Январь";
                    break;
                case 2:
                    month = "Февраль";
                    break;
                case 3:
                    month = "Март";
                    break;
                case 4:
                    month = "Апрель";
                    break;
                case 5:
                    month = "Май";
                    break;
                case 6:
                    month = "Июнь";
                    break;
                case 7:
                    month = "Июль";
                    break;
                case 8:
                    month = "Август";
                    break;
                case 9:
                    month = "Сентябрь";
                    break;
                case 10:
                    month = "Октябрь";
                    break;
                case 11:
                    month = "Ноябрь";
                    break;
                case 12:
                    month = "Декабрь";
                    break;
            }
            return month;
        }

        public static void GetData(List<Data> L) // Считывание данных из csv файла с определение знака зодиака
        {
            using (StreamReader sr = new StreamReader(startPath))
            {
                int i = 0;
                while (sr.EndOfStream != true)
                {
                    string[] array = sr.ReadLine().Split(';');
                    if (i != 0) // Пропускаем первую строку с названием столбцов
                    {
                        string zodiacSign; // Переменная для хранения результата обработки на проверку знака зодиака
                        try
                        {
                            if (array[0] != "" && array[1] != "")
                            {
                                string error = "";
                                if (MainWindow.GetProverkaDay(Convert.ToInt32(array[0]), GetMonthByNumber(Convert.ToInt32(array[1])), ref error) == true)
                                {
                                    zodiacSign = "Входные данные некоректны";
                                }
                                else
                                {
                                    zodiacSign = MainWindow.GetZodiazcSingl(Convert.ToInt32(array[0]), GetMonthByNumber(Convert.ToInt32(array[1])));
                                }
                            }
                            else
                            {
                                zodiacSign = "Входные данные некоректны";
                            }
                        }
                        catch
                        {
                            zodiacSign = "Входные данные некоректны";
                        }
                        string signEasternHoroscope; // Переменная для хранения результата обработки на проверку знака зодиака по восточному гороскопу
                        try
                        {
                            signEasternHoroscope = MainWindow.GetSignEasternHoroscope(Convert.ToInt32(array[2]));
                        }
                        catch
                        {
                            signEasternHoroscope = "Входные данные некоректны";
                        }
                        L.Add(new Data()
                        {
                            day = array[0],
                            month = array[1],
                            year = array[2],
                            zodiacSign = zodiacSign,
                            signEasternHoroscope = signEasternHoroscope
                        });
                    }
                    i++;
                }
            }
        }

        public static void inputData(List<Data> L) // Метод для вывода данных в csv файл
        {
            using (StreamWriter sw = new StreamWriter(endPath, true))
            {
                sw.WriteLine("День;Месяц;Год;Знак зодиака;Знак зодиака по восточному гороскопу");
                foreach (Data u in L)
                {
                    sw.WriteLine(u.concat());
                }
            }
        }
    }
}
