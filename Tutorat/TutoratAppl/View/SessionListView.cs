﻿using System;
using System.Collections.Generic;
using TutoratAppl.ViewModel;

namespace TutoratAppl.View
{
    public class SessionListView
    {
        private readonly IEnumerable<SessionListVM> _sessionList;

        public SessionListView(IEnumerable<SessionListVM> sessionList)
        {
            _sessionList = sessionList;
        }

        public void Display()
        {
            foreach (var s in _sessionList)
            {
                Console.WriteLine("     " + s.ToString());
            }
        }
    }
}