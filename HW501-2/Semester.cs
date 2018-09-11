using System;
using System.Collections.Generic;

namespace HW5012
{
    public class Semester
    {
        private string _name;
        private List<Section> _sections; 

        public Semester(string Name)
        {
            this._name = Name;
            _sections = new List<Section>(); 
        }
        public string GetName() 
        {
            return _name; 
        }
        public void IncludeSection(Section NewSection)
        {
            _sections.Add(NewSection); 
        }
    }
}
