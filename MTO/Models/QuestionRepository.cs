/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTO.Models
{
    public class QuestionRepository
    {
        private MTOnewDataContext _datacontext;
        public QuestionRepository(MTOnewDataContext datacontext)
        {
            _datacontext = datacontext;
        }
        public void CreateQuestion1(string QuestionText, string Answer)
        {
            int GetID = 0;
            Questions quest = new Questions { QuestionTitle = QuestionText, QuestionTypeID = 1 };
            _datacontext.Questions.InsertOnSubmit(quest);
            _datacontext.SubmitChanges();

            var selected = from q in _datacontext.Questions
                           where q.QuestionTitle == QuestionText
                           select q;
            foreach (var question in selected)
                GetID = question.QuestionID;
            InputTrueAnswers input = new InputTrueAnswers { QuestionID = GetID, InputTrueAnswer = Answer };
            _datacontext.InputTrueAnswers.InsertOnSubmit(input);
            _datacontext.SubmitChanges();
        }
        public void CreateQuestion2(string QuestionText, string radio1, string radio2, string radio3, string radio4)
        {
            int GetID = 0;
            Questions quest = new Questions { QuestionTitle = QuestionText, QuestionTypeID = 2 };
            _datacontext.Questions.InsertOnSubmit(quest);
            _datacontext.SubmitChanges();

            var selected = from q in _datacontext.Questions
                           where q.QuestionTitle == QuestionText
                           select q;
            foreach (var question in selected)
                GetID = question.QuestionID;
            RadioAnswers radio = new RadioAnswers { QuestionID = GetID, Radio1 = radio1, Radio2 = radio2, Radio3 = radio3, Radio4 = radio4 };
            _datacontext.RadioAnswers.InsertOnSubmit(radio);
            _datacontext.SubmitChanges();
        }
        public void CreateQuestion3(string QuestionText, string check1, string check2, string check3, string check4, string check5)
        {
            int GetID = 0;
            Questions quest = new Questions { QuestionTitle = QuestionText, QuestionTypeID = 3 };
            _datacontext.Questions.InsertOnSubmit(quest);
            _datacontext.SubmitChanges();

            var selected = from q in _datacontext.Questions
                           where q.QuestionTitle == QuestionText
                           select q;
            foreach (var question in selected)
                GetID = question.QuestionID;
            CheckboxAnswers checkbox = new CheckboxAnswers { QuestionID = GetID, Checkbox1 = check1, Checkbox2 = check2, Checkbox3 = check3, Checkbox4 = check4, Checkbox5 = check5 };
            _datacontext.CheckboxAnswers.InsertOnSubmit(checkbox);
            _datacontext.SubmitChanges();
        }
        public void CreateQuestion4(string QuestionText, string expA, string expB, string expC, string expD, string optA, string optB, string optC, string optD)
        {
            int GetID = 0;
            Questions quest = new Questions { QuestionTitle = QuestionText, QuestionTypeID = 4 };
            _datacontext.Questions.InsertOnSubmit(quest);
            _datacontext.SubmitChanges();

            var selected = from q in _datacontext.Questions
                           where q.QuestionTitle == QuestionText
                           select q;
            foreach (var question in selected)
                GetID = question.QuestionID;
            OptionAnswers option = new OptionAnswers { QuestionID = GetID, ExpA = expA, ExpB = expB, ExpC = expC, ExpD = expD, OptionA = optA, OptionB = optB, OptionC = optC, OptionD = optD };
            _datacontext.OptionAnswers.InsertOnSubmit(option);
            _datacontext.SubmitChanges();
        }
        public void EditQuestion1(int id, string Title, string Answer)
        {
            var quests = from q in _datacontext.Questions
                         where q.QuestionID == id
                         select q;
            var questBehind = from q in _datacontext.InputTrueAnswers
                              where q.QuestionID == id
                              select q;
            foreach (var quest in quests)
                quest.QuestionTitle = Title;
            foreach (var quest in questBehind)
                quest.InputTrueAnswer = Answer;
            _datacontext.SubmitChanges();
        }
        public void EditQuestion2(int id, string QuestionText, string radio1, string radio2, string radio3, string radio4)
        {
            var quests = from q in _datacontext.Questions
                         where q.QuestionID == id
                         select q;
            var questBehind = from q in _datacontext.RadioAnswers
                              where q.QuestionID == id
                              select q;
            foreach (var quest in quests)
                quest.QuestionTitle = QuestionText;
            foreach (var quest in questBehind)
            {
                quest.Radio1 = radio1;
                quest.Radio2 = radio2;
                quest.Radio3 = radio3;
                quest.Radio4 = radio4;
            }
            _datacontext.SubmitChanges();
        }
        public void EditQuestion3(int id, string QuestionText, string check1, string check2, string check3, string check4, string check5)
        {
            var quests = from q in _datacontext.Questions
                         where q.QuestionID == id
                         select q;
            var questBehind = from q in _datacontext.CheckboxAnswers
                              where q.QuestionID == id
                              select q;
            foreach (var quest in quests)
                quest.QuestionTitle = QuestionText;
            foreach (var quest in questBehind)
            {
                quest.Checkbox1 = check1;
                quest.Checkbox2 = check2;
                quest.Checkbox3 = check3;
                quest.Checkbox4 = check4;
                quest.Checkbox5 = check5;
            }
            _datacontext.SubmitChanges();
        }
        public void EditQuestion4(int id, string QuestionText, string expA, string expB, string expC, string expD, string optA, string optB, string optC, string optD)
        {
            var quests = from q in _datacontext.Questions
                         where q.QuestionID == id
                         select q;
            var questBehind = from q in _datacontext.OptionAnswers
                              where q.QuestionID == id
                              select q;
            foreach (var quest in quests)
                quest.QuestionTitle = QuestionText;
            foreach (var quest in questBehind)
            {
                quest.ExpA = expA;
                quest.ExpB = expB;
                quest.ExpC = expC;
                quest.ExpD = expD;
                quest.OptionA = optA;
                quest.OptionB = optB;
                quest.OptionC = optC;
                quest.OptionD = optD;
            }
            _datacontext.SubmitChanges();
        }
    }
}*/