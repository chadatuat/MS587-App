using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Server.Services
{
    public class IHighScoreService
    {
    }
    public interface IEmployeeService
    {
        Task<IEnumerable<IHighScoreService>> GetEmployees();
    }
}
