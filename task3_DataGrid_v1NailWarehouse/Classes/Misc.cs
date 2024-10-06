using System.Text;

namespace task3_DataGrid_v1NailWarehouse.Classes
{
    /// <summary>
    /// Разные методы
    /// </summary>
    public static class Misc
    {
        /// <summary>
        /// Перевести camelCase к написанию с пробелами и сменить нижнее подчеркивание на дефис
        /// </summary>
        public static string CamelCaseToNormalCaseAndUnderscoreToHyphen(string str)
        {
            var headerStrBuild = new StringBuilder();
            for (var i = 0; i < str.Length; i++)
            {
                var nextChar = str[i];
                if (nextChar == '_')
                {
                    nextChar = '-';
                }

                if (i > 0)
                {
                    if (char.IsUpper(nextChar) && char.IsLower(str[i - 1]))
                    {
                        headerStrBuild.Append(' ');
                    }
                }

                headerStrBuild.Append(nextChar);
            }
            return headerStrBuild.ToString();
        }
    }
}
