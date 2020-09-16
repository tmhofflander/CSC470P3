using System;
using System.Collections.Generic;
using System.Text;

namespace CSC470_P3
{
    public class FakeAppUserRepository : IAppUserRepository
    {

        private static Dictionary<string, AppUser> AppUsers;

        public FakeAppUserRepository()
        {
            if (AppUsers == null)
            {

                AppUsers = new Dictionary<string, AppUser>();
                AppUsers.Add("Bbishop", new AppUser {

                    UserName = "Bbishop",
                    Password = "Password",
                    FirstName = "Barb",
                    LastName = "Bishop",
                    EmailAddress = "Barb.Bishop@gmail.com",
                    IsAuthenticated = false
                });
                AppUsers.Add("Dbishop", new AppUser
                {

                    UserName = "Dbishop",
                    Password = "P@ssword",
                    FirstName = "Dave",
                    LastName = "Bishop",
                    EmailAddress = "Dave.Bishop@gmail.com",
                    IsAuthenticated = false
                });

            }

        }

        public bool Login(string UserName,string Password)
        {
            if (AppUsers.ContainsKey(UserName))
            {
                AppUser user;
                bool ignore = AppUsers.TryGetValue(UserName, out user);
                if (user.Password == Password)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        public List<AppUser> GetAll()
        {
            List<AppUser> list = new List<AppUser>();
            foreach(KeyValuePair<string, AppUser> user in AppUsers)
            {
                list.Add(user.Value);
            }
            return list;
        }
        public void SetAuthentication(string UserName, bool IsAuthenticated)
        {
            AppUser user;
            bool ignore = AppUsers.TryGetValue(UserName, out user);
            user.IsAuthenticated = IsAuthenticated;
        }
        public AppUser GetByUserName(string UserName)
        {
            AppUser user;
            bool ignore = AppUsers.TryGetValue(UserName, out user);
            return user;
        }

    }
}
