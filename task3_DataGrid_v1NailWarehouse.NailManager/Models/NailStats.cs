using task3_DataGrid_v1NailWarehouse.Contracts.Interfaces;
namespace task3_DataGrid_v1NailWarehouse.NailManagers.Models
{
    /// <summary>
    /// Вычисляемые данные о списке <see cref="Nail"/>
    /// </summary>
    public class NailStats : INailStats
    {
        /// <inheritdoc/>
        public decimal FullCount { get; set; }

        /// <inheritdoc/>
        public decimal FullSummaryNoTax { get; set; }

        /// <inheritdoc/>
        public decimal FullSummaryWithTax { get; set; }
    }
}
