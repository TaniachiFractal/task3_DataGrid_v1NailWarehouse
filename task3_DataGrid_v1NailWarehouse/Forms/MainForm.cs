using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using task3_DataGrid_v1NailWarehouse.Interfaces;
using task3_DataGrid_v1NailWarehouse.Models;

namespace task3_DataGrid_v1NailWarehouse.Forms
{
    /// <summary>
    /// Главная форма приложения
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly INailManager nailManager;
        private readonly BindingSource nailBindingSource;

        /// <summary>
        /// Инициализация формы 
        /// </summary>
        public MainForm(INailManager manager)
        {
            InitializeComponent();

            nailManager = manager;
            nailBindingSource = new BindingSource();

            nailsDGV.DataSource = nailBindingSource;

            nailsDGV.AutoGenerateColumns = false;
        }

        private async Task SetStats()
        {
            var result = await nailManager.GetStatsAsync();
            lbCount.Text = $"Позиций: {result.FullCount}";
            lbSumWTax.Text = $"Общ. сумма с НДС: {result.FullSummaryWithTax}";
            lbSumNoTax.Text = $"Общ. сумма без НДС: {result.FullSummaryNoTax}";
        }

        #region control events

        private async void MainForm_Load(object sender, EventArgs e)
        {
            var source = await nailManager.GetAllAsync();

            var sourceQuery = (from source
                               select new
                               {

                               }).ToList();

            nailBindingSource.DataSource 
            await SetStats();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InfoForm().ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            var nailDataEditForm = new NailDataEditForm();
            if (nailDataEditForm.ShowDialog() == DialogResult.OK)
            {
                await nailManager.AddAsync(nailDataEditForm.CurrNail);
                nailBindingSource.ResetBindings(false);
                await SetStats();
            }
        }

        private async void editButton_Click(object sender, EventArgs e)
        {
            if (nailsDGV.SelectedRows.Count > 0)
            {
                var nail = (Nail)nailsDGV.Rows[nailsDGV.SelectedRows[0].Index].DataBoundItem;
                var nailDataEditForm = new NailDataEditForm(nail);
                if (nailDataEditForm.ShowDialog() == DialogResult.OK)
                {
                    await nailManager.EditAsync(nailDataEditForm.CurrNail);
                    nailBindingSource.ResetBindings(false);
                    await SetStats();
                }
            }
        }

        private async void removeButton_Click(object sender, EventArgs e)
        {
            if (nailsDGV.SelectedRows.Count > 0)
            {
                var nail = (Nail)nailsDGV.Rows[nailsDGV.SelectedRows[0].Index].DataBoundItem;
                if (MessageBox.Show(
                    $"Точно удалить товар \"{nail.Name}\"?",
                    "ВНИМАНИЕ",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                    ) == DialogResult.OK)
                {
                    await nailManager.DeleteAsync(nail.Id);
                    nailBindingSource.ResetBindings(false);
                    await SetStats();
                }
            }
        }

        #endregion

    }
}
