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
            buttonHelp_LSE = new Button();
            groupBoxEdit_LSE = new GroupBox();
            buttonDelete_LSE = new Button();
            buttonAdd_LSE = new Button();
            panelFill2_LSE = new Panel();
            groupBoxFilter_LSE = new GroupBox();
            buttonSearch_LSE = new Button();
            panel3 = new Panel();
            textBoxSearch_LSE = new TextBox();
            panelFill1_LSE = new Panel();
            buttonSaveFile_LSE = new Button();
            panel4 = new Panel();
            buttonOpenFile_LSE = new Button();
            panelRight_LSE = new Panel();
            chartDiag_LSE = new OxyPlot.WindowsForms.PlotView();
            panel1 = new Panel();
            buttonSaveStat_LSE = new Button();
            groupBoxStats_LSE = new GroupBox();
            labelStats_LSE = new Label();
            label1 = new Label();
            panelFill_LSE = new Panel();
            dataGridViewOut_LSE = new DataGridView();
            openFileDialog_LSE = new OpenFileDialog();
            saveFileDialog_LSE = new SaveFileDialog();
            toolTip_LSE = new ToolTip(components);
            panelLeft_LSE.SuspendLayout();
            groupBoxEdit_LSE.SuspendLayout();
            groupBoxFilter_LSE.SuspendLayout();
            panelRight_LSE.SuspendLayout();
            panel1.SuspendLayout();
            groupBoxStats_LSE.SuspendLayout();
            panelFill_LSE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_LSE).BeginInit();
            SuspendLayout();
            // 
            // panelLeft_LSE
            // 
            panelLeft_LSE.BackColor = Color.WhiteSmoke;
            panelLeft_LSE.Controls.Add(buttonHelp_LSE);
            panelLeft_LSE.Controls.Add(groupBoxEdit_LSE);
            panelLeft_LSE.Controls.Add(panelFill2_LSE);
            panelLeft_LSE.Controls.Add(groupBoxFilter_LSE);
            panelLeft_LSE.Controls.Add(panelFill1_LSE);
            panelLeft_LSE.Controls.Add(buttonSaveFile_LSE);
            panelLeft_LSE.Controls.Add(panel4);
            panelLeft_LSE.Controls.Add(buttonOpenFile_LSE);
            panelLeft_LSE.Dock = DockStyle.Left;
            panelLeft_LSE.Location = new Point(0, 0);
            panelLeft_LSE.Name = "panelLeft_LSE";
            panelLeft_LSE.Padding = new Padding(5);
            panelLeft_LSE.Size = new Size(220, 681);
            panelLeft_LSE.TabIndex = 1;
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
            // panelFill2_LSE
            // 
            panelFill2_LSE.Dock = DockStyle.Top;
            panelFill2_LSE.Location = new Point(5, 225);
            panelFill2_LSE.Name = "panelFill2_LSE";
            panelFill2_LSE.Size = new Size(210, 10);
            panelFill2_LSE.TabIndex = 11;
            // 
            // groupBoxFilter_LSE
            // 
            groupBoxFilter_LSE.Controls.Add(buttonSearch_LSE);
            groupBoxFilter_LSE.Controls.Add(panel3);
            groupBoxFilter_LSE.Controls.Add(textBoxSearch_LSE);
            groupBoxFilter_LSE.Dock = DockStyle.Top;
            groupBoxFilter_LSE.Location = new Point(5, 125);
            groupBoxFilter_LSE.Name = "groupBoxFilter_LSE";
            groupBoxFilter_LSE.Padding = new Padding(5);
            groupBoxFilter_LSE.Size = new Size(210, 100);
            groupBoxFilter_LSE.TabIndex = 10;
            groupBoxFilter_LSE.TabStop = false;
            groupBoxFilter_LSE.Text = "Поиск";
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
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(5, 44);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 10);
            panel3.TabIndex = 5;
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
            // panelFill1_LSE
            // 
            panelFill1_LSE.Dock = DockStyle.Top;
            panelFill1_LSE.Location = new Point(5, 115);
            panelFill1_LSE.Name = "panelFill1_LSE";
            panelFill1_LSE.Size = new Size(210, 10);
            panelFill1_LSE.TabIndex = 9;
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
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(5, 55);
            panel4.Name = "panel4";
            panel4.Size = new Size(210, 10);
            panel4.TabIndex = 7;
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
            panelRight_LSE.Controls.Add(panel1);
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
            // panel1
            // 
            panel1.Controls.Add(buttonSaveStat_LSE);
            panel1.Controls.Add(groupBoxStats_LSE);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 100);
            panel1.TabIndex = 5;
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
            groupBoxStats_LSE.Controls.Add(label1);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 74);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 6;
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
            dataGridViewOut_LSE.BackgroundColor = Color.White;
            dataGridViewOut_LSE.BorderStyle = BorderStyle.None;
            dataGridViewOut_LSE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_LSE.Dock = DockStyle.Fill;
            dataGridViewOut_LSE.Location = new Point(5, 5);
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
            groupBoxEdit_LSE.ResumeLayout(false);
            groupBoxFilter_LSE.ResumeLayout(false);
            groupBoxFilter_LSE.PerformLayout();
            panelRight_LSE.ResumeLayout(false);
            panel1.ResumeLayout(false);
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
        private Panel panelFill2_LSE;
        private GroupBox groupBoxFilter_LSE;
        private Button buttonSearch_LSE;
        private Panel panel3;
        private TextBox textBoxSearch_LSE;
        private Panel panelFill1_LSE;
        private Button buttonSaveFile_LSE;
        private Panel panel4;
        private Button buttonOpenFile_LSE;
        private Button buttonHelp_LSE;
        private OpenFileDialog openFileDialog_LSE;
        private SaveFileDialog saveFileDialog_LSE;
        private ToolTip toolTip_LSE;
        private OxyPlot.WindowsForms.PlotView chartDiag_LSE;
        private Panel panel1;
        private Button buttonSaveStat_LSE;
        private GroupBox groupBoxStats_LSE;
        private Label labelStats_LSE;
        private Label label1;
    }
}
