using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ПрактическаяРабота_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RBEasternHoroscope_Checked(object sender, RoutedEventArgs e)
        {
            SPZodiacSignal.Visibility = Visibility.Collapsed;
            BtnClear_Click(sender, e);
            SPEasternHoroscope.Visibility = Visibility.Visible;
            SPButton.Visibility = Visibility.Visible;
        }

        private void RBZodiac_Checked(object sender, RoutedEventArgs e)
        {
            SPEasternHoroscope.Visibility = Visibility.Collapsed;
            BtnClear_Click(sender, e);
            SPZodiacSignal.Visibility = Visibility.Visible;
            SPButton.Visibility = Visibility.Visible;
        }

        public static bool GetProverkaDay(int day, string month, ref string error) // Проверка корректности дня и месяца
        {
            if (month != "Январь" && month != "Февраль" && month != "Март" && month != "Апрель" && month != "Май" && month != "Июнь" && month != "Июль" && month != "Август" && month != "Сентябрь" && month != "Октябрь" && month != "Ноябрь" && month != "Декабрь")
            {
                return true;
            }
            if (month == "Январь" && day > 31)
            {
                error = "В январе нет " + day + " числа!";
                return true;
            }
            if (month == "Февраль" && day > 29)
            {
                error = "В феврале нет " + day + " числа!";
                return true;
            }
            if (month == "Март" && day > 31)
            {
                error = "В марте нет " + day + " числа!";
                return true;
            }
            if (month == "Апрель" && day > 30)
            {
                error = "В апреле нет " + day + " числа!";
                return true;
            }
            if (month == "Май" && day > 31)
            {
                error = "В мае нет " + day + " числа!";
                return true;
            }
            if (month == "Июнь" && day > 31)
            {
                error = "В июне нет " + day + " числа!";
                return true;
            }
            if (month == "Июль" && day > 31)
            {
                error = "В июле нет " + day + " числа!";
                return true;
            }
            if (month == "Август" && day > 31)
            {
                error = "В августе нет " + day + " числа!";
                return true;
            }
            if (month == "Сентябрь" && day > 31)
            {
                error = "В сентябре нет " + day + " числа!";
                return true;
            }
            if (month == "Август" && day > 31)
            {
                error = "В августе нет " + day + " числа!";
                return true;
            }
            if (month == "Сентябрь" && day > 30)
            {
                error = "В сентябре нет " + day + " числа!";
                return true;
            }
            if (month == "Октябрь" && day > 31)
            {
                error = "В октябре нет " + day + " числа!";
                return true;
            }
            if (month == "Ноябрь" && day > 30)
            {
                error = "В ноябре нет " + day + " числа!";
                return true;
            }
            if (month == "Декабрь" && day > 31)
            {
                error = "В декабре нет " + day + " числа!";
                return true;
            }
            if (day <= 0)
            {
                error = "Число не может быть нулевым!";
                return true;
            }
            return false;
        }

        public static string GetZodiazcSingl(int day, string month) // Определение знака зодиака по дню и месяцу
        {
            string ZodiacSingl = "";
            if ((day >= 21 && month == "Март") || (day <= 20 && month == "Апрель"))
            {
                ZodiacSingl = "Овен";
            }
            else if ((day >= 21 && month == "Апрель") || (day <= 20 && month == "Май"))
            {
                ZodiacSingl = "Телец";
            }
            else if ((day >= 21 && month == "Май") || (day <= 21 && month == "Июнь"))
            {
                ZodiacSingl = "Близнецы";
            }
            else if ((day >= 22 && month == "Июнь") || (day <= 22 && month == "Июль"))
            {
                ZodiacSingl = "Рак";
            }
            else if ((day >= 23 && month == "Июль") || (day <= 22 && month == "Август"))
            {
                ZodiacSingl = "Лев";
            }
            else if ((day >= 23 && month == "Август") || (day <= 23 && month == "Сентябрь"))
            {
                ZodiacSingl = "Дева";
            }
            else if ((day >= 24 && month == "Сентябрь") || (day <= 23 && month == "Октябрь"))
            {
                ZodiacSingl = "Веса";
            }
            else if ((day >= 24 && month == "Октябрь") || (day <= 22 && month == "Ноябрь"))
            {
                ZodiacSingl = "Скорпион";
            }
            else if ((day >= 23 && month == "Ноябрь") || (day <= 21 && month == "Декабрь"))
            {
                ZodiacSingl = "Стрелец";
            }
            else if ((day >= 22 && month == "Декабрь") || (day <= 20 && month == "Январь"))
            {
                ZodiacSingl = "Козерог";
            }
            else if ((day >= 21 && month == "Январь") || (day <= 18 && month == "Февраль"))
            {
                ZodiacSingl = "Водолей";
            }
            else if ((day >= 19 && month == "Февраль") || (day <= 20 && month == "Март"))
            {
                ZodiacSingl = "Рыбы";
            }
            return ZodiacSingl;
        }

        public static string GetSignEasternHoroscope(int Year) // Определение знака зодиака по восточному календарю
        {
            string Horoscope = "";
            Year = Year % 12;
            if (Year == 0)
            {
                Horoscope = "Обезьяна";
            }
            else if (Year == 1)
            {
                Horoscope = "Петух";
            }
            else if (Year == 2)
            {
                Horoscope = "Собака";
            }
            else if (Year == 3)
            {
                Horoscope = "Кабан";
            }
            else if (Year == 4)
            {
                Horoscope = "Крыса";
            }
            else if (Year == 5)
            {
                Horoscope = "Бык";
            }
            else if (Year == 6)
            {
                Horoscope = "Тигр";
            }
            else if (Year == 7)
            {
                Horoscope = "Кролик";
            }
            else if (Year == 8)
            {
                Horoscope = "Дракон";
            }
            else if (Year == 9)
            {
                Horoscope = "Змея";
            }
            else if (Year == 10)
            {
                Horoscope = "Лошадь";
            }
            else if (Year == 11)
            {
                Horoscope = "Овца";
            }
            return Horoscope;
        }
        private void BtnResult_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (RBZodiac.IsChecked == true) // Если установлена галочка на "Знак зодиака"
                {
                    if (TBDay.Text == "" || TBMonth.Text == "")
                    {
                        MessageBox.Show("Все поля должны быть заполнены!");
                        return;
                    }
                    string error = ""; // Строка ошибок
                    if (GetProverkaDay(Convert.ToInt32(TBDay.Text), TBMonth.Text, ref error) == true) // Проверка наличия некоректных данных
                    {
                        MessageBox.Show(error);
                        return;
                    }
                    TBHeaderResult.Visibility = Visibility.Visible;
                    TBlResult.Text = "Ваш знак зодиака => " + GetZodiazcSingl(Convert.ToInt32(TBDay.Text), TBMonth.Text);
                }
                else if (RBEasternHoroscope.IsChecked == true) // Если установлена галочка на "Знак зодиака по восточному гороскопу"
                {
                    string Horoscope = GetSignEasternHoroscope(Convert.ToInt32(TBYear.Text));
                    TBHeaderResult.Visibility = Visibility.Visible;
                    TBlResult.Text = "Знак по восточному гороскопу => " + Horoscope;
                }
            }
            catch
            {
                MessageBox.Show("Проверьте корректность введенных данных");
            }
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (RBZodiac.IsChecked == true)
                {
                    TBDay.Text = "";
                    TBMonth.Text = "";
                }
                else
                {
                    TBYear.Text = "";
                }
                TBHeaderResult.Visibility = Visibility.Collapsed;
                TBlResult.Text = "Здесь будет результат";
            }
            catch
            {
                MessageBox.Show("Проверьте корректность введенных данных");
            }
        }

        private void TBYear_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void BtnManuallyData_Click(object sender, RoutedEventArgs e)
        {
            SPMenu.Visibility = Visibility.Collapsed;
            SPVhodDataManually.Visibility = Visibility.Visible;
            SPButtonSolution.Visibility = Visibility.Visible;
        }

        private void TBHeader_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            SPVhodDataManually.Visibility = Visibility.Collapsed;
            SPButtonSolution.Visibility = Visibility.Collapsed;
            SPButton.Visibility = Visibility.Collapsed;
            SPEasternHoroscope.Visibility = Visibility.Collapsed;
            SPZodiacSignal.Visibility = Visibility.Collapsed;
            SPMenu.Visibility = Visibility.Visible;
            RBZodiac.IsChecked = false;
            RBEasternHoroscope.IsChecked = false;
        }

        private void BtnCSVData_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show("Выберите .csv файл где хранятся входные данные");
                WorkCSV.GetNameFileOpen(); // Взятие ссылки на файл .csv
                if (WorkCSV.startPath == null) // Проверка если ссылка не выбрана
                {
                    return;
                }
                List<Data> data = new List<Data>();
                WorkCSV.GetData(data); // Считывание данных из файла
                MessageBox.Show("Данные обработаны! Теперь выберите файл для сохранения результа");
                WorkCSV.GetNameFileSave(); // Взятие ссылки на файл .csv куда будет выведен результат
                if (WorkCSV.endPath == null) // Проверка если ссылка не выбрана
                {
                    return;
                }
                WorkCSV.inputData(data); // Вывод данных в файл
                MessageBox.Show("Данные успешно сохранены в файл " + WorkCSV.endPath);
            }
            catch
            {
                MessageBox.Show("При обработке данных возникла ошибка!");
            }
        }
    }
}
