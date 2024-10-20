﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task3_DataGrid_v1NailWarehouse.Contracts.Interfaces;
using task3_DataGrid_v1NailWarehouse.Contracts.Models;
using task3_DataGrid_v1NailWarehouse.NailManagers.Models;

namespace task3_DataGrid_v1NailWarehouse.NailManagers
{
    /// <inheritdoc cref="INailManager"/>
    public class NailManager : INailManager
    {
        const decimal Tax = 0.2M;
        private readonly INailStorage nailStorage;

        /// <summary>
        /// Конструктор
        /// </summary>
        public NailManager(INailStorage nailStorage)
        {
            this.nailStorage = nailStorage;
        }

        /// <inheritdoc/>
        public async Task<Nail> AddAsync(Nail person)
        {
            var result = await nailStorage.AddAsync(person);
            return result;
        }

        /// <inheritdoc/>
        public async Task<bool> DeleteAsync(Guid id)
        {
            var result = await nailStorage.DeleteAsync(id);
            return result;
        }

        /// <inheritdoc/>
        public Task EditAsync(Nail person)
            => nailStorage.EditAsync(person);

        /// <inheritdoc/>
        public Task<IReadOnlyCollection<Nail>> GetAllAsync()
            => nailStorage.GetAllAsync();

        /// <inheritdoc/>
        public async Task<INailStats> GetStatsAsync()
        {
            var result = await nailStorage.GetAllAsync();
            return new NailStats
            {
                FullCount = result.Count,
                FullSummaryNoTax = result.Sum(nail => nail.Price * nail.Count),
                FullSummaryWithTax = result.Sum(nail => (nail.Price + (nail.Price * Tax)) * nail.Count),
            };
        }
    }
}
