using System;
using System.Drawing;
using System.Windows.Forms;
using task3_DataGrid_v1NailWarehouse.Classes;
using task3_DataGrid_v1NailWarehouse.Contracts.Models;

namespace task3_DataGrid_v1NailWarehouse.Forms
{
    /// <summary>
    /// Форма работы с товаром
    /// </summary>
    public partial class NailDataEditForm : Form
    {
        public const int ComboboxPadding = 3;
        private readonly Nail currNail;

        /// <summary>
        /// Товар, с которым работает эта форма
        /// </summary>
        public Nail CurrNail => currNail;

        /// <summary>
        /// Конструктор
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

            materialCB.DataSource = Enum.GetValues(typeof(Material));

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
                e.Bounds.Y + ComboboxPadding);

        }

        /// <summary>
        /// Закрыть форму с успехом
        /// </summary>
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (currNail.Validate())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

    }
}
