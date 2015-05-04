using System.Collections.Generic;
using TutoratAppl.ViewModel;
namespace TutoratAppl.View
{
    public class HelpedListView
    {
        private readonly IEnumerable<HelpedListVM> _helpedList;

        public HelpedListView(IEnumerable<HelpedListVM> helpedList)
        {
            _helpedList = helpedList;
        }

        public void Display()
        {

        }
    }
}