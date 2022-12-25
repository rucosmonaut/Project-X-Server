using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_X
{
    class Database
    {
        private static ApplicationContext _instance;

        public static ApplicationContext Instance
        {
            get
            {
                if (_instance == null)
                {
                    try
                    {
                        _instance = new ApplicationContext();
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine($"Ошибка соединения с базой данных. Exception: {e}");
                    }
                }

                return _instance;
            }
            set { }
        }

        public static bool IsAccountExist (string social)
        {
            Account account = Instance.Accounts.FirstOrDefault(account => account.Social == social);
            if(account == null)
            {
                return false;
            }

            return true;
        }
    }
}
