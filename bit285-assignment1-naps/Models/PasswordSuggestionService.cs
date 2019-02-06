using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A1_Mod
{
    public class PasswordSuggestionService
    {
        public string GeneratePassword(UserModel user)
        {
            string stringPasswordchar = user.LastName + user.BirthYear + user.FavColor;
            string stringPassword = "";
            Random rnd = new Random();

            for (int i = 0; i <= 8; i++)
            {
                int iRandom = rnd.Next(0, stringPasswordchar.Length);
                stringPassword += stringPasswordchar.Substring(iRandom, 1);
            }


            return stringPassword;
        }   
        
    }
}
