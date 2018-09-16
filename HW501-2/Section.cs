using System;
namespace HW5012
{
    /// <summary>
    /// This is an abstract calss that holdes data about class sections. 
    /// </summary>
    public abstract class Section
    {
        public string number;
        public int cap; 

        protected Course _course ;
        protected IFaculty _faculty; 
        protected Semester _semester ; 
        /// <summary>
        /// Sets the number.
        /// </summary>
        /// <param name="number">Number.</param>
        public void SetNumber(string number)
        {
            this.number = number; 
        }
        /// <summary>
        /// Gets the number.
        /// </summary>
        /// <returns>The number.</returns>
        public string GetNumber()
        {
            return number; 
        }
        /// <summary>
        /// Sets the cap.
        /// </summary>
        /// <param name="cap">Cap.</param>
        public void SetCap(int cap)
        {
            this.cap = cap;
        }
        /// <summary>
        /// Gets the cap.
        /// </summary>
        /// <returns>The cap.</returns>
        public int GetCap()
        {
            return cap;
        }
    }
}
