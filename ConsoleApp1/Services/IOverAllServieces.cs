using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    internal interface IOverAllServieces<T> where T : class
    {

        Task<List<T>> GetAllAsync();
        Task<T?> GetByIdAsync(int id);
        Task AddAsync(T Variable);
        Task UpdateAsync(T Variable);
        Task DeleteAsync(int id);
    }
}
