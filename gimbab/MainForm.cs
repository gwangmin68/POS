using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gimbab
{
    public partial class MainForm : Form
    {
        public DataManager dm;
        public Sales sales;
        DateTime localtime;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dm = new DataManager();
            sales = new Sales();
            dm.lstSales.Add(sales);
            LocalTimer.Start();//현재시각표시
        }
        
        #region 이벤트
        private void btn_sales_Click(object sender, EventArgs e)
        {
            SalesForm sales = new SalesForm();
            sales.mf = this;
            sales.Show();
            Hide();
        }//매출

        private void TableButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            OrderForm OrderForm = new OrderForm();
            OrderForm.mf = this;
            OrderForm.table = dm.getTable(int.Parse(button.Tag.ToString()));
            OrderForm.Show();
            Hide();
        }//테이블

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }//닫기

        private void LocalTimer_Tick(object sender, EventArgs e)
        {
            localtime = DateTime.Now;
            LocalTime.Text = localtime.ToLongDateString() + " " + localtime.ToShortTimeString() + "분";
            if (localtime.Hour == 0 && localtime.Minute == 0 && localtime.Second == 0 && localtime.Millisecond == 0)
            {
                sales = new Sales();
                dm.lstSales.Add(sales);
            }
        }//시간 타이머
        
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)//메인폼을 껐을 때 프로세스 종료
        {
            Environment.Exit(0);//프로세스 종료
        }
        #endregion
    }
}
