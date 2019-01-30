using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A1_Mod
{
    public class Repository
{
        private List<UserModel> users = new List<UserModel>();

        public IEnumerable<UserModel> UserEntry
        {
            get
            {
                return users;
            }
        }
        public void AddUser (UserModel NewUser)
        {
            users.Add(NewUser);
        }
}
}
