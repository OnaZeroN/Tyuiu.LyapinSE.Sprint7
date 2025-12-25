using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using Project.V11.Lib;
using System.Data;
using System.Text;

namespace Project.V11
{
    public partial class FormMain : Form
    {
        DataService ds = new();

        public FormMain()
        {
            InitializeComponent();

            toolTip_LSE.SetToolTip(buttonOpenFile_LSE, "Открыть файл CSV с базой данных");
            toolTip_LSE.SetToolTip(buttonSearch_LSE, "Применить поиск");
            toolTip_LSE.SetToolTip(buttonSaveFile_LSE, "Сохранить текущую таблицу в файл");
            toolTip_LSE.SetToolTip(buttonAdd_LSE, "Добавить пустую строку для ввода");
            toolTip_LSE.SetToolTip(buttonDelete_LSE, "Удалить строку");
            toolTip_LSE.SetToolTip(comboBoxPosition_LSE, "Отображать только записи с определенной должностью");
            toolTip_LSE.SetToolTip(comboBoxDepartment_LSE, "Отображать только записи с определенным отделом");
            toolTip_LSE.SetToolTip(buttonApplyFilters_LSE, "Применить фильтры");
            toolTip_LSE.SetToolTip(buttonSaveStat_LSE, "Экспортировать график");

            dataGridViewOut_LSE.AllowUserToAddRows = false;
            dataGridViewOut_LSE.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            buttonSaveFile_LSE.Enabled = false;
            buttonAdd_LSE.Enabled = false;
            buttonDelete_LSE.Enabled = false;
            buttonSearch_LSE.Enabled = false;
            textBoxSearch_LSE.Enabled = false;
            buttonSaveStat_LSE.Enabled = false;
            comboBoxPosition_LSE.Enabled = false;
            comboBoxDepartment_LSE.Enabled = false;
            buttonApplyFilters_LSE.Enabled = false;
        }

        private void buttonOpenFile_LSE_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog_LSE.ShowDialog();

                if (string.IsNullOrEmpty(openFileDialog_LSE.FileName)) return;

                string[,] matrix = ds.LoadData(openFileDialog_LSE.FileName);
                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);


                dataGridViewOut_LSE.RowCount = rows - 1;
                dataGridViewOut_LSE.ColumnCount = cols;

                for (int c = 0; c < cols; c++)
                {
                    dataGridViewOut_LSE.Columns[c].HeaderText = matrix[0, c];

                }

                for (int r = 1; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        dataGridViewOut_LSE.Rows[r - 1].Cells[c].Value = matrix[r, c];
                    }
                }

                buttonSaveFile_LSE.Enabled = true;
                buttonAdd_LSE.Enabled = true;
                buttonDelete_LSE.Enabled = true;
                buttonSearch_LSE.Enabled = true;
                buttonSaveStat_LSE.Enabled = true;
                textBoxSearch_LSE.Enabled = true;
                comboBoxPosition_LSE.Enabled = true;
                comboBoxDepartment_LSE.Enabled = true;
                buttonApplyFilters_LSE.Enabled = true;

                ResetFilters();
                UpdateStatistics_LSE();
                UpdateChart_LSE();
                UpdateFilters_LSE();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка чтения файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveFile_LSE_Click(object sender, EventArgs e)
        {
            saveFileDialog_LSE.FileName = "OutPutFileTask7.csv";
            saveFileDialog_LSE.InitialDirectory = Directory.GetCurrentDirectory();

            if (saveFileDialog_LSE.ShowDialog() != DialogResult.OK) return;

            if (string.IsNullOrEmpty(saveFileDialog_LSE.FileName)) return;

            try
            {
                int rows = dataGridViewOut_LSE.RowCount;
                int cols = dataGridViewOut_LSE.ColumnCount;
                string[,] matrix = new string[rows + 1, cols];

                for (int j = 0; j < cols; j++)
                {
                    matrix[0, j] = dataGridViewOut_LSE.Columns[j].HeaderText;
                }

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (dataGridViewOut_LSE.Rows[i].Cells[j].Value != null)
                        {
                            matrix[i + 1, j] = dataGridViewOut_LSE.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            matrix[i + 1, j] = "";
                        }
                    }
                }

                ds.SaveData(saveFileDialog_LSE.FileName, matrix);

                MessageBox.Show("Файл успешно сохранен!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveStat_LSE_Click(object sender, EventArgs e)
        {
            using var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png|PDF File|*.pdf";
            saveFileDialog.FileName = "Chart_LSE.png";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var pngExporter = new PngExporter { Width = 800, Height = 600 };
                pngExporter.ExportToFile(chartDiag_LSE.Model, saveFileDialog.FileName);
                MessageBox.Show("График успешно сохранен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewOut_LSE_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            UpdateStatistics_LSE();
            UpdateChart_LSE();
            UpdateFilters_LSE();
        }

        private void buttonHelp_LSE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа: Отдел кадров\nРазработчик: Ляпин С.Е.\nВерсия: 1.0\n\nРуководство:\nИспользуйте кнопки меню для загрузки, изменения, поиска и сохранения данных. График и статистика строится автоматически по данным оклада.", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonApplyFilter_Click(object sender, EventArgs e)
        {
            applyComplexFilter();
        }

        private void buttonSearch_LSE_Click(object sender, EventArgs e)
        {
            applyComplexFilter();
        }

        private void applyComplexFilter()
        {
            string selectedPos = comboBoxPosition_LSE.Text;
            string selectedDept = comboBoxDepartment_LSE.Text;
            string searchValue = textBoxSearch_LSE.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dataGridViewOut_LSE.Rows)
            {
                if (row.IsNewRow) continue;

                string rowPos = row.Cells[4].Value?.ToString();
                bool isPosMatch = (selectedPos == "Все" || selectedPos == "" || rowPos == selectedPos);

                string rowDept = row.Cells[5].Value?.ToString();
                bool isDeptMatch = (selectedDept == "Все" || selectedDept == "" || rowDept == selectedDept);

                bool isSearchMatch = false;

                if (string.IsNullOrEmpty(searchValue))
                {
                    isSearchMatch = true;
                }
                else
                {
                    for (int i = 0; i < dataGridViewOut_LSE.Columns.Count; i++)
                    {
                        if (row.Cells[i].Value != null &&
                            row.Cells[i].Value.ToString().ToLower().Contains(searchValue))
                        {
                            isSearchMatch = true;
                            break; 
                        }
                    }
                }

                row.Visible = isPosMatch && isDeptMatch && isSearchMatch;
            }
        }


        private void buttonAdd_LSE_Click(object sender, EventArgs e)
        {
            dataGridViewOut_LSE.Rows.Add();
            ResetFilters();
        }

        private void buttonDelete_LSE_Click(object sender, EventArgs e)
        {
            if (dataGridViewOut_LSE.CurrentRow != null && !dataGridViewOut_LSE.CurrentRow.IsNewRow)
            {
                var result = MessageBox.Show("Удалить выбранную строку?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dataGridViewOut_LSE.Rows.Remove(dataGridViewOut_LSE.CurrentRow);
                    ResetFilters();
                    UpdateStatistics_LSE();
                    UpdateChart_LSE();
                    UpdateFilters_LSE();
                }
            }
        }

        private void UpdateFilters_LSE()
        {
            comboBoxPosition_LSE.Items.Clear();
            comboBoxDepartment_LSE.Items.Clear();
            comboBoxPosition_LSE.Items.Add("Все");
            comboBoxDepartment_LSE.Items.Add("Все");
            comboBoxPosition_LSE.SelectedIndex = 0;
            comboBoxDepartment_LSE.SelectedIndex = 0;

            foreach (DataGridViewRow row in dataGridViewOut_LSE.Rows)
            {
                if (row.IsNewRow) continue;

                var posValue = row.Cells[4].Value?.ToString();
                if (posValue != null && !comboBoxPosition_LSE.Items.Contains(posValue))
                {
                    comboBoxPosition_LSE.Items.Add(posValue);
                }

                var deptValue = row.Cells[5].Value?.ToString();
                if (deptValue != null && !comboBoxDepartment_LSE.Items.Contains(deptValue))
                {
                    comboBoxDepartment_LSE.Items.Add(deptValue);
                }
            }
        }

        private void UpdateStatistics_LSE()
        {
            try
            {
                int salaryColIndex = -1;
                foreach (DataGridViewColumn col in dataGridViewOut_LSE.Columns)
                {
                    if (col.HeaderText.ToLower().Contains("оклад"))
                    {
                        salaryColIndex = col.Index;
                        break;
                    }
                }

                if (salaryColIndex == -1) return;

                List<double> salaryList = new List<double>();

                for (int i = 0; i < dataGridViewOut_LSE.Rows.Count; i++)
                {
                    var cellValue = dataGridViewOut_LSE.Rows[i].Cells[salaryColIndex].Value;

                    if (cellValue != null && double.TryParse(cellValue.ToString(), out double salary))
                    {
                        salaryList.Add(salary);
                    }
                }

                if (salaryList.Count == 0)
                {
                    labelStats_LSE.Text = "";
                    return;
                }

                var stats = ds.CalculateStatistics(salaryList.ToArray());

                labelStats_LSE.Text = $"Сотрудников: {stats.Count}\n" +
                                      $"Средний оклад: {stats.Average} руб.\n" +
                                      $"Мин: {stats.Min} руб. | Макс: {stats.Max} руб.";
            }
            catch
            {
            }
        }


        private void UpdateChart_LSE()
        {
            var model = new PlotModel { Title = "Зарплата сотрудников" };


            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Left,
                Title = "Сотрудники",
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot
            };

            var valueAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Сумма (руб)",
                MinimumPadding = 0,
                AbsoluteMinimum = 0
            };

            model.Axes.Add(categoryAxis);
            model.Axes.Add(valueAxis);

            var series = new BarSeries
            {
                Title = "Оклад",
                FillColor = OxyColors.SkyBlue,
                StrokeColor = OxyColors.Black,
                StrokeThickness = 1,
                LabelPlacement = LabelPlacement.Outside
            };

            int salaryColIndex = -1;
            int nameColIndex = -1;

            foreach (DataGridViewColumn col in dataGridViewOut_LSE.Columns)
            {
                if (col.HeaderText.ToLower().Contains("оклад")) salaryColIndex = col.Index;
                if (col.HeaderText.ToLower().Contains("фамилия")) nameColIndex = col.Index;
            }

            if (salaryColIndex != -1 && nameColIndex != -1)
            {
                for (int i = 0; i < dataGridViewOut_LSE.Rows.Count; i++)
                {
                    if (dataGridViewOut_LSE.Rows[i].Cells[salaryColIndex].Value != null &&
                        dataGridViewOut_LSE.Rows[i].Cells[nameColIndex].Value != null)
                    {
                        string salaryStr = dataGridViewOut_LSE.Rows[i].Cells[salaryColIndex].Value.ToString();
                        string name = dataGridViewOut_LSE.Rows[i].Cells[nameColIndex].Value.ToString();

                        if (double.TryParse(salaryStr, out double salary))
                        {
                            series.Items.Add(new BarItem { Value = salary });
                            categoryAxis.Labels.Add(name);
                        }
                    }
                }
            }

            model.Series.Add(series);
            chartDiag_LSE.Model = model;
        }

        private void ResetFilters()
        {
            textBoxSearch_LSE.Text = "";
            comboBoxDepartment_LSE.Text = "Все";
            comboBoxPosition_LSE.Text = "Все";

            foreach (DataGridViewRow row in dataGridViewOut_LSE.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
