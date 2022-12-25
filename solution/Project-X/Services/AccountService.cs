using GTANetworkAPI;
using Shared.Dictionaries;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Project_X.Services
{
    public class AccountService
    {

        private static readonly ApplicationContext _database = Database.Instance;

        public static bool CreateAccount(Player player, string login, string email, string password)
        {
            if (Database.IsAccountExist(player.SocialClubName))
            {
                
                return false;
            }

            //TODO: Сделать хеширование пароля
            Account account = new Account()
            {
                Social = player.SocialClubName,
                Login = login,
                Email = email,
                Password = password,
                AdminTypes = Admin.AdminTypes.Player
            };

            _database.Accounts.Add(account);
            _database.SaveChanges();

            return true;
        }

        public static bool LoginAccount(string login, string password)
        {
            Account account = _database.Accounts.FirstOrDefault(account => account.Login == login);

            if (account == null)
                return false;

            if (account.Password != password)
                return false;

            return true;
        }
    }
}
