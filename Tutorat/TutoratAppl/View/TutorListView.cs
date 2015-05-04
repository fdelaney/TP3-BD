﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;
using TutoratAppl.ViewModel;

namespace TutoratAppl.View
{
    public class TutorListView
    {
        private readonly IEnumerable<TutorListVM> _tutorList;

        public TutorListView(IEnumerable<TutorListVM> tutorList)
        {
            _tutorList = tutorList;
        }

        public void Display()
        {
            foreach ( var t  in _tutorList)
            {
                Console.WriteLine(t.NameAndEMailToString());
            }
        }
    }
}
