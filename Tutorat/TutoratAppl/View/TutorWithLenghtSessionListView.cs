using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutoratAppl.ViewModel;

namespace TutoratAppl.View
{
    class TutorWithLenghtSessionListView
    {
        private readonly IEnumerable<TutorWithLengthSessionListVM> _tutorList;

        public TutorWithLenghtSessionListView(IEnumerable<TutorWithLengthSessionListVM> tutorList)
        {
            _tutorList = tutorList;
        }

        public void Display()
        {
            foreach ( var t  in _tutorList)
            {
                Console.WriteLine(t.ToString());
            }
        }
    }
}
