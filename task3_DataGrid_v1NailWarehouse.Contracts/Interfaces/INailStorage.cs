using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using task3_DataGrid_v1NailWarehouse.Contracts.Models;

namespace task3_DataGrid_v1NailWarehouse.Contracts.Interfaces
{
    /// <summary>
    /// Интерфейс хранилища склада гвоздей
    /// </summary>
    public interface INailStorage
    {
        /// <summary>
        /// Асинхронное получение всех данных
        /// </summary>
        Task<IReadOnlyCollection<Nail>> GetAllAsync();

        /// <summary>
        /// Асинхронная операция добавления
        /// </summary>
        Task<Nail> AddAsync(Nail nail);

        /// <summary>
        /// Асинхронная операция изменения
        /// </summary>
        Task EditAsync(Nail nail);

        /// <summary>
        /// Асинхронная операция удаленияв
        /// </summary>
        Task<bool> DeleteAsync(Guid id);
    }
}
