using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace gimbab
{
    public partial class SalesForm : Form
    {
        public MainForm mf;
        DateTime date;
        Sales sales;

        public SalesForm()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            date = DateTime.Now.Date;
            sales = getSales();
            Sales();
        }

        private Sales getSales()
        {
            return mf.dm.lstSales.Find(tsales => tsales.date.ToShortDateString().Equals(date.ToShortDateString()));
        }
        
        #region 이벤트
        private void btn_Back_Click(object sender, EventArgs e)
        {
            mf.Show();
            Close();
        }

        private void ChartButton(Object sender, EventArgs e)
        {
            Button button = sender as Button;
            chart_Sales.Series.Clear();
            if (button.Text.Equals("Sales"))
                Sales();
            else if (button.Text.Equals("Table"))
                TableSales();
            else if (button.Text.Equals("Category"))
                CategorySales();
            else if (button.Text.Equals("Menu"))
                MenuSales();
        }//차트 버튼(버튼에 따라 Sales 실행)

        #region Sales
        private void Sales()
        {
            int CashPay = sales.getCashPay();
            int CardPay = sales.getCardPay();

            chart_Sales.ChartAreas[0].AxisX.Maximum = 2;
            chart_Sales.ChartAreas[0].AxisY.Interval = 10000;

            Series series = new Series("Sales");
            series.Label = "#PERCENT{0.0 %}";
            series.ChartType = SeriesChartType.Bar;
            if (CashPay != 0 || CardPay != 0)
            {
                series.Points.AddXY("현금\n" + CashPay + "원", CashPay);
                series.Points.AddXY("카드\n" + CardPay + "원", CardPay);
            }
            addChart(series);
            chart_Sales.Series[0].IsVisibleInLegend = false;
        }

        private void TableSales()
        {
            Series series = new Series("Table");
            series.Label = "#PERCENT{0.0 %}";
            series.ChartType = SeriesChartType.Doughnut;
            foreach (int tsales in sales.getTableSales())
            {
                series.Points.Add(tsales);
                int seriesNum = series.Points.Count;
                series.Points[seriesNum - 1].LegendText = "테이블" + seriesNum + "\n" + tsales + "원";
            }

            addChart(series);
        }

        private void CategorySales()
        {
            int GimbabSales = 0;
            int RiceSales = 0;
            int SnackSales = 0;
            int CutletSales = 0;

            Series series = new Series("Category");
            //series.Points.Clear
            series.Label = "#PERCENT{0.0 %}";
            series.ChartType = SeriesChartType.Doughnut;

            foreach (Food food in sales.getlstFood())
            {
                switch (food.category)
                {
                    case "김밥류":
                        GimbabSales += food.orders * food.price;
                        break;
                    case "식사류":
                        RiceSales += food.orders * food.price;
                        break;
                    case "분식류":
                        SnackSales += food.orders * food.price;
                        break;
                    case "돈까스류":
                        CutletSales += food.orders * food.price;
                        break;
                }
            }

            series.Points.Add(GimbabSales);
            series.Points[0].LegendText = "김밥류\n" + GimbabSales + "원";

            series.Points.Add(RiceSales);
            series.Points[1].LegendText = "식사류" + RiceSales + "원";

            series.Points.Add(SnackSales);
            series.Points[2].LegendText = "분식류" + SnackSales + "원";

            series.Points.Add(CutletSales);
            series.Points[3].LegendText = "돈까스류" + CutletSales + "원";

            addChart(series);
        }
        
        private void MenuSales()
        {
            chart_Sales.ChartAreas[0].AxisY.Interval = 1;//Y값 단위=1


            Series series = new Series("Menu");
            series.ChartType = SeriesChartType.Bar;
            series.Label = "#PERCENT{0 %}";

            foreach (Food food in sales.getlstFood())
            {
                series.Points.AddXY(food.name, food.orders);
                series.Points[series.Points.Count - 1].Label += (" " + food.price * food.orders + "원");
            }
            addChart(series);
            chart_Sales.Series[0].IsVisibleInLegend = false;
        }

        private void addChart(Series series)
        {
            chart_Sales.Series.Add(series);
            Chartpanel.Controls.Add(chart_Sales);
        }
        #endregion
        
        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;
            date = dtp.Value;
            sales = getSales();
            chart_Sales.Series.Clear();
            if(sales == null)
            {
                MessageBox.Show("선택하신 날의 매출 기록이 존재하지 않습니다.");
                date = DateTime.Now.Date;
                sales = getSales();
                Sales();
                dtp.Value = date;
            }
            else
            {
                Sales();
            }
        }
        #endregion

    }
}
