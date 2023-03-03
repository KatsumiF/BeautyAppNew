using BeautyApp.Controllers;
using BeautyApp.Models;
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

namespace BeautyApp.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        public RegPage()
        {
            InitializeComponent();
        }

        private void NewCaptchaClick(object sender, RoutedEventArgs e)
        {

        }

        private void RegButtonClick(object sender, RoutedEventArgs e)
        {
            if (PasswordTextBox.Text != String.Empty && LoginTextBox.Text != String.Empty)
            {
                if (ReturnPasswordTextBox.Text == PasswordTextBox.Text)
                {
                    Users user = new Users()
                    {
                       //Idrole=
                        UserLogin = LoginTextBox.Text,
                        UserPassword = PasswordTextBox.Text
                    };
                    Clients cl = new Clients()
                    {
                        firstName = SurnameTextBox.Text,
                        lastName = NameTextBox.Text,
                        patronymic = PatronymicTextBox.Text,
                        genderCode = "1",
                        birthday = new DateTime(1970,03,21),//BirthdatePicker.SelectedDate.Value,
                        email = EmailTextBox.Text,
                        phone = PhoneTextBox.Text,
                        login = LoginTextBox.Text
                    };
                    if (UsersController.RegUser(user) && ClientsController.RegClient(cl))
                    {
                        MessageBox.Show("Вы успешно зарегистрировались!");
                        this.NavigationService.Navigate(new AuthPage());
                    }
                    else 
                    {
                        MessageBox.Show("Данные не добавлены");
                    }
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают!");
                }
            }
            else
            {
                MessageBox.Show("не заполнены поля!");
            }

        }
    }
}
