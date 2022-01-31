using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTO.Models
{
    public class DataManager
    {
        private MTOnewDataContext _datacontext;
        public DataManager()
        {
            _datacontext = new MTOnewDataContext();
        }
        private UserRepository _userrepository;
        public UserRepository User
        {
            get
            {
                if (_userrepository == null)
                    _userrepository = new UserRepository(_datacontext);
                return _userrepository;
            }
        }

        
    }
}