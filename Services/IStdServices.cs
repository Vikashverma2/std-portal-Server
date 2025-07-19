using System;
using StdPortel.Models;

namespace StdPortel.Services;

public interface IStdServices
{
    Task CreateStudent(Students student);
    Task<List<Students>> GetSutdentData();
    Task<bool> DeleteStudent(string studentId);
   
}
