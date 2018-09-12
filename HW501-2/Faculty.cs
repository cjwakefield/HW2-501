using System;
using System.Collections.Generic; 
namespace HW5012
{
    public class Faculty : IFaculty
    {
        private string name;
        private List<Section> _sections;

        public Faculty(string name)
        {
            this.name = name; 
        }

        public string GetName()
        {
            return name;
        }

        public void AssignSection(Section assignSection)
        {
            _sections.Add(assignSection);
        }
    }
}
