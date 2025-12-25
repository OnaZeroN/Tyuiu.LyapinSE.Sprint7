namespace Project.V11
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelLeft_LSE = new Panel();
            groupBoxFilter_LSE = new GroupBox();
            buttonApplyFilters_LSE = new Button();
            labelDepartment_LSE = new Label();
            comboBoxDepartment_LSE = new ComboBox();
            labelPosition_LSE = new Label();
            comboBoxPosition_LSE = new ComboBox();
            panelFillEdit_LSE = new Panel();
            buttonHelp_LSE = new Button();
            groupBoxEdit_LSE = new GroupBox();
            buttonDelete_LSE = new Button();
            buttonAdd_LSE = new Button();
            panelFillSearch_LSE = new Panel();
            groupBoxSearch_LSE = new GroupBox();
            buttonSearch_LSE = new Button();
            panelFillSearchBox_LSE = new Panel();
            textBoxSearch_LSE = new TextBox();
            panelFillSave_LSE = new Panel();
            buttonSaveFile_LSE = new Button();
            panelFillOpen_LSE = new Panel();
            buttonOpenFile_LSE = new Button();
            panelRight_LSE = new Panel();
            chartDiag_LSE = new OxyPlot.WindowsForms.PlotView();
            panelStat_LSE = new Panel();
            buttonSaveStat_LSE = new Button();
            groupBoxStats_LSE = new GroupBox();
            labelStats_LSE = new Label();
            panelFill_LSE = new Panel();
            dataGridViewOut_LSE = new DataGridView();
            openFileDialog_LSE = new OpenFileDialog();
            saveFileDialog_LSE = new SaveFileDialog();
            toolTip_LSE = new ToolTip(components);
            panelLeft_LSE.SuspendLayout();
            groupBoxFilter_LSE.SuspendLayout();
            groupBoxEdit_LSE.SuspendLayout();
            groupBoxSearch_LSE.SuspendLayout();
            panelRight_LSE.SuspendLayout();
            panelStat_LSE.SuspendLayout();
            groupBoxStats_LSE.SuspendLayout();
            panelFill_LSE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_LSE).BeginInit();
            SuspendLayout();
            // 
            // panelLeft_LSE
            // 
            panelLeft_LSE.BackColor = Color.WhiteSmoke;
            panelLeft_LSE.Controls.Add(groupBoxFilter_LSE);
            panelLeft_LSE.Controls.Add(panelFillEdit_LSE);
            panelLeft_LSE.Controls.Add(buttonHelp_LSE);
            panelLeft_LSE.Controls.Add(groupBoxEdit_LSE);
            panelLeft_LSE.Controls.Add(panelFillSearch_LSE);
            panelLeft_LSE.Controls.Add(groupBoxSearch_LSE);
            panelLeft_LSE.Controls.Add(panelFillSave_LSE);
            panelLeft_LSE.Controls.Add(buttonSaveFile_LSE);
            panelLeft_LSE.Controls.Add(panelFillOpen_LSE);
            panelLeft_LSE.Controls.Add(buttonOpenFile_LSE);
            panelLeft_LSE.Dock = DockStyle.Left;
            panelLeft_LSE.Location = new Point(0, 0);
            panelLeft_LSE.Name = "panelLeft_LSE";
            panelLeft_LSE.Padding = new Padding(5);
            panelLeft_LSE.Size = new Size(220, 681);
            panelLeft_LSE.TabIndex = 1;
            // 
            // groupBoxFilter_LSE
            // 
            groupBoxFilter_LSE.Controls.Add(buttonApplyFilters_LSE);
            groupBoxFilter_LSE.Controls.Add(labelDepartment_LSE);
            groupBoxFilter_LSE.Controls.Add(comboBoxDepartment_LSE);
            groupBoxFilter_LSE.Controls.Add(labelPosition_LSE);
            groupBoxFilter_LSE.Controls.Add(comboBoxPosition_LSE);
            groupBoxFilter_LSE.Dock = DockStyle.Top;
            groupBoxFilter_LSE.Location = new Point(5, 345);
            groupBoxFilter_LSE.Margin = new Padding(0);
            groupBoxFilter_LSE.Name = "groupBoxFilter_LSE";
            groupBoxFilter_LSE.Padding = new Padding(5);
            groupBoxFilter_LSE.Size = new Size(210, 154);
            groupBoxFilter_LSE.TabIndex = 16;
            groupBoxFilter_LSE.TabStop = false;
            groupBoxFilter_LSE.Text = "Фильтрация";
            // 
            // buttonApplyFilters_LSE
            // 
            buttonApplyFilters_LSE.Cursor = Cursors.Hand;
            buttonApplyFilters_LSE.Dock = DockStyle.Bottom;
            buttonApplyFilters_LSE.Location = new Point(5, 114);
            buttonApplyFilters_LSE.Name = "buttonApplyFilters_LSE";
            buttonApplyFilters_LSE.Size = new Size(200, 35);
            buttonApplyFilters_LSE.TabIndex = 7;
            buttonApplyFilters_LSE.Text = "✅ Применить";
            buttonApplyFilters_LSE.UseVisualStyleBackColor = true;
            buttonApplyFilters_LSE.Click += buttonApplyFilter_Click;
            // 
            // labelDepartment_LSE
            // 
            labelDepartment_LSE.AutoSize = true;
            labelDepartment_LSE.Location = new Point(5, 63);
            labelDepartment_LSE.Name = "labelDepartment_LSE";
            labelDepartment_LSE.Size = new Size(40, 15);
            labelDepartment_LSE.TabIndex = 5;
            labelDepartment_LSE.Text = "Отдел";
            // 
            // comboBoxDepartment_LSE
            // 
            comboBoxDepartment_LSE.FormattingEnabled = true;
            comboBoxDepartment_LSE.Location = new Point(8, 81);
            comboBoxDepartment_LSE.Name = "comboBoxDepartment_LSE";
            comboBoxDepartment_LSE.Size = new Size(121, 23);
            comboBoxDepartment_LSE.TabIndex = 4;
            // 
            // labelPosition_LSE
            // 
            labelPosition_LSE.AutoSize = true;
            labelPosition_LSE.Location = new Point(8, 19);
            labelPosition_LSE.Name = "labelPosition_LSE";
            labelPosition_LSE.Size = new Size(69, 15);
            labelPosition_LSE.TabIndex = 3;
            labelPosition_LSE.Text = "Должность";
            // 
            // comboBoxPosition_LSE
            // 
            comboBoxPosition_LSE.FormattingEnabled = true;
            comboBoxPosition_LSE.Location = new Point(8, 37);
            comboBoxPosition_LSE.Name = "comboBoxPosition_LSE";
            comboBoxPosition_LSE.Size = new Size(121, 23);
            comboBoxPosition_LSE.TabIndex = 2;
            // 
            // panelFillEdit_LSE
            // 
            panelFillEdit_LSE.Dock = DockStyle.Top;
            panelFillEdit_LSE.Location = new Point(5, 335);
            panelFillEdit_LSE.Name = "panelFillEdit_LSE";
            panelFillEdit_LSE.Size = new Size(210, 10);
            panelFillEdit_LSE.TabIndex = 15;
            // 
            // buttonHelp_LSE
            // 
            buttonHelp_LSE.BackColor = Color.White;
            buttonHelp_LSE.Cursor = Cursors.Help;
            buttonHelp_LSE.Dock = DockStyle.Bottom;
            buttonHelp_LSE.Location = new Point(5, 626);
            buttonHelp_LSE.Name = "buttonHelp_LSE";
            buttonHelp_LSE.Size = new Size(210, 50);
            buttonHelp_LSE.TabIndex = 13;
            buttonHelp_LSE.Text = "❔ Справка";
            buttonHelp_LSE.UseVisualStyleBackColor = false;
            buttonHelp_LSE.Click += buttonHelp_LSE_Click;
            // 
            // groupBoxEdit_LSE
            // 
            groupBoxEdit_LSE.Controls.Add(buttonDelete_LSE);
            groupBoxEdit_LSE.Controls.Add(buttonAdd_LSE);
            groupBoxEdit_LSE.Dock = DockStyle.Top;
            groupBoxEdit_LSE.Location = new Point(5, 235);
            groupBoxEdit_LSE.Margin = new Padding(0);
            groupBoxEdit_LSE.Name = "groupBoxEdit_LSE";
            groupBoxEdit_LSE.Padding = new Padding(5);
            groupBoxEdit_LSE.Size = new Size(210, 100);
            groupBoxEdit_LSE.TabIndex = 12;
            groupBoxEdit_LSE.TabStop = false;
            groupBoxEdit_LSE.Text = "Редактирование";
            // 
            // buttonDelete_LSE
            // 
            buttonDelete_LSE.Cursor = Cursors.Hand;
            buttonDelete_LSE.Dock = DockStyle.Top;
            buttonDelete_LSE.Location = new Point(5, 56);
            buttonDelete_LSE.Name = "buttonDelete_LSE";
            buttonDelete_LSE.Size = new Size(200, 35);
            buttonDelete_LSE.TabIndex = 1;
            buttonDelete_LSE.Text = "- Удалить";
            buttonDelete_LSE.UseVisualStyleBackColor = true;
            buttonDelete_LSE.Click += buttonDelete_LSE_Click;
            // 
            // buttonAdd_LSE
            // 
            buttonAdd_LSE.Cursor = Cursors.Hand;
            buttonAdd_LSE.Dock = DockStyle.Top;
            buttonAdd_LSE.Location = new Point(5, 21);
            buttonAdd_LSE.Name = "buttonAdd_LSE";
            buttonAdd_LSE.Size = new Size(200, 35);
            buttonAdd_LSE.TabIndex = 0;
            buttonAdd_LSE.Text = "+ Добавить";
            buttonAdd_LSE.UseVisualStyleBackColor = true;
            buttonAdd_LSE.Click += buttonAdd_LSE_Click;
            // 
            // panelFillSearch_LSE
            // 
            panelFillSearch_LSE.Dock = DockStyle.Top;
            panelFillSearch_LSE.Location = new Point(5, 225);
            panelFillSearch_LSE.Name = "panelFillSearch_LSE";
            panelFillSearch_LSE.Size = new Size(210, 10);
            panelFillSearch_LSE.TabIndex = 11;
            // 
            // groupBoxSearch_LSE
            // 
            groupBoxSearch_LSE.Controls.Add(buttonSearch_LSE);
            groupBoxSearch_LSE.Controls.Add(panelFillSearchBox_LSE);
            groupBoxSearch_LSE.Controls.Add(textBoxSearch_LSE);
            groupBoxSearch_LSE.Dock = DockStyle.Top;
            groupBoxSearch_LSE.Location = new Point(5, 125);
            groupBoxSearch_LSE.Name = "groupBoxSearch_LSE";
            groupBoxSearch_LSE.Padding = new Padding(5);
            groupBoxSearch_LSE.Size = new Size(210, 100);
            groupBoxSearch_LSE.TabIndex = 10;
            groupBoxSearch_LSE.TabStop = false;
            groupBoxSearch_LSE.Text = "Поиск";
            // 
            // buttonSearch_LSE
            // 
            buttonSearch_LSE.Cursor = Cursors.Hand;
            buttonSearch_LSE.Dock = DockStyle.Top;
            buttonSearch_LSE.Location = new Point(5, 54);
            buttonSearch_LSE.Name = "buttonSearch_LSE";
            buttonSearch_LSE.Size = new Size(200, 35);
            buttonSearch_LSE.TabIndex = 6;
            buttonSearch_LSE.Text = "🔍 Найти";
            buttonSearch_LSE.UseVisualStyleBackColor = true;
            buttonSearch_LSE.Click += buttonSearch_LSE_Click;
            // 
            // panelFillSearchBox_LSE
            // 
            panelFillSearchBox_LSE.Dock = DockStyle.Top;
            panelFillSearchBox_LSE.Location = new Point(5, 44);
            panelFillSearchBox_LSE.Name = "panelFillSearchBox_LSE";
            panelFillSearchBox_LSE.Size = new Size(200, 10);
            panelFillSearchBox_LSE.TabIndex = 5;
            // 
            // textBoxSearch_LSE
            // 
            textBoxSearch_LSE.Cursor = Cursors.IBeam;
            textBoxSearch_LSE.Dock = DockStyle.Top;
            textBoxSearch_LSE.Location = new Point(5, 21);
            textBoxSearch_LSE.Name = "textBoxSearch_LSE";
            textBoxSearch_LSE.Size = new Size(200, 23);
            textBoxSearch_LSE.TabIndex = 0;
            // 
            // panelFillSave_LSE
            // 
            panelFillSave_LSE.Dock = DockStyle.Top;
            panelFillSave_LSE.Location = new Point(5, 115);
            panelFillSave_LSE.Name = "panelFillSave_LSE";
            panelFillSave_LSE.Size = new Size(210, 10);
            panelFillSave_LSE.TabIndex = 9;
            // 
            // buttonSaveFile_LSE
            // 
            buttonSaveFile_LSE.BackColor = Color.White;
            buttonSaveFile_LSE.Cursor = Cursors.Hand;
            buttonSaveFile_LSE.Dock = DockStyle.Top;
            buttonSaveFile_LSE.Location = new Point(5, 65);
            buttonSaveFile_LSE.Name = "buttonSaveFile_LSE";
            buttonSaveFile_LSE.Size = new Size(210, 50);
            buttonSaveFile_LSE.TabIndex = 8;
            buttonSaveFile_LSE.Text = "💾 Сохранить";
            buttonSaveFile_LSE.UseVisualStyleBackColor = false;
            buttonSaveFile_LSE.Click += buttonSaveFile_LSE_Click;
            // 
            // panelFillOpen_LSE
            // 
            panelFillOpen_LSE.Dock = DockStyle.Top;
            panelFillOpen_LSE.Location = new Point(5, 55);
            panelFillOpen_LSE.Name = "panelFillOpen_LSE";
            panelFillOpen_LSE.Size = new Size(210, 10);
            panelFillOpen_LSE.TabIndex = 7;
            // 
            // buttonOpenFile_LSE
            // 
            buttonOpenFile_LSE.BackColor = Color.White;
            buttonOpenFile_LSE.Cursor = Cursors.Hand;
            buttonOpenFile_LSE.Dock = DockStyle.Top;
            buttonOpenFile_LSE.Location = new Point(5, 5);
            buttonOpenFile_LSE.Name = "buttonOpenFile_LSE";
            buttonOpenFile_LSE.Size = new Size(210, 50);
            buttonOpenFile_LSE.TabIndex = 6;
            buttonOpenFile_LSE.Text = "📂 Открыть";
            buttonOpenFile_LSE.UseVisualStyleBackColor = false;
            buttonOpenFile_LSE.Click += buttonOpenFile_LSE_Click;
            // 
            // panelRight_LSE
            // 
            panelRight_LSE.BackColor = Color.WhiteSmoke;
            panelRight_LSE.Controls.Add(chartDiag_LSE);
            panelRight_LSE.Controls.Add(panelStat_LSE);
            panelRight_LSE.Dock = DockStyle.Right;
            panelRight_LSE.Location = new Point(764, 0);
            panelRight_LSE.Name = "panelRight_LSE";
            panelRight_LSE.Padding = new Padding(5);
            panelRight_LSE.Size = new Size(500, 681);
            panelRight_LSE.TabIndex = 2;
            // 
            // chartDiag_LSE
            // 
            chartDiag_LSE.Dock = DockStyle.Fill;
            chartDiag_LSE.Location = new Point(5, 105);
            chartDiag_LSE.Name = "chartDiag_LSE";
            chartDiag_LSE.PanCursor = Cursors.Hand;
            chartDiag_LSE.Size = new Size(490, 571);
            chartDiag_LSE.TabIndex = 6;
            chartDiag_LSE.Text = "plotView1";
            chartDiag_LSE.ZoomHorizontalCursor = Cursors.SizeWE;
            chartDiag_LSE.ZoomRectangleCursor = Cursors.SizeNWSE;
            chartDiag_LSE.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // panelStat_LSE
            // 
            panelStat_LSE.Controls.Add(buttonSaveStat_LSE);
            panelStat_LSE.Controls.Add(groupBoxStats_LSE);
            panelStat_LSE.Dock = DockStyle.Top;
            panelStat_LSE.Location = new Point(5, 5);
            panelStat_LSE.Name = "panelStat_LSE";
            panelStat_LSE.Size = new Size(490, 100);
            panelStat_LSE.TabIndex = 5;
            // 
            // buttonSaveStat_LSE
            // 
            buttonSaveStat_LSE.BackColor = Color.White;
            buttonSaveStat_LSE.Cursor = Cursors.Hand;
            buttonSaveStat_LSE.Dock = DockStyle.Right;
            buttonSaveStat_LSE.Location = new Point(390, 0);
            buttonSaveStat_LSE.Name = "buttonSaveStat_LSE";
            buttonSaveStat_LSE.Size = new Size(100, 100);
            buttonSaveStat_LSE.TabIndex = 9;
            buttonSaveStat_LSE.Text = "💾 Экспорт";
            buttonSaveStat_LSE.UseVisualStyleBackColor = false;
            buttonSaveStat_LSE.Click += buttonSaveStat_LSE_Click;
            // 
            // groupBoxStats_LSE
            // 
            groupBoxStats_LSE.Controls.Add(labelStats_LSE);
            groupBoxStats_LSE.Dock = DockStyle.Left;
            groupBoxStats_LSE.Location = new Point(0, 0);
            groupBoxStats_LSE.Name = "groupBoxStats_LSE";
            groupBoxStats_LSE.Size = new Size(400, 100);
            groupBoxStats_LSE.TabIndex = 5;
            groupBoxStats_LSE.TabStop = false;
            groupBoxStats_LSE.Text = "Статистика";
            // 
            // labelStats_LSE
            // 
            labelStats_LSE.AutoSize = true;
            labelStats_LSE.Location = new Point(6, 19);
            labelStats_LSE.Name = "labelStats_LSE";
            labelStats_LSE.Size = new Size(0, 15);
            labelStats_LSE.TabIndex = 7;
            // 
            // panelFill_LSE
            // 
            panelFill_LSE.Controls.Add(dataGridViewOut_LSE);
            panelFill_LSE.Dock = DockStyle.Fill;
            panelFill_LSE.Location = new Point(220, 0);
            panelFill_LSE.Name = "panelFill_LSE";
            panelFill_LSE.Padding = new Padding(5);
            panelFill_LSE.Size = new Size(544, 681);
            panelFill_LSE.TabIndex = 3;
            // 
            // dataGridViewOut_LSE
            // 
            dataGridViewOut_LSE.AllowUserToOrderColumns = true;
            dataGridViewOut_LSE.BackgroundColor = Color.White;
            dataGridViewOut_LSE.BorderStyle = BorderStyle.None;
            dataGridViewOut_LSE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_LSE.Dock = DockStyle.Fill;
            dataGridViewOut_LSE.Location = new Point(5, 5);
            dataGridViewOut_LSE.MultiSelect = false;
            dataGridViewOut_LSE.Name = "dataGridViewOut_LSE";
            dataGridViewOut_LSE.RowHeadersVisible = false;
            dataGridViewOut_LSE.Size = new Size(534, 671);
            dataGridViewOut_LSE.TabIndex = 0;
            dataGridViewOut_LSE.CellEndEdit += dataGridViewOut_LSE_CellEndEdit;
            // 
            // openFileDialog_LSE
            // 
            openFileDialog_LSE.Filter = "CSV files|*.csv";
            // 
            // saveFileDialog_LSE
            // 
            saveFileDialog_LSE.Filter = "CSV files|*.csv";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1264, 681);
            Controls.Add(panelFill_LSE);
            Controls.Add(panelRight_LSE);
            Controls.Add(panelLeft_LSE);
            MinimumSize = new Size(1280, 720);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 7 | Вариант 11 | Отдел кадров | Ляпин C.E.";
            panelLeft_LSE.ResumeLayout(false);
            groupBoxFilter_LSE.ResumeLayout(false);
            groupBoxFilter_LSE.PerformLayout();
            groupBoxEdit_LSE.ResumeLayout(false);
            groupBoxSearch_LSE.ResumeLayout(false);
            groupBoxSearch_LSE.PerformLayout();
            panelRight_LSE.ResumeLayout(false);
            panelStat_LSE.ResumeLayout(false);
            groupBoxStats_LSE.ResumeLayout(false);
            groupBoxStats_LSE.PerformLayout();
            panelFill_LSE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_LSE).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelLeft_LSE;
        private Panel panelRight_LSE;
        private Panel panelFill_LSE;
        private DataGridView dataGridViewOut_LSE;
        private GroupBox groupBoxEdit_LSE;
        private Button buttonDelete_LSE;
        private Button buttonAdd_LSE;
        private Panel panelFillSearch_LSE;
        private GroupBox groupBoxSearch_LSE;
        private Button buttonSearch_LSE;
        private Panel panelFillSearchBox_LSE;
        private TextBox textBoxSearch_LSE;
        private Panel panelFillSave_LSE;
        private Button buttonSaveFile_LSE;
        private Panel panelFillOpen_LSE;
        private Button buttonOpenFile_LSE;
        private Button buttonHelp_LSE;
        private OpenFileDialog openFileDialog_LSE;
        private SaveFileDialog saveFileDialog_LSE;
        private ToolTip toolTip_LSE;
        private OxyPlot.WindowsForms.PlotView chartDiag_LSE;
        private Panel panelStat_LSE;
        private Button buttonSaveStat_LSE;
        private GroupBox groupBoxFilter_LSE;
        private Panel panelFillEdit_LSE;
        private ComboBox comboBoxPosition_LSE;
        private Label labelPosition_LSE;
        private Label labelDepartment_LSE;
        private ComboBox comboBoxDepartment_LSE;
        private Button buttonApplyFilters_LSE;
        private GroupBox groupBoxStats_LSE;
        private Label labelStats_LSE;
    }
}
