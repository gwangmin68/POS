namespace gimbab
{
    partial class OrderForm
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
            this.BackButton = new System.Windows.Forms.Button();
            this.Rice = new System.Windows.Forms.Button();
            this.Snack = new System.Windows.Forms.Button();
            this.Cutlet = new System.Windows.Forms.Button();
            this.AllMenu = new System.Windows.Forms.Button();
            this.Gimbab = new System.Windows.Forms.Button();
            this.MenuBtnPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.FoodThumbnail = new System.Windows.Forms.Panel();
            this.OrderInfo = new System.Windows.Forms.Label();
            this.OrderListView = new System.Windows.Forms.ListView();
            this.Menu_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Menu_Order = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Menu_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cancel = new System.Windows.Forms.Button();
            this.AllCancel = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.AllPrice = new System.Windows.Forms.Label();
            this.Order = new System.Windows.Forms.Button();
            this.Payment = new System.Windows.Forms.Button();
            this.CashRadio = new System.Windows.Forms.RadioButton();
            this.CardRadio = new System.Windows.Forms.RadioButton();
            this.RadioGroup = new System.Windows.Forms.GroupBox();
            this.Drink = new System.Windows.Forms.Button();
            this.RadioGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.White;
            this.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BackButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("문체부 훈민정음체", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BackButton.Location = new System.Drawing.Point(935, 11);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(50, 50);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Rice
            // 
            this.Rice.BackColor = System.Drawing.Color.White;
            this.Rice.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Rice.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.Rice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Rice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rice.Font = new System.Drawing.Font("문체부 훈민정음체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Rice.Location = new System.Drawing.Point(585, 69);
            this.Rice.Name = "Rice";
            this.Rice.Size = new System.Drawing.Size(100, 60);
            this.Rice.TabIndex = 4;
            this.Rice.Text = "식사류";
            this.Rice.UseVisualStyleBackColor = false;
            this.Rice.Click += new System.EventHandler(this.Category_Click);
            // 
            // Snack
            // 
            this.Snack.BackColor = System.Drawing.Color.White;
            this.Snack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Snack.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.Snack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Snack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Snack.Font = new System.Drawing.Font("문체부 훈민정음체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Snack.Location = new System.Drawing.Point(685, 69);
            this.Snack.Name = "Snack";
            this.Snack.Size = new System.Drawing.Size(100, 60);
            this.Snack.TabIndex = 5;
            this.Snack.Text = "분식류";
            this.Snack.UseVisualStyleBackColor = false;
            this.Snack.Click += new System.EventHandler(this.Category_Click);
            // 
            // Cutlet
            // 
            this.Cutlet.BackColor = System.Drawing.Color.White;
            this.Cutlet.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Cutlet.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.Cutlet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Cutlet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cutlet.Font = new System.Drawing.Font("문체부 훈민정음체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Cutlet.Location = new System.Drawing.Point(785, 69);
            this.Cutlet.Name = "Cutlet";
            this.Cutlet.Size = new System.Drawing.Size(100, 60);
            this.Cutlet.TabIndex = 6;
            this.Cutlet.Text = "돈까스류";
            this.Cutlet.UseVisualStyleBackColor = false;
            this.Cutlet.Click += new System.EventHandler(this.Category_Click);
            // 
            // AllMenu
            // 
            this.AllMenu.BackColor = System.Drawing.Color.White;
            this.AllMenu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AllMenu.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.AllMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.AllMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllMenu.Font = new System.Drawing.Font("문체부 훈민정음체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AllMenu.Location = new System.Drawing.Point(385, 69);
            this.AllMenu.Name = "AllMenu";
            this.AllMenu.Size = new System.Drawing.Size(100, 60);
            this.AllMenu.TabIndex = 2;
            this.AllMenu.Text = "전체";
            this.AllMenu.UseVisualStyleBackColor = false;
            this.AllMenu.Click += new System.EventHandler(this.Category_Click);
            // 
            // Gimbab
            // 
            this.Gimbab.BackColor = System.Drawing.Color.White;
            this.Gimbab.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Gimbab.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.Gimbab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Gimbab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gimbab.Font = new System.Drawing.Font("문체부 훈민정음체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Gimbab.Location = new System.Drawing.Point(485, 69);
            this.Gimbab.Name = "Gimbab";
            this.Gimbab.Size = new System.Drawing.Size(100, 60);
            this.Gimbab.TabIndex = 3;
            this.Gimbab.Text = "김밥류";
            this.Gimbab.UseVisualStyleBackColor = false;
            this.Gimbab.Click += new System.EventHandler(this.Category_Click);
            // 
            // MenuBtnPanel
            // 
            this.MenuBtnPanel.AutoScroll = true;
            this.MenuBtnPanel.Location = new System.Drawing.Point(386, 140);
            this.MenuBtnPanel.Name = "MenuBtnPanel";
            this.MenuBtnPanel.Size = new System.Drawing.Size(599, 406);
            this.MenuBtnPanel.TabIndex = 0;
            // 
            // FoodThumbnail
            // 
            this.FoodThumbnail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FoodThumbnail.Cursor = System.Windows.Forms.Cursors.Default;
            this.FoodThumbnail.Location = new System.Drawing.Point(1, 296);
            this.FoodThumbnail.Name = "FoodThumbnail";
            this.FoodThumbnail.Size = new System.Drawing.Size(380, 250);
            this.FoodThumbnail.TabIndex = 0;
            // 
            // OrderInfo
            // 
            this.OrderInfo.AutoSize = true;
            this.OrderInfo.Font = new System.Drawing.Font("문체부 훈민정음체", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OrderInfo.ForeColor = System.Drawing.Color.White;
            this.OrderInfo.Location = new System.Drawing.Point(418, 21);
            this.OrderInfo.Name = "OrderInfo";
            this.OrderInfo.Size = new System.Drawing.Size(270, 26);
            this.OrderInfo.TabIndex = 9;
            this.OrderInfo.Text = " 번 테이블  주문시간:";
            // 
            // OrderListView
            // 
            this.OrderListView.AutoArrange = false;
            this.OrderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Menu_Name,
            this.Menu_Order,
            this.Menu_Price});
            this.OrderListView.HideSelection = false;
            this.OrderListView.Location = new System.Drawing.Point(0, 0);
            this.OrderListView.MultiSelect = false;
            this.OrderListView.Name = "OrderListView";
            this.OrderListView.Size = new System.Drawing.Size(380, 190);
            this.OrderListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.OrderListView.TabIndex = 0;
            this.OrderListView.UseCompatibleStateImageBehavior = false;
            // 
            // Menu_Name
            // 
            this.Menu_Name.Text = "메뉴명";
            // 
            // Menu_Order
            // 
            this.Menu_Order.Text = "수량";
            // 
            // Menu_Price
            // 
            this.Menu_Price.Text = "가격";
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.White;
            this.Cancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Cancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("문체부 훈민정음체", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Cancel.Location = new System.Drawing.Point(0, 192);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(64, 40);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "취소";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.PlusMinusCancel_Click);
            // 
            // AllCancel
            // 
            this.AllCancel.BackColor = System.Drawing.Color.White;
            this.AllCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AllCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.AllCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.AllCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllCancel.Font = new System.Drawing.Font("문체부 훈민정음체", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AllCancel.Location = new System.Drawing.Point(68, 192);
            this.AllCancel.Name = "AllCancel";
            this.AllCancel.Size = new System.Drawing.Size(90, 40);
            this.AllCancel.TabIndex = 9;
            this.AllCancel.Text = "전체취소";
            this.AllCancel.UseVisualStyleBackColor = false;
            this.AllCancel.Click += new System.EventHandler(this.AllCancel_Click);
            // 
            // Plus
            // 
            this.Plus.BackColor = System.Drawing.Color.White;
            this.Plus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Plus.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.Plus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Plus.Font = new System.Drawing.Font("문체부 훈민정음체", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Plus.Location = new System.Drawing.Point(165, 192);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(50, 40);
            this.Plus.TabIndex = 10;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = false;
            this.Plus.Click += new System.EventHandler(this.PlusMinusCancel_Click);
            // 
            // Minus
            // 
            this.Minus.BackColor = System.Drawing.Color.White;
            this.Minus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Minus.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.Minus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minus.Font = new System.Drawing.Font("문체부 훈민정음체", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Minus.Location = new System.Drawing.Point(223, 192);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(50, 40);
            this.Minus.TabIndex = 11;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = false;
            this.Minus.Click += new System.EventHandler(this.PlusMinusCancel_Click);
            // 
            // AllPrice
            // 
            this.AllPrice.AutoSize = true;
            this.AllPrice.Font = new System.Drawing.Font("문체부 훈민정음체", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AllPrice.ForeColor = System.Drawing.Color.White;
            this.AllPrice.Location = new System.Drawing.Point(0, 235);
            this.AllPrice.Name = "AllPrice";
            this.AllPrice.Size = new System.Drawing.Size(125, 26);
            this.AllPrice.TabIndex = 16;
            this.AllPrice.Text = "전체 금액";
            // 
            // Order
            // 
            this.Order.BackColor = System.Drawing.Color.White;
            this.Order.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Order.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.Order.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Order.Font = new System.Drawing.Font("문체부 훈민정음체", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Order.Location = new System.Drawing.Point(278, 192);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(100, 40);
            this.Order.TabIndex = 12;
            this.Order.Text = "주문";
            this.Order.UseVisualStyleBackColor = false;
            this.Order.Click += new System.EventHandler(this.Order_Click);
            // 
            // Payment
            // 
            this.Payment.BackColor = System.Drawing.Color.White;
            this.Payment.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Payment.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.Payment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Payment.Font = new System.Drawing.Font("문체부 훈민정음체", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Payment.Location = new System.Drawing.Point(278, 243);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(100, 40);
            this.Payment.TabIndex = 15;
            this.Payment.Text = "결제";
            this.Payment.UseVisualStyleBackColor = false;
            this.Payment.Click += new System.EventHandler(this.Payment_Click);
            // 
            // CashRadio
            // 
            this.CashRadio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CashRadio.AutoSize = true;
            this.CashRadio.Location = new System.Drawing.Point(5, 35);
            this.CashRadio.Name = "CashRadio";
            this.CashRadio.Size = new System.Drawing.Size(58, 19);
            this.CashRadio.TabIndex = 14;
            this.CashRadio.TabStop = true;
            this.CashRadio.Text = "현금";
            this.CashRadio.UseVisualStyleBackColor = true;
            // 
            // CardRadio
            // 
            this.CardRadio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CardRadio.AutoSize = true;
            this.CardRadio.Location = new System.Drawing.Point(5, 16);
            this.CardRadio.Name = "CardRadio";
            this.CardRadio.Size = new System.Drawing.Size(58, 19);
            this.CardRadio.TabIndex = 13;
            this.CardRadio.TabStop = true;
            this.CardRadio.Text = "카드";
            this.CardRadio.UseVisualStyleBackColor = true;
            // 
            // RadioGroup
            // 
            this.RadioGroup.Controls.Add(this.CashRadio);
            this.RadioGroup.Controls.Add(this.CardRadio);
            this.RadioGroup.Location = new System.Drawing.Point(189, 236);
            this.RadioGroup.Name = "RadioGroup";
            this.RadioGroup.Size = new System.Drawing.Size(86, 59);
            this.RadioGroup.TabIndex = 1;
            this.RadioGroup.TabStop = false;
            this.RadioGroup.Text = "결제수단";
            // 
            // Drink
            // 
            this.Drink.BackColor = System.Drawing.Color.White;
            this.Drink.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Drink.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.Drink.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Drink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Drink.Font = new System.Drawing.Font("문체부 훈민정음체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Drink.Location = new System.Drawing.Point(885, 69);
            this.Drink.Name = "Drink";
            this.Drink.Size = new System.Drawing.Size(100, 60);
            this.Drink.TabIndex = 7;
            this.Drink.Text = "음료류";
            this.Drink.UseVisualStyleBackColor = false;
            this.Drink.Click += new System.EventHandler(this.Category_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(1000, 553);
            this.Controls.Add(this.Drink);
            this.Controls.Add(this.RadioGroup);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.AllPrice);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.AllCancel);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OrderListView);
            this.Controls.Add(this.OrderInfo);
            this.Controls.Add(this.FoodThumbnail);
            this.Controls.Add(this.MenuBtnPanel);
            this.Controls.Add(this.Gimbab);
            this.Controls.Add(this.AllMenu);
            this.Controls.Add(this.Cutlet);
            this.Controls.Add(this.Snack);
            this.Controls.Add(this.Rice);
            this.Controls.Add(this.BackButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(760, 500);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderForm_FormClosed);
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.RadioGroup.ResumeLayout(false);
            this.RadioGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button Rice;
        private System.Windows.Forms.Button Snack;
        private System.Windows.Forms.Button Cutlet;
        private System.Windows.Forms.Button AllMenu;
        private System.Windows.Forms.Button Gimbab;
        private System.Windows.Forms.FlowLayoutPanel MenuBtnPanel;
        private System.Windows.Forms.Panel FoodThumbnail;
        public System.Windows.Forms.Label OrderInfo;
        private System.Windows.Forms.ListView OrderListView;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button AllCancel;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Label AllPrice;
        private System.Windows.Forms.Button Order;
        private System.Windows.Forms.Button Payment;
        private System.Windows.Forms.RadioButton CardRadio;
        private System.Windows.Forms.RadioButton CashRadio;
        private System.Windows.Forms.GroupBox RadioGroup;
        private System.Windows.Forms.ColumnHeader Menu_Name;
        private System.Windows.Forms.ColumnHeader Menu_Order;
        private System.Windows.Forms.ColumnHeader Menu_Price;
        private System.Windows.Forms.Button Drink;
    }
}