using System;
namespace HW5012
{
    public abstract class Section
    {
        public string number;
        public int cap; 
        private Course _course ;
        private IFaculty _faculty; 
        private Semester _section ; 
        public void SetNumber(string number)
        {
            this.number = number; 
        }
        public string GetNumber()
        {
            return number; 
        }
        public void SetCap(int cap)
        {
            this.cap = cap;
        }
        public int GetCap()
        {
            return cap;
        }
    }
}
