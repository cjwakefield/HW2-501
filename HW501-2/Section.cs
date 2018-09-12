using System;
namespace HW5012
{
    public abstract class Section
    {
        public string number;
        public int cap; 

        protected Course _course ;
        protected IFaculty _faculty; 
        protected Semester _semester ; 

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
