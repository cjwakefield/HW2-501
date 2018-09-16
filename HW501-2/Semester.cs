using System;
using System.Collections.Generic;

namespace HW5012
{
    /// <summary>
    /// This is a summery class about what semester classes are in. 
    /// </summary>
    public class Semester
    {
        private string _name;
        private List<Section> _sections ; 
        /// <summary>
        /// Initializes a new instance of the <see cref="T:HW5012.Semester"/> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        public Semester(string Name)
        {
            this._name = Name;
            _sections = new List<Section>(); 
        }
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <returns>The name.</returns>
        public string GetName() 
        {
            return _name; 
        }
        /// <summary>
        /// Includes the section.
        /// </summary>
        /// <param name="NewSection">New section.</param>
        public void IncludeSection(Section NewSection)
        {
            _sections.Add(NewSection); 
        }
    }
}
