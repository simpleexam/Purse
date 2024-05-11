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

namespace Purse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //TODO добавить другие объекты реализующие этот интерфейс------------------
       
        Person person;  
        public MainWindow() //конструктор окна
        {
            InitializeComponent();
            person = new Person //инициализируется объект человека
            {
                Name = "Петров И.С.",
                Summ = 0
            };
            this.Title = person.Name; //меняется заголовок окна на имя объекта person
            summLabel.Content = person.Summ;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            double inputSumm = Double.Parse(inputMoney.Text);
            person.AddMoney(inputSumm);
            summLabel.Content = person.Summ;
        }

        private void decButton_Click(object sender, RoutedEventArgs e)
        {
            double inputSumm = Double.Parse(inputMoney.Text);
            person.DecMoney(inputSumm);
            summLabel.Content =  person.Summ;
        }
    }
}
