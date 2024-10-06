using System.ComponentModel;

namespace task3_DataGrid_v1NailWarehouse.Models
{
    /// <summary>
    /// Список вариантов материалов гвоздей
    /// </summary>
    public enum Material
    {
        /// <summary>
        /// Медь
        /// </summary>
        [Description("Медь")]
        Copper = 1,
        /// <summary>
        /// Сталь
        /// </summary>
        [Description("Сталь")]
        Steel = 2,
        /// <summary>
        /// Железо
        /// </summary>
        [Description("Железо")]
        Iron = 3,
        /// <summary>
        /// Хром
        /// </summary>
        [Description("Хром")]
        Chrome = 4,
    }
}
