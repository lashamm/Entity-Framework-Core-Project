using ConsoleApp1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    internal class ModelService : IOverAllServieces
    {
        private readonly ItStepProjectContext context = new ItStepProjectContext();

        public async Task AddAsync<T>(T Variable) where T : class
        {
            await context.AddAsync(Variable);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync<T>(int id) where T : class
        {
            await context.FindAsync<T>(id);

            context.Remove(id);

            await context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync<T>() where T : class
        {
            return context.Set<T>().ToList();
        }

        public async Task<T?> GetByIdAsync<T>(int id) where T : class
        {
            return await context.FindAsync<T>(id);
        }

        public async Task UpdateAsync<T>(T Variable) where T : class
        {
            await context.FindAsync<T>(Variable);
            await context.SaveChangesAsync();
        }
    }
}
