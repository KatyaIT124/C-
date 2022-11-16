using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    internal class User
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        private string Phone { get; set; }
        private string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public User(string login, string password)
        {
            Login = login ?? throw new ArgumentNullException(nameof(login));
            Password = password ?? throw new ArgumentNullException(nameof(password));
        }
        public void LoginUser()
        {
            string[,,] LoginUsers = { { { "Катерина", "1234567", "Admin" }, { "Микита", "4567891", "User" }, { "Аліса", "9876543", "User" } } };
            
            for (int i = 0; i < LoginUsers.GetLength(0); i++)
            {
                for (int k = 0; k < LoginUsers.GetLength(1); k++)
                {
                    if (LoginUsers[i, k, 0] == Login && LoginUsers[i, k, 1] == Password)
                    {
                        if (LoginUsers[i, k, 2] == "Admin")
                        {
                            MessageBox.Show("Ласкаво просимо, " + Login + "! " + "Ви є адміном.");
                        }
                        if (LoginUsers[i, k, 2] == "User")
                        {
                            MessageBox.Show("Ласкаво просимо, " + Login + "! " + "Ви є користувачем.");
                        }
                    }
                   
                }                  
                
            }
            

        }
    }
}
