using task3_DataGrid_v1NailWarehouse.Contracts.Interfaces;
namespace task3_DataGrid_v1NailWarehouse.NailManagers.Models
{
    /// <summary>
    /// Вычисляемые данные о списке <see cref="Nail"/>
    /// </summary>
    public class NailStats : INailStats
    {
        /// <inheritdoc cref="INailStats.FullCount"/>
        public decimal FullCount { get; set; }

        /// <inheritdoc cref="INailStats.FullSummaryNoTax"/>
        public decimal FullSummaryNoTax { get; set; }

        /// <inheritdoc cref="INailStats.FullSummaryWithTax"/>
        public decimal FullSummaryWithTax { get; set; }
    }
}
