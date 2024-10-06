using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace task3_DataGrid_v1NailWarehouse.Classes
{
    /// <summary>
    /// Расширения для различных классов
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Создание связки двух полей
        /// </summary>
        public static void AddBinding<TControl, TSource>(this TControl target,
            Expression<Func<TControl, object>> targetProperty,
            TSource source,
            Expression<Func<TSource, object>> sourceProperty)
            where TControl : Control
            where TSource : class
        {
            var targetName = GetMemberName(targetProperty);
            var sourceName = GetMemberName(sourceProperty);

            target.DataBindings.Add(new Binding(targetName, source, sourceName,
                false,
                DataSourceUpdateMode.OnPropertyChanged));

        }

        /// <summary>
        /// Получить имя нужного поля
        /// </summary>
        private static string GetMemberName<TItem, TMember>(Expression<Func<TItem, TMember>> targetMember)
        {
            if (targetMember.Body is MemberExpression memberExpression)
            {
                return memberExpression.Member.Name;
            }

            if (targetMember.Body is UnaryExpression unaryExpression)
            {
                var operand = unaryExpression.Operand as MemberExpression;
                return operand.Member.Name;
            }

            throw new ArgumentException();
        }

        /// <summary>
        /// Получить описание поля enum
        /// </summary>
        public static string GetDescription<T>(this T enumValue)
            where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum)
            { return null; }

            var description = enumValue.ToString();
            var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());

            if (fieldInfo != null)
            {
                var attrs = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), true);
                if (attrs != null && attrs.Length > 0)
                {
                    description = ((DescriptionAttribute)attrs[0]).Description;
                }
            }

            return description;
        }
        //https://blog.hildenco.com/2018/07/getting-enum-descriptions-using-c.html


    }
}
