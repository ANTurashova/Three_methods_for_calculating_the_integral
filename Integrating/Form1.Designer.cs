namespace Integrating {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.LowerBoundRectVal = new System.Windows.Forms.NumericUpDown();
            this.UpperBoundRectVal = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ThrowsMultMonteVal = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.NumStratsMonteVal = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.SupremumMonteVal = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.InfimumMonteVal = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerBoundRectVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpperBoundRectVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThrowsMultMonteVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumStratsMonteVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupremumMonteVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfimumMonteVal)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(13, 158);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "f(x)";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(856, 398);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Прямоугольники",
            "Метод Симпсона",
            "Метод Монте-Карло"});
            this.comboBox1.Location = new System.Drawing.Point(13, 13);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Прямоугольники";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 110);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(438, 10);
            this.progressBar1.TabIndex = 2;
            // 
            // LowerBoundRectVal
            // 
            this.LowerBoundRectVal.Location = new System.Drawing.Point(237, 45);
            this.LowerBoundRectVal.Margin = new System.Windows.Forms.Padding(4);
            this.LowerBoundRectVal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.LowerBoundRectVal.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.LowerBoundRectVal.Name = "LowerBoundRectVal";
            this.LowerBoundRectVal.Size = new System.Drawing.Size(95, 22);
            this.LowerBoundRectVal.TabIndex = 8;
            this.LowerBoundRectVal.Value = new decimal(new int[] {
            12,
            0,
            0,
            -2147483648});
            // 
            // UpperBoundRectVal
            // 
            this.UpperBoundRectVal.Location = new System.Drawing.Point(237, 15);
            this.UpperBoundRectVal.Margin = new System.Windows.Forms.Padding(4);
            this.UpperBoundRectVal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.UpperBoundRectVal.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.UpperBoundRectVal.Name = "UpperBoundRectVal";
            this.UpperBoundRectVal.Size = new System.Drawing.Size(94, 22);
            this.UpperBoundRectVal.TabIndex = 7;
            this.UpperBoundRectVal.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Верхний предел";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Нижний предел";
            // 
            // ThrowsMultMonteVal
            // 
            this.ThrowsMultMonteVal.Location = new System.Drawing.Point(610, 96);
            this.ThrowsMultMonteVal.Margin = new System.Windows.Forms.Padding(4);
            this.ThrowsMultMonteVal.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ThrowsMultMonteVal.Name = "ThrowsMultMonteVal";
            this.ThrowsMultMonteVal.Size = new System.Drawing.Size(95, 22);
            this.ThrowsMultMonteVal.TabIndex = 17;
            this.ThrowsMultMonteVal.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(713, 98);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Частота точек";
            // 
            // NumStratsMonteVal
            // 
            this.NumStratsMonteVal.Location = new System.Drawing.Point(237, 75);
            this.NumStratsMonteVal.Margin = new System.Windows.Forms.Padding(4);
            this.NumStratsMonteVal.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumStratsMonteVal.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumStratsMonteVal.Name = "NumStratsMonteVal";
            this.NumStratsMonteVal.Size = new System.Drawing.Size(94, 22);
            this.NumStratsMonteVal.TabIndex = 15;
            this.NumStratsMonteVal.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Разбиение поля";
            // 
            // SupremumMonteVal
            // 
            this.SupremumMonteVal.Location = new System.Drawing.Point(610, 36);
            this.SupremumMonteVal.Margin = new System.Windows.Forms.Padding(4);
            this.SupremumMonteVal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.SupremumMonteVal.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.SupremumMonteVal.Name = "SupremumMonteVal";
            this.SupremumMonteVal.Size = new System.Drawing.Size(95, 22);
            this.SupremumMonteVal.TabIndex = 13;
            this.SupremumMonteVal.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(713, 38);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Верхняя граница точек";
            // 
            // InfimumMonteVal
            // 
            this.InfimumMonteVal.Location = new System.Drawing.Point(610, 66);
            this.InfimumMonteVal.Margin = new System.Windows.Forms.Padding(4);
            this.InfimumMonteVal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.InfimumMonteVal.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.InfimumMonteVal.Name = "InfimumMonteVal";
            this.InfimumMonteVal.Size = new System.Drawing.Size(95, 22);
            this.InfimumMonteVal.TabIndex = 11;
            this.InfimumMonteVal.Value = new decimal(new int[] {
            300,
            0,
            0,
            -2147483648});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(713, 68);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Нижняя граница точек";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Location = new System.Drawing.Point(13, 45);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Посчитать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(322, 128);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(132, 22);
            this.textBoxResult.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(150, 131);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 17);
            this.label14.TabIndex = 7;
            this.label14.Text = "--------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Затраченное время:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ответ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(607, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Настройки для метода Монте-Карло:";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(882, 569);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UpperBoundRectVal);
            this.Controls.Add(this.LowerBoundRectVal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NumStratsMonteVal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ThrowsMultMonteVal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.InfimumMonteVal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SupremumMonteVal);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 616);
            this.MinimumSize = new System.Drawing.Size(900, 616);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "x^3+10x^2";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerBoundRectVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpperBoundRectVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThrowsMultMonteVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumStratsMonteVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupremumMonteVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfimumMonteVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown LowerBoundRectVal;
        private System.Windows.Forms.NumericUpDown UpperBoundRectVal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown SupremumMonteVal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown InfimumMonteVal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown ThrowsMultMonteVal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown NumStratsMonteVal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}

