using System;
using System.Collections.Generic; 
namespace HW5012
{
    /// <summary>
    /// A class that implments the IFaculty calss and holdes a list of section the teacher is teaching
    /// </summary>
    public class Faculty : IFaculty
    {
        private string name;
        private List<Section> _sections = new List<Section>();

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
