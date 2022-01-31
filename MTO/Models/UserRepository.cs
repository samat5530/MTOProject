using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTO.Models
{
    public class UserRepository
    {

        private MTOnewDataContext _datacontext;
        public UserRepository(MTOnewDataContext datacontext)
        {
            _datacontext = datacontext;
        }

        public void CreateUser(string insertedFirstName, string insertedName, string insertedLastName, string insertedPassword)
        {
            Users user = new Users
            {
                FirstName = insertedFirstName,
                Name = insertedName,
                LastName = insertedLastName,
                Password = insertedPassword,
                TypeID = 2
            };
            _datacontext.Users.InsertOnSubmit(user);
            _datacontext.SubmitChanges();
        }
        public int[] LoginUser(string insertedFirstName, string insertedName, string insertedLastName, string insertedPassword)
        {
            int[] SessionStatus = { 0, 0, 0, 0 };
            var selectedUser = from user in _datacontext.Users
                               where user.FirstName == insertedFirstName
                               where user.Name == insertedName
                               where user.LastName == insertedLastName
                               select user;
            if (selectedUser != null) SessionStatus[0] = 1;
            foreach(var user in selectedUser)
            {
                if (user.Password == insertedPassword) SessionStatus[1] = 1;
                if (user.TypeID==1) SessionStatus[2] = 1;
                SessionStatus[3] = user.UserID;
            }

            return SessionStatus;
        }
    }
}