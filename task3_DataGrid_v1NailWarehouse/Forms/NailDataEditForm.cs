using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using task3_DataGrid_v1NailWarehouse.Classes;
using task3_DataGrid_v1NailWarehouse.Models;

namespace task3_DataGrid_v1NailWarehouse.Forms
{
    /// <summary>
    /// Форма работы с товаром
    /// </summary>
    public partial class NailDataEditForm : Form
    {
        private readonly Nail currNail;

        /// <summary>
        /// Товар, с которым работает эта форма
        /// </summary>
        public Nail CurrNail => currNail;

        /// <summary>
        /// Инициализация формы
        /// </summary>
        public NailDataEditForm(Nail outNail = null)
        {
            InitializeComponent();

            currNail = outNail == null ?
                DataGenerator.CreateNail()
                : new Nail
                {
                    Id = outNail.Id,
                    Name = outNail.Name,
                    Length = outNail.Length,
                    Material = outNail.Material,
                    Count = outNail.Count,
                    MinCount = outNail.MinCount,
                    Price = outNail.Price,
                };

            foreach (var item in Enum.GetValues(typeof(Material)))
            { materialCB.Items.Add(item); }

            nameTb.AddBinding(target => target.Text, currNail, nail => nail.Name, errorProvider);
            lengthNUD.AddBinding(target => target.Value, currNail, nail => nail.Length);
            materialCB.AddBinding(target => target.SelectedItem, currNail, nail => nail.Material);
            countNUD.AddBinding(target => target.Value, currNail, nail => nail.Count);
            minCountNUD.AddBinding(target => target.Value, currNail, nail => nail.MinCount);
            priceNUD.AddBinding(target => target.Value, currNail, nail => nail.Price);
        }

        /// <summary>
        /// Нарисовать элементы <see cref="countNUD"/> красиво
        /// </summary>
        private void materialCB_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            var value = (Material)(sender as ComboBox).Items[e.Index];

            e.Graphics.DrawString(value.GetDescription(),
                e.Font,
                new SolidBrush(e.ForeColor),
                e.Bounds.X,
                e.Bounds.Y + 2);


        }

        /// <summary>
        /// Закрыть форму с успехом
        /// </summary>
        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

    }
}
