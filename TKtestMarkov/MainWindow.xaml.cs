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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TKtestMarkov
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик кнопки "Вычислить"
        /// </summary>
        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Проверка ввода часов
                if (!double.TryParse(HoursTextBox.Text, out double hours) || hours < 0)
                {
                    MessageBox.Show("Введите корректное количество часов!");
                    return;
                }

                // Определение ставки
                double rate = GetRate();

                // Расчет зарплаты
                double salary = hours * rate;

                // Расчет налога
                double tax = 0;

                if (TaxCheckBox.IsChecked == true)
                {
                    tax = salary * 0.13;
                }

                // Вывод результатов
                SalaryText.Text = $"Начислено: {salary} руб";
                TaxText.Text = $"Налог: {tax} руб";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Метод определения ставки преподавателя
        /// </summary>
        private double GetRate()
        {
            if (AssistantRadio.IsChecked == true)
                return 150;

            if (DocentRadio.IsChecked == true)
                return 250;

            if (ProfessorRadio.IsChecked == true)
                return 350;

            throw new Exception("Выберите тип преподавателя!");
        }
    }
}