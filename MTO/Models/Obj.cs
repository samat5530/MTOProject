using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTO.Models
{
    public class Obj
    {
        public List<Users> _param1;
        public List<StudentScores> _param2=new List<StudentScores>();
        public Obj(List<Users> param1, List<StudentScores> param2)
        {
            _param1 = param1;
            _param2 = param2;
        }
        public Obj()
        {
            _param1 = new List<Users>();
            _param2 = new List<StudentScores>();
        }
    }
}