using System;
using System.Collections.Generic;
using TutoratAppl.ViewModel;

namespace TutoratAppl.View
{
    internal class TutorWithLenghtSessionListView
    {
        private readonly IEnumerable<TutorWithLengthSessionListVM> _tutorList;

        public TutorWithLenghtSessionListView(IEnumerable<TutorWithLengthSessionListVM> tutorList)
        {
            _tutorList = tutorList;
        }

        public void Display()
        {
            foreach (var t in _tutorList)
            {
                Console.WriteLine(t.ToString());
            }
        }
    }
}