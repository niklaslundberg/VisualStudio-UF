using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApplication2.Models
{
    public class ListViewModel
    {
        private List<Models.Greeting> greetings;

        public List<Models.Greeting> Greetings
        {
            get { return greetings; }
        }

        public ListViewModel(List<Models.Greeting> greetings)
        {
            this.greetings = greetings;
        }
    }
}
