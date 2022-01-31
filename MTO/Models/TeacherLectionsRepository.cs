using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTO.Models
{
    public class TeacherLectionsRepository
    {
        private MTOnewDataContext _datacontext;
        public TeacherLectionsRepository(MTOnewDataContext datacontext)
        {
            _datacontext = datacontext;
        }
        public void AddNewLection(string newTitle,
            string newPart1Title, string newPart1,
            string newPart2Title, string newPart2,
            string newPart3Title, string newPart3,
            string newImage, string newVideo, string newAnim, string newAudio,
            bool newHidden)
        {
            TeacherLections lection = new TeacherLections
            {
                TheoryName = newTitle,
                Part1Name = newPart1Title,
                Part1 = newPart1,
                Part2Name = newPart2Title,
                Part2 = newPart2,
                Part3Name = newPart3Title,
                Part3 = newPart3,
                Image = newImage,
                Video = newVideo,
                Animation = newAnim,
                Audio = newAudio,
                Hidden = newHidden
            };
            _datacontext.TeacherLections.InsertOnSubmit(lection);
            _datacontext.SubmitChanges();
        }
        public string[] GetLections(int id)
        {
            string[] lection = new string[12];
            var selectedLection = from lect in _datacontext.TeacherLections
                                  where lect.UserID == id
                                  select lect;
            foreach (var lect in selectedLection)
            {
                lect.TheoryName = lection[0];
                lect.Part1Name = lection[1];
                lect.Part1 = lection[2];
                lect.Part2Name = lection[3];
                lect.Part2 = lection[4];
                lect.Part3Name = lection[5];
                lect.Part3 = lection[6];
                lect.Image = lection[7];
                lect.Video = lection[8];
                lect.Animation = lection[9];
                lect.Audio = lection[10];
                if (lect.Hidden == true) lection[11] = "true";
                else lection[11] = "false";
            }
            return lection;
        }
        public void EditTheoryName(string temp)
        {
            var lection = from lect in _datacontext.TeacherLections
                          where lect.TheoryName == temp
                          select lect;
            foreach (var lect in lection)
                lect.TheoryName = temp;
            _datacontext.SubmitChanges();
        }
        public void EditPart1Name(string LectName, string Data)
        {
            var lection = from lect in _datacontext.TeacherLections
                          where lect.TheoryName == LectName
                          select lect;
            foreach (var lect in lection)
                lect.Part1Name = Data;
            _datacontext.SubmitChanges();
        }
        public void EditPart1(string LectName, string Data)
        {
            var lection = from lect in _datacontext.TeacherLections
                          where lect.TheoryName == LectName
                          select lect;
            foreach (var lect in lection)
                lect.Part1 = Data;
            _datacontext.SubmitChanges();
        }
        public void EditPart2Name(string LectName, string Data)
        {
            var lection = from lect in _datacontext.TeacherLections
                          where lect.TheoryName == LectName
                          select lect;
            foreach (var lect in lection)
                lect.Part2Name = Data;
            _datacontext.SubmitChanges();
        }
        public void EditPart2(string LectName, string Data)
        {
            var lection = from lect in _datacontext.TeacherLections
                          where lect.TheoryName == LectName
                          select lect;
            foreach (var lect in lection)
                lect.Part2 = Data;
            _datacontext.SubmitChanges();
        }
        public void EditPart3Name(string LectName, string Data)
        {
            var lection = from lect in _datacontext.TeacherLections
                          where lect.TheoryName == LectName
                          select lect;
            foreach (var lect in lection)
                lect.Part3Name = Data;
            _datacontext.SubmitChanges();
        }
        public void EditPart3(string LectName, string Data)
        {
            var lection = from lect in _datacontext.TeacherLections
                          where lect.TheoryName == LectName
                          select lect;
            foreach (var lect in lection)
                lect.Part3 = Data;
            _datacontext.SubmitChanges();
        }
        public void EditImage(string LectName, string Data)
        {
            var lection = from lect in _datacontext.TeacherLections
                          where lect.TheoryName == LectName
                          select lect;
            foreach (var lect in lection)
                lect.Image = Data;
            _datacontext.SubmitChanges();
        }
        public void EditVideo(string LectName, string Data)
        {
            var lection = from lect in _datacontext.TeacherLections
                          where lect.TheoryName == LectName
                          select lect;
            foreach (var lect in lection)
                lect.Video = Data;
            _datacontext.SubmitChanges();
        }
        public void EditAnimation(string LectName, string Data)
        {
            var lection = from lect in _datacontext.TeacherLections
                          where lect.TheoryName == LectName
                          select lect;
            foreach (var lect in lection)
                lect.Animation = Data;
            _datacontext.SubmitChanges();
        }
        public void EditAudio(string LectName, string Data)
        {
            var lection = from lect in _datacontext.TeacherLections
                          where lect.TheoryName == LectName
                          select lect;
            foreach (var lect in lection)
                lect.Audio = Data;
            _datacontext.SubmitChanges();
        }
        public void EditHidden(string LectName, bool Data)
        {
            var lection = from lect in _datacontext.TeacherLections
                          where lect.TheoryName == LectName
                          select lect;
            foreach (var lect in lection)
                lect.Hidden = Data;
            _datacontext.SubmitChanges();
        }

    }
}