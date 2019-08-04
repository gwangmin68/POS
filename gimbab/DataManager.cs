using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace gimbab
{
    public class DataManager
    {
        List<Food> lstFood = new List<Food>(); // 메뉴 리스트

        List<Table> lstTable = new List<Table>();   //테이블 리스트

        public List<Sales> lstSales = new List<Sales>();    //날짜별 매출 리스트
        
        public DataManager()
        {
            SetFood();
            SetTable();
        }

        #region 테이블 리스트 초기화
        public void SetTable()
        {
            for(int i = 1;i <= 6; i++)
            {
                lstTable.Add(new Table(i));
            }
        }
        #endregion

        #region Food 리스트 초기화
        public void SetFood()
        {
            //돈까스류
            lstFood.Add(new Food("돈까스", "돈까스류", "", 4500, 0));
            lstFood.Add(new Food("멕시칸롤까스", "돈까스류", "", 6500, 0));
            lstFood.Add(new Food("치즈롤돈까스", "돈까스류", "", 6500, 0));
            lstFood.Add(new Food("카레돈까스", "돈까스류", "", 6000, 0));
            lstFood.Add(new Food("카르카르돈까스", "돈까스류", "", 6000, 0));
            lstFood.Add(new Food("롤까스", "돈까스류", "", 6500, 0));
            //식사류
            lstFood.Add(new Food("갈비탕", "식사류", "", 6000, 0));
            lstFood.Add(new Food("김치볶음밥", "식사류", "", 4500, 0));
            lstFood.Add(new Food("김치찌개", "식사류", "", 4500, 0));
            lstFood.Add(new Food("도시락", "식사류", "", 3500, 0));
            lstFood.Add(new Food("새우날치알볶음밥", "식사류", "", 5500, 0));
            lstFood.Add(new Food("오징어덮밥", "식사류", "", 5500, 0));
            lstFood.Add(new Food("육계장", "식사류", "", 5500, 0));
            lstFood.Add(new Food("제육볶음", "식사류", "", 5500, 0));
            lstFood.Add(new Food("된장찌개", "식사류", "", 4500, 0));
            lstFood.Add(new Food("오므라이스", "식사류", "", 5500, 0));
            //김밥류
            lstFood.Add(new Food("땡초김밥", "김밥류", "", 2000, 0));
            lstFood.Add(new Food("매콤오징어김밥", "김밥류", "", 2000, 0));
            lstFood.Add(new Food("베이컨김밥", "김밥류", "", 2000, 0));
            lstFood.Add(new Food("계란말이김밥", "김밥류", "", 2000, 0));
            lstFood.Add(new Food("김밥세트", "김밥류", "", 6000, 0));
            lstFood.Add(new Food("날치알롤", "김밥류", "", 2500, 0));
            lstFood.Add(new Food("새우날치알김밥", "김밥류", "", 2500, 0));
            lstFood.Add(new Food("숯불김밥", "김밥류", "", 2000, 0));
            lstFood.Add(new Food("야채김밥", "김밥류", "", 2000, 0));
            lstFood.Add(new Food("오미자김밥", "김밥류", "", 2000, 0));
            lstFood.Add(new Food("참치마요김밥", "김밥류", "", 2000, 0));
            lstFood.Add(new Food("참치치즈김밥", "김밥류", "", 2000, 0));
            lstFood.Add(new Food("치자김밥", "김밥류", "", 2000, 0));
            lstFood.Add(new Food("크롤렐라김밥", "김밥류", "", 2000, 0));
            //분식류
            lstFood.Add(new Food("돌우동", "분식류", "", 6500, 0));
            lstFood.Add(new Food("떡볶이", "분식류", "", 4000, 0));
            lstFood.Add(new Food("라볶이", "분식류", "", 5000, 0));
            lstFood.Add(new Food("만두라면", "분식류", "", 5500, 0));
            lstFood.Add(new Food("라면", "분식류", "", 5000, 0));
            lstFood.Add(new Food("생생우동", "분식류", "", 6000, 0));
            lstFood.Add(new Food("어묵", "분식류", "", 3500, 0));
            lstFood.Add(new Food("짬뽕라면", "분식류", "", 6000, 0));
            lstFood.Add(new Food("쫄면", "분식류", "", 5000, 0));
            //음료류
            lstFood.Add(new Food("코카콜라", "음료류", "8801094017200", 1200, 0));
            lstFood.Add(new Food("펩시콜라", "음료류", "8801056070809", 800, 0));
        }
        #endregion

        #region getset
        public Table getTable(int TableNum)
        {
            return lstTable[TableNum - 1];
        }

        public List<Food> getlstFood()
        {
            return lstFood;
        }
        #endregion
    }
}
