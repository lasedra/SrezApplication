using Microsoft.EntityFrameworkCore;
using SrezApp.Models;
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

namespace SrezApp
{
    /// <summary>
    /// Interaction logic for AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User newUser = SrezdbContext.db.USER.FirstOrDefault(c => LoginTextBox.Text == c.LOGIN && PasswordTextBox.Text == c.PASSWORD);
            if (newUser != null) { MessageBox.Show("Авторизация пройдена"); }
            else MessageBox.Show("Авторизация не пройдена");
        }
    }
}
