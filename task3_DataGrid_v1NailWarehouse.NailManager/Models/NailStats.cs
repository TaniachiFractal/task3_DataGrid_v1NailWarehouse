using task3_DataGrid_v1NailWarehouse.Contracts.Interfaces;
namespace task3_DataGrid_v1NailWarehouse.NailManagers.Models
{
    /// <summary>
    /// Вычисляемые данные о списке <see cref="Nail"/>
    /// </summary>
    public class NailStats : INailStats
    {
        /// <summary>
        /// <inheritdoc cref="INailStats.FullCount"/>
        /// </summary>
        public decimal FullCount { get; set; }

        /// <summary>
        /// <inheritdoc cref="INailStats.FullSummaryNoTax"/>
        /// </summary>
        public decimal FullSummaryNoTax { get; set; }

        /// <summary>
        /// <inheritdoc cref="INailStats.FullSummaryWithTax"/>
        /// </summary>
        public decimal FullSummaryWithTax { get; set; }
    }
}
