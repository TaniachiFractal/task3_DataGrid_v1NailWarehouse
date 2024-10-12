using task3_DataGrid_v1NailWarehouse.Interfaces;

namespace task3_DataGrid_v1NailWarehouse.Models
{
    /// <summary>
    /// Вычисляемые данные о списке <see cref="Nail"/>
    /// </summary>
    public class NailStats : INailStats
    {
        /// <summary>
        /// Общее количество позиций
        /// </summary>
        public decimal FullCount { get; set; }

        /// <summary>
        /// Общая сумма без НДС
        /// </summary>
        public decimal FullSummaryNoTax { get; set; }

        /// <summary>
        /// Общая сумма с НДС
        /// </summary>
        public decimal FullSummaryWithTax { get; set; }
    }
}
