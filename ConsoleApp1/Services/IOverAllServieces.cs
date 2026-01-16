using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    /// <summary>
    /// Crud operations interface
    /// </summary>
    /// <typeparam name="T">CRUD</typeparam>
    internal interface IOverAllServieces<T> where T : class
    {
        /// <summary>
        /// Asynchronously gets all items from the collection.
        /// </summary>
        /// <returns></returns>
        Task<List<T>> GetAllAsync();
        /// <summary>
        /// Asynchronously gets item by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T?> GetByIdAsync(int id);
        /// <summary>
        /// Asynchronously adds the specified item to the collection.
        /// </summary>
        /// <param name="Variable">The item to add to the collection. Cannot be <see langword="null"/>.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        Task AddAsync(T Variable);
        /// <summary>
        /// Asynchronously updates the specified entity asynchronously.
        /// </summary>
        /// <param name="Variable">The entity to be updated. Cannot be null.</param>
        /// <returns>A task that represents the asynchronous update operation.</returns>
        Task UpdateAsync(T Variable);
        /// <summary>
        /// asynchronously deletes an entity by its identifier.
        /// </summary>
        /// <param name="id">Delete</param>
        /// <returns>A task that deletes using an id</returns>
        Task DeleteAsync(int id);
    }
}
