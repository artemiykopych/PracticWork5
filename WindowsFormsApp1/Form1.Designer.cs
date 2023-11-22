namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.роботаЗМасивамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.одновимірніМасивиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.двовимірніМасивиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.практичнаРобота4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.практичнаРобота5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.інтерфейсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "3,35";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(175, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 31);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "36,26";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(321, 104);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 31);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "0,2";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(456, 104);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 31);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "0,8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Xn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Xk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "h";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "a";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.y});
            this.dataGridView1.Location = new System.Drawing.Point(45, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(339, 375);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // x
            // 
            this.x.HeaderText = "x";
            this.x.MinimumWidth = 10;
            this.x.Name = "x";
            this.x.Width = 200;
            // 
            // y
            // 
            this.y.HeaderText = "y";
            this.y.MinimumWidth = 10;
            this.y.Name = "y";
            this.y.Width = 200;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(456, 179);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(822, 422);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(617, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Обрахувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.роботаЗМасивамиToolStripMenuItem,
            this.практичнаРобота4ToolStripMenuItem,
            this.практичнаРобота5ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1290, 48);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // роботаЗМасивамиToolStripMenuItem
            // 
            this.роботаЗМасивамиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.одновимірніМасивиToolStripMenuItem,
            this.двовимірніМасивиToolStripMenuItem});
            this.роботаЗМасивамиToolStripMenuItem.Name = "роботаЗМасивамиToolStripMenuItem";
            this.роботаЗМасивамиToolStripMenuItem.Size = new System.Drawing.Size(246, 38);
            this.роботаЗМасивамиToolStripMenuItem.Text = "Робота з масивами";
            // 
            // одновимірніМасивиToolStripMenuItem
            // 
            this.одновимірніМасивиToolStripMenuItem.Name = "одновимірніМасивиToolStripMenuItem";
            this.одновимірніМасивиToolStripMenuItem.Size = new System.Drawing.Size(378, 44);
            this.одновимірніМасивиToolStripMenuItem.Text = "Одновимірні масиви";
            this.одновимірніМасивиToolStripMenuItem.Click += new System.EventHandler(this.одновимірніМасивиToolStripMenuItem_Click);
            // 
            // двовимірніМасивиToolStripMenuItem
            // 
            this.двовимірніМасивиToolStripMenuItem.Name = "двовимірніМасивиToolStripMenuItem";
            this.двовимірніМасивиToolStripMenuItem.Size = new System.Drawing.Size(378, 44);
            this.двовимірніМасивиToolStripMenuItem.Text = "Двовимірні масиви";
            this.двовимірніМасивиToolStripMenuItem.Click += new System.EventHandler(this.двовимірніМасивиToolStripMenuItem_Click);
            // 
            // практичнаРобота4ToolStripMenuItem
            // 
            this.практичнаРобота4ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлиToolStripMenuItem});
            this.практичнаРобота4ToolStripMenuItem.Name = "практичнаРобота4ToolStripMenuItem";
            this.практичнаРобота4ToolStripMenuItem.Size = new System.Drawing.Size(257, 38);
            this.практичнаРобота4ToolStripMenuItem.Text = "Практична Робота 4";
            // 
            // файлиToolStripMenuItem
            // 
            this.файлиToolStripMenuItem.Name = "файлиToolStripMenuItem";
            this.файлиToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.файлиToolStripMenuItem.Text = "Файли";
            this.файлиToolStripMenuItem.Click += new System.EventHandler(this.файлиToolStripMenuItem_Click);
            // 
            // практичнаРобота5ToolStripMenuItem
            // 
            this.практичнаРобота5ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.інтерфейсToolStripMenuItem});
            this.практичнаРобота5ToolStripMenuItem.Name = "практичнаРобота5ToolStripMenuItem";
            this.практичнаРобота5ToolStripMenuItem.Size = new System.Drawing.Size(257, 44);
            this.практичнаРобота5ToolStripMenuItem.Text = "Практична Робота 5";
            // 
            // інтерфейсToolStripMenuItem
            // 
            this.інтерфейсToolStripMenuItem.Name = "інтерфейсToolStripMenuItem";
            this.інтерфейсToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.інтерфейсToolStripMenuItem.Text = "Стандартні інтерфейси";
            this.інтерфейсToolStripMenuItem.Click += new System.EventHandler(this.інтерфейсToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 651);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem роботаЗМасивамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem одновимірніМасивиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem двовимірніМасивиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem практичнаРобота4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem практичнаРобота5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem інтерфейсToolStripMenuItem;
    }
}

