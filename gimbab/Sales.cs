using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gimbab
{
    public class Sales //하루 매출
    {
        public DateTime date;

        int cardPay = 0;
        int cashPay = 0;

        List<int> TableSales = new List<int>();

        List<Food> lstFood = new List<Food>(); // 카테고리별, 메뉴별 매출

        public int GimbabSales = 0;
        public int RiceSales = 0;
        public int SnackSales = 0;
        public int CutletSales = 0;

        public Sales()
        {
            date = DateTime.Now.Date;   //ToShortDateString() yy-mm-dd
            TableSales.Add(0);
            TableSales.Add(0);
            TableSales.Add(0);
            TableSales.Add(0);
            TableSales.Add(0);
            TableSales.Add(0);
        }

        #region get, set
        public void AddSales(int tnum, int sales, String Kind)
        {
            TableSales[tnum - 1] += sales;
            if (Kind.Equals("card"))
            {
                cardPay += sales;
            }else if (Kind.Equals("cash"))
            {
                cashPay += sales;
            }
        }//테이블 숫자, 금액, 결제방식

        public int getCardPay()
        {
            return cardPay;
        }

        public int getCashPay()
        {
            return cashPay;
        }

        public List<Food> getlstFood()
        {
            return lstFood;
        }

        public void setlstFood(List<Food> lstFood)
        {
            this.lstFood = lstFood;
        }

        public List<int> getTableSales()
        {
            return TableSales;
        }

        public List<int> getCategorySales()
        {
            foreach (Food food in lstFood)
            {

            }
            return new List<int>();
        }
        #endregion
    }
}
