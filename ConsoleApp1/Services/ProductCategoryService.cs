using ConsoleApp1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    internal class ProductCategoryService : IOverAllServieces
    {
        /// <summary>
        /// Represents the database context used for interacting with the ItStepProject database.
        /// </summary>
        /// <remarks></remarks>
        private readonly ItStepProjectContext context = new ItStepProjectContext();
        /// <summary>
        /// Asynchronously adds the specified entity to the database context and saves the changes.
        /// </summary>
        /// <typeparam name="T">The type of the entity to add. Must be a reference type.</typeparam>
        /// <param name="Variable">The entity to add to the database. Cannot be <see langword="null"/>.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public async Task AddAsync<T>(T Variable) where T : class
        {
            await context.AddAsync(Variable);
            await context.SaveChangesAsync();
        }
        /// <summary>
        /// Asynchronously deletes an entity of type T by its identifier.
        /// </summary>
        /// <typeparam name="T">The type of the entity to delete.</typeparam>
        /// <param name="id">The entity to Delete to the database. Cannot be <see langword="null"/></param>
        /// <returns>A delete task</returns>
        public async Task DeleteAsync<T>(int id) where T : class
        {
            await context.FindAsync<T>(id);

            context.Remove(id);

            await context.SaveChangesAsync();
        }
        /// <summary>
        /// Asynchronously retrieves all entities of type T from the database.
        /// </summary>
        /// <typeparam name="T">The type of entity to get all.</typeparam>
        /// <returns>Task that gets all list asynch</returns>
        public async Task<List<T>> GetAllAsync<T>() where T : class
        {
            return context.Set<T>().ToList();
        }
        /// <summary>
        /// Asynchronously retrieves an entity of the specified type by its unique identifier.
        /// </summary>
        /// <typeparam name="T">The type of the entity to retrieve. Must be a reference type.</typeparam>
        /// <param name="id">The unique identifier of the entity to retrieve.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the entity of type <typeparamref
        /// name="T"/>  if found; otherwise, <see langword="null"/>.</returns>
        public async Task<T?> GetByIdAsync<T>(int id) where T : class
        {
            return await context.FindAsync<T>(id);
        }
        /// <summary>
        /// Asynchronously updates the specified entity in the database context and saves the changes.
        /// </summary>
        /// <typeparam name="T">The type of entity to update.</typeparam>
        /// <returns>A task that updates asynchronously</returns>
        public async Task UpdateAsync<T>(T Variable) where T : class
        {
            await context.FindAsync<T>(Variable);
            await context.SaveChangesAsync();
        }
    }
}
