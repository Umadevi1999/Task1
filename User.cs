using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class User
    {
        private string username;
        private string password;
        private string mailId;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string MailId { get => mailId; set => mailId = value; }

        public User()
        {

        }

        public User(string username, string password, string mailId)
        {
            this.username = username;
            this.password = password;
            this.mailId = mailId;
        }

        public override string ToString()
        {
            return String.Format("username:{0}\nmailId:{1}\n Password:{2}", Username, MailId, Password);
         }
    public override bool Equals(object obj)
        {
            User obj_user = (User)obj;
            return this.Username.Equals(obj_user.Username);
        }
    public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        }

    }



