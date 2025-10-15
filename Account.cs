using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM1
{
    internal class Account
    {
        public string AccountID;
        public string Username;
        public string PasswordHash;
        public string Email;
        public DateTime RegistrationDate;
        public DateTime LastLogin;

        public override string ToString()
        {
            return $"AccountID: {AccountID} Username: {Username}  Email: {Email}  PasswordHash: " +
                $"{PasswordHash}  RegistrationDate:{RegistrationDate.ToString("yyyy-MM-dd")}  LastLogin: {LastLogin.ToString("yyyy-MM-dd")}";
        }

    }
}
