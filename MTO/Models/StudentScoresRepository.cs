using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTO.Models
{
    public class StudentScoresRepository
    {
        private MTOnewDataContext _datacontext;
        public StudentScoresRepository(MTOnewDataContext datacontext)
        {
            _datacontext = datacontext;
        }
        public Obj GetStudentsScore()
        {
            List<Users> users = new List<Users>();
            List<StudentScores> scores = new List<StudentScores>();
            Obj temp = new Obj(users,scores);
            foreach (Users user in _datacontext.Users)
                users.Add(user);
            temp._param1 = users;
            foreach (StudentScores score in _datacontext.StudentScores)
                scores.Add(score);
            temp._param2 = scores;
            return temp;
        }
    }
}