using System;
namespace HW5012
{
    public abstract class Section
    {
        public string number;
        public int _cap; 
        public void SetNumber(string number)
        {
            this.number = number; 
        }
        public string GetNumber()
        {
            return number; 
        }
        public void SetCap(int _cap)
        {
            this._cap = _cap;
        }
        public int GetCap()
        {
            return _cap;
        }

        public Section()
        {

        }
    }
}
