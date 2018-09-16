using System;
namespace HW5012
{
    public class OnCampus : Section
    {
        /// <summary>
        /// This class in one of the two main calsses that make the progream actrualy exicutiable
        /// it stores all data for the user. 
        /// </summary>
        /// <param name="semester">Semester.</param>
        /// <param name="course">Course.</param>
        /// <param name="teacher">Teacher.</param>
        /// <param name="number">Number.</param>
        /// <param name="cap">Cap.</param>
        public OnCampus(Semester semester, Course course, Faculty teacher, string number, int cap)
        {
            this._semester = semester;
            this._course = course;
            this._faculty = teacher;
            this.number = number;
            this.cap = cap; 
        }
        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:HW5012.OnCampus"/>.
        /// </summary>
        /// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:HW5012.OnCampus"/>.</returns>
        public override string ToString()
        {
            return _course.Number + " section (" + _course.Title + ")" +
                          " is being taught by " + _faculty.GetName() + " in " + _semester.GetName();
        }
    }
}
