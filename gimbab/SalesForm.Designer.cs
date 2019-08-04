namespace gimbab
{
    partial class SalesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Table = new System.Windows.Forms.Button();
            this.btn_Category = new System.Windows.Forms.Button();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.chart_Sales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Chartpanel = new System.Windows.Forms.Panel();
            this.btn_Sales = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Sales)).BeginInit();
            this.Chartpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.White;
            this.btn_Back.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Back.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btn_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("문체부 훈민정음체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Back.Location = new System.Drawing.Point(499, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(70, 45);
            this.btn_Back.TabIndex = 6;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Table
            // 
            this.btn_Table.BackColor = System.Drawing.Color.White;
            this.btn_Table.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Table.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btn_Table.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_Table.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Table.Font = new System.Drawing.Font("문체부 훈민정음체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Table.Location = new System.Drawing.Point(73, 12);
            this.btn_Table.Name = "btn_Table";
            this.btn_Table.Size = new System.Drawing.Size(70, 45);
            this.btn_Table.TabIndex = 2;
            this.btn_Table.Text = "Table";
            this.btn_Table.UseVisualStyleBackColor = false;
            this.btn_Table.Click += new System.EventHandler(this.ChartButton);
            // 
            // btn_Category
            // 
            this.btn_Category.BackColor = System.Drawing.Color.White;
            this.btn_Category.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Category.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btn_Category.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_Category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Category.Font = new System.Drawing.Font("문체부 훈민정음체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Category.Location = new System.Drawing.Point(145, 12);
            this.btn_Category.Name = "btn_Category";
            this.btn_Category.Size = new System.Drawing.Size(85, 45);
            this.btn_Category.TabIndex = 3;
            this.btn_Category.Text = "Category";
            this.btn_Category.UseVisualStyleBackColor = false;
            this.btn_Category.Click += new System.EventHandler(this.ChartButton);
            // 
            // btn_Menu
            // 
            this.btn_Menu.BackColor = System.Drawing.Color.White;
            this.btn_Menu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Menu.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btn_Menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu.Font = new System.Drawing.Font("문체부 훈민정음체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Menu.Location = new System.Drawing.Point(232, 12);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(60, 45);
            this.btn_Menu.TabIndex = 4;
            this.btn_Menu.Text = "Menu";
            this.btn_Menu.UseVisualStyleBackColor = false;
            this.btn_Menu.Click += new System.EventHandler(this.ChartButton);
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(295, 22);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(200, 25);
            this.DatePicker.TabIndex = 5;
            this.DatePicker.ValueChanged += new System.EventHandler(this.DatePicker_ValueChanged);
            // 
            // chart_Sales
            // 
            chartArea4.AxisX.Maximum = 5D;
            chartArea4.AxisX.ScrollBar.BackColor = System.Drawing.Color.White;
            chartArea4.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.Black;
            chartArea4.AxisX.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.ResetZoom;
            chartArea4.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea4.AxisX.ScrollBar.Size = 20D;
            chartArea4.Name = "ChartArea1";
            this.chart_Sales.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart_Sales.Legends.Add(legend4);
            this.chart_Sales.Location = new System.Drawing.Point(-1, 3);
            this.chart_Sales.Name = "chart_Sales";
            this.chart_Sales.Size = new System.Drawing.Size(560, 459);
            this.chart_Sales.TabIndex = 0;
            this.chart_Sales.Text = "chart1";
            // 
            // Chartpanel
            // 
            this.Chartpanel.Controls.Add(this.chart_Sales);
            this.Chartpanel.Location = new System.Drawing.Point(12, 67);
            this.Chartpanel.Name = "Chartpanel";
            this.Chartpanel.Size = new System.Drawing.Size(560, 468);
            this.Chartpanel.TabIndex = 4;
            // 
            // btn_Sales
            // 
            this.btn_Sales.BackColor = System.Drawing.Color.White;
            this.btn_Sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sales.Font = new System.Drawing.Font("문체부 훈민정음체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Sales.Location = new System.Drawing.Point(6, 12);
            this.btn_Sales.Name = "btn_Sales";
            this.btn_Sales.Size = new System.Drawing.Size(65, 45);
            this.btn_Sales.TabIndex = 1;
            this.btn_Sales.Text = "Sales";
            this.btn_Sales.UseVisualStyleBackColor = false;
            this.btn_Sales.Click += new System.EventHandler(this.ChartButton);
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(584, 541);
            this.Controls.Add(this.btn_Sales);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.Chartpanel);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.btn_Category);
            this.Controls.Add(this.btn_Table);
            this.Controls.Add(this.btn_Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Sales)).EndInit();
            this.Chartpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Table;
        private System.Windows.Forms.Button btn_Category;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Sales;
        private System.Windows.Forms.Panel Chartpanel;
        private System.Windows.Forms.Button btn_Sales;
    }
}