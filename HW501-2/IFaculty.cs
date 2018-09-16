using System;
namespace HW5012
{
    /// <summary>
    /// this is an interface for a Faculty to help with user creation.
    /// </summary>
    public interface IFaculty
    {
         string GetName();
         void AssignSection(Section assignedSection);
    }
}
