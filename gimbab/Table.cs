using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gimbab
{
    public class Table
    {
        int TableNum;
        String OrderTime = "";
        public List<Food> lstOrder = new List<Food>();//주문 내역

        public Table(int TableNum)
        {
            this.TableNum = TableNum;
        }

        #region 리스트
        public List<Food> getList()
        {
            return copyList(lstOrder);
        }

        public void setList(List<Food> list)
        {
            lstOrder = copyList(list);
        }

        public List<Food> copyList(List<Food> list)
        {
            return list.ConvertAll(food => new Food(food.name, food.category,food.barcode, food.price, food.orders));
        }
        #endregion

        #region 주문시간, 테이블넘버, 메뉴문자열, 가격
        public int getTnum()
        {
            return TableNum;
        }

        public String getOrderTime()
        {
            return OrderTime;
        }

        public void setOrderTime(String OrderTime)
        {
            this.OrderTime = OrderTime;
        }
        #endregion
    }
}
