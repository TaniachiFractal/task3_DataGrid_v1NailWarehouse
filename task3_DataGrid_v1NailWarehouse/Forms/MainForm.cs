using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using task3_DataGrid_v1NailWarehouse.Classes;
using task3_DataGrid_v1NailWarehouse.Models;

namespace task3_DataGrid_v1NailWarehouse.Forms
{
    /// <summary>
    /// Главная форма приложения
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// НДС в долях
        /// </summary>
        const decimal Tax = 0.2M;

        /// <summary>
        /// Список объектов типа <see cref="Models.Nail" />
        /// </summary>
        private List<Nail> products;

        /// <summary>
        /// Выбранный товар
        /// </summary>
        private Nail selectedNail;

        /// <summary>
        /// Инициализация формы и массива товаров
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            products = new List<Nail>();
            UpdateOutputData();
        }

        #region control events

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InfoForm().ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                products.Add(addForm.NewNail);
            }

            UpdateOutputData();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (products.Count > 0)
            {
                var nail = new Nail(products[nailsDGV.CurrentCell.RowIndex]);
                var editForm = new EditForm(nail);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    products[nailsDGV.CurrentCell.RowIndex] = editForm.SelectedNail;
                }
            }

            UpdateOutputData();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (products.Count > 0)
            {
                var nail = products[nailsDGV.CurrentCell.RowIndex];
                if (MessageBox.Show($"Вы точно хотите удалить товар \"{nail.Name}\"",
                        $"ВНИМАНИЕ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    == DialogResult.OK
                    )
                {
                    products.Remove(nail);
                }
            }

            UpdateOutputData();
        }

        #endregion

        private void UpdateOutputData()
        {
            var productsLinqQuery = (from p in products
                                     select new
                                     {
                                         Название = p.Name,
                                         Длина = p.Length,
                                         Материал = p.Material.GetDescription(),
                                         К_во = p.Count,
                                         МинК_во = p.MinCount,
                                         Цена = p.Price,
                                         Сумма = p.Price * p.Count
                                     }).ToList();

            nailsDGV.DataSource = productsLinqQuery;

            foreach (DataGridViewColumn col in nailsDGV.Columns)
            {
                col.HeaderText = Misc.CamelCaseToNormalCaseAndUnderscoreToHyphen(col.HeaderText);
            }

            var summNoTax = 0M;
            foreach (var product in products)
            { summNoTax += product.Price * product.Count; }

            var summWTax = 0M;
            foreach (var product in products)
            { summWTax += (product.Price + product.Price * Tax) * product.Count; }

            lbCount.Text = $"Позиций: {products.Count}";
            lbSumWTax.Text = $"Общ. сумма без НДС: {summNoTax} руб";
            lbSumNoTax.Text = $"Общ. сумма с НДС: {summWTax} руб";
        }

    }
}
