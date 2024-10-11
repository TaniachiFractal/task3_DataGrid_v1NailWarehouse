using System;
using System.Drawing;
using System.Windows.Forms;
using task3_DataGrid_v1NailWarehouse.Classes;
using task3_DataGrid_v1NailWarehouse.Models;

namespace task3_DataGrid_v1NailWarehouse.Forms
{
    public partial class EditForm : Form
    {

        private Nail selectedNail;
        /// <summary>
        /// ВЫбранный для изменения товар
        /// </summary>
        public Nail SelectedNail => selectedNail;

        /// <summary>
        /// Инициализация формы
        /// </summary>
        public EditForm(Nail currNail)
        {
            InitializeComponent();

            selectedNail = currNail;

            titleLabel.Text = $"\"{selectedNail.Name}\"";

            foreach (var item in Enum.GetValues(typeof(Material)))
            { materialCB.Items.Add(item); }

            nameTb.AddBinding(target => target.Text, selectedNail, nail => nail.Name);
            lengthNUD.AddBinding(target => target.Value, selectedNail, nail => nail.Length);
            materialCB.AddBinding(target => target.SelectedItem, selectedNail, nail => nail.Material);
            countNUD.AddBinding(target => target.Value, selectedNail, nail => nail.Count);
            minCountNUD.AddBinding(target => target.Value, selectedNail, nail => nail.MinCount);
            priceNUD.AddBinding(target => target.Value, selectedNail, nail => nail.Price);

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
