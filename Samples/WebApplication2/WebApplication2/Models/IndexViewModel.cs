using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class IndexViewModel
    {
        private string _name;

        public string Name
        {
            get { return _name; }
        }
        public IndexViewModel(string name)
        {
            _name = name;
        }
    }
}