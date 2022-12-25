using System;
using System.Collections.Generic;
using System.Text;
using Shared.Dictionaries;

namespace Shared.Models
{
    public class Account
    {
        public int AccountId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Social { get; set; }
        public string PhoneNumber { get; set; }
        //public List<Character> Сharacters { get; set; }
        public Admin.AdminTypes AdminTypes { get; set; }

    }
}
