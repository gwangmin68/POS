namespace gimbab
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Table1 = new System.Windows.Forms.Button();
            this.Table2 = new System.Windows.Forms.Button();
            this.Table3 = new System.Windows.Forms.Button();
            this.Table4 = new System.Windows.Forms.Button();
            this.Table5 = new System.Windows.Forms.Button();
            this.Table6 = new System.Windows.Forms.Button();
            this.LocalTime = new System.Windows.Forms.Label();
            this.LocalTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_sales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Table1
            // 
            this.Table1.BackColor = System.Drawing.Color.White;
            this.Table1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Table1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.Table1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Table1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Table1.Font = new System.Drawing.Font("문체부 훈민정음체", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Table1.Location = new System.Drawing.Point(0, 100);
            this.Table1.Name = "Table1";
            this.Table1.Size = new System.Drawing.Size(200, 200);
            this.Table1.TabIndex = 3;
            this.Table1.Tag = "1";
            this.Table1.Text = "Table1";
            this.Table1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Table1.UseVisualStyleBackColor = false;
            this.Table1.Click += new System.EventHandler(this.TableButton_Click);
            // 
            // Table2
            // 
            this.Table2.BackColor = System.Drawing.Color.White;
            this.Table2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Table2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.Table2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Table2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Table2.Font = new System.Drawing.Font("문체부 훈민정음체", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Table2.Location = new System.Drawing.Point(200, 100);
            this.Table2.Name = "Table2";
            this.Table2.Size = new System.Drawing.Size(200, 200);
            this.Table2.TabIndex = 4;
            this.Table2.Tag = "2";
            this.Table2.Text = "Table2";
            this.Table2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Table2.UseVisualStyleBackColor = false;
            this.Table2.Click += new System.EventHandler(this.TableButton_Click);
            // 
            // Table3
            // 
            this.Table3.BackColor = System.Drawing.Color.White;
            this.Table3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Table3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.Table3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Table3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Table3.Font = new System.Drawing.Font("문체부 훈민정음체", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Table3.Location = new System.Drawing.Point(400, 100);
            this.Table3.Name = "Table3";
            this.Table3.Size = new System.Drawing.Size(200, 200);
            this.Table3.TabIndex = 5;
            this.Table3.Tag = "3";
            this.Table3.Text = "Table3";
            this.Table3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Table3.UseVisualStyleBackColor = false;
            this.Table3.Click += new System.EventHandler(this.TableButton_Click);
            // 
            // Table4
            // 
            this.Table4.BackColor = System.Drawing.Color.White;
            this.Table4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Table4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.Table4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Table4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Table4.Font = new System.Drawing.Font("문체부 훈민정음체", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Table4.Location = new System.Drawing.Point(0, 300);
            this.Table4.Name = "Table4";
            this.Table4.Size = new System.Drawing.Size(200, 200);
            this.Table4.TabIndex = 6;
            this.Table4.Tag = "4";
            this.Table4.Text = "Table4";
            this.Table4.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Table4.UseVisualStyleBackColor = false;
            this.Table4.Click += new System.EventHandler(this.TableButton_Click);
            // 
            // Table5
            // 
            this.Table5.BackColor = System.Drawing.Color.White;
            this.Table5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Table5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.Table5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Table5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Table5.Font = new System.Drawing.Font("문체부 훈민정음체", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Table5.Location = new System.Drawing.Point(200, 300);
            this.Table5.Name = "Table5";
            this.Table5.Size = new System.Drawing.Size(200, 200);
            this.Table5.TabIndex = 7;
            this.Table5.Tag = "5";
            this.Table5.Text = "Table5";
            this.Table5.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Table5.UseVisualStyleBackColor = false;
            this.Table5.Click += new System.EventHandler(this.TableButton_Click);
            // 
            // Table6
            // 
            this.Table6.BackColor = System.Drawing.Color.White;
            this.Table6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Table6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.Table6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Table6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Table6.Font = new System.Drawing.Font("문체부 훈민정음체", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Table6.Location = new System.Drawing.Point(400, 300);
            this.Table6.Name = "Table6";
            this.Table6.Size = new System.Drawing.Size(200, 200);
            this.Table6.TabIndex = 8;
            this.Table6.Tag = "6";
            this.Table6.Text = "Table6";
            this.Table6.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Table6.UseVisualStyleBackColor = false;
            this.Table6.Click += new System.EventHandler(this.TableButton_Click);
            // 
            // LocalTime
            // 
            this.LocalTime.AutoSize = true;
            this.LocalTime.Font = new System.Drawing.Font("문체부 훈민정음체", 15F, System.Drawing.FontStyle.Bold);
            this.LocalTime.ForeColor = System.Drawing.Color.White;
            this.LocalTime.Location = new System.Drawing.Point(179, 61);
            this.LocalTime.Name = "LocalTime";
            this.LocalTime.Size = new System.Drawing.Size(0, 26);
            this.LocalTime.TabIndex = 3;
            this.LocalTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LocalTimer
            // 
            this.LocalTimer.Interval = 1000;
            this.LocalTimer.Tick += new System.EventHandler(this.LocalTimer_Tick);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.White;
            this.btn_Close.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Close.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("문체부 훈민정음체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Close.Location = new System.Drawing.Point(503, 9);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(90, 40);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "종료";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // btn_sales
            // 
            this.btn_sales.BackColor = System.Drawing.Color.White;
            this.btn_sales.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_sales.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btn_sales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sales.Font = new System.Drawing.Font("문체부 훈민정음체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_sales.Location = new System.Drawing.Point(406, 9);
            this.btn_sales.Name = "btn_sales";
            this.btn_sales.Size = new System.Drawing.Size(90, 40);
            this.btn_sales.TabIndex = 1;
            this.btn_sales.Text = "매출/통계";
            this.btn_sales.UseVisualStyleBackColor = false;
            this.btn_sales.Click += new System.EventHandler(this.btn_sales_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.btn_sales);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.LocalTime);
            this.Controls.Add(this.Table6);
            this.Controls.Add(this.Table5);
            this.Controls.Add(this.Table4);
            this.Controls.Add(this.Table3);
            this.Controls.Add(this.Table2);
            this.Controls.Add(this.Table1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Table1;
        private System.Windows.Forms.Button Table2;
        private System.Windows.Forms.Button Table3;
        private System.Windows.Forms.Button Table4;
        private System.Windows.Forms.Button Table5;
        private System.Windows.Forms.Button Table6;
        private System.Windows.Forms.Label LocalTime;
        private System.Windows.Forms.Timer LocalTimer;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_sales;
    }
}

