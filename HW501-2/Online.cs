using System;
namespace HW5012
{
    public class Online : Section
    {

        public Online(Semester semester , Course course , Faculty teacher , string number , int cap)
        {
            this._semester = semester; 
            this._course = course;
            this._faculty = teacher; 
            this.number = number;
            this.cap = cap; 
        }
        public override string ToString()
        {
            return _course.Number + " section (" + _course.Title + ")" +
                          "is being taught by " + _faculty.GetName() + " in " + _semester.GetName(); 
        }
    }
}
