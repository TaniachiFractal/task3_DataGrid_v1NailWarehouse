using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_DataGrid_v1NailWarehouse.Interfaces
{
    /// <summary>
    /// Интерфейс для вычисляемых данных о списке <see cref="Nail"/>
    /// </summary>
    public interface INailStats
    {
        decimal FullCount { get; }

        decimal FullSummaryNoTax { get; }

        decimal FullSummaryWithTax { get; }
    }
}
