using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gimbab
{
    public partial class OrderForm : Form
    {
        List<Food> lstOrder_Temp; //임시 주문서(주문을 눌러야만 테이블의 주문서로 들어감)
        public MainForm mf;
        public Table table;
        int tnum; //TableNum

        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            //this.Load -= OrderForm_Load;
            
            tnum = table.getTnum();
            setOrderTimeText();
            InitOrderList();
            SetMenuButton("전체");//주문폼 띄우며 "전체"메뉴버튼 띄우기
            RefreshListView();
        }
        
        #region 주문 리스트
        private void InitOrderList()
        {
            int Column_Width = OrderListView.Width / 3;
            lstOrder_Temp = table.getList();//주문서의 복사본 가져오기

            OrderListView.View = View.Details;
            OrderListView.FullRowSelect = true;//한 줄 전체 선택

            foreach(ColumnHeader column in OrderListView.Columns){ column.Width = Column_Width; }
        }

        private void RefreshListView()//리스트뷰 다시 그리기
        {
            int Allprice = 0;
            OrderListView.Items.Clear();
            foreach (Food food in lstOrder_Temp)
            {
                String[] arr = new string[3];
                arr[0] = food.name;
                arr[1] = food.orders.ToString();
                arr[2] = (food.orders * food.price).ToString();
                Allprice += food.orders * food.price;

                ListViewItem lvi = new ListViewItem(arr); //lvItem
                OrderListView.Items.Add(lvi);
            }
            AllPrice.Text = "전체금액 : " + "\n" + Allprice.ToString() + "원";
        }
        #endregion

        #region 이벤트
        private void BackButton_Click(object sender, EventArgs e)//뒤로가기 버튼
        {
            Close();
        }

        private void Category_Click(object sender, EventArgs e)//메뉴 카테고리별 버튼
        {
            Button btn = (Button)sender;
            SetMenuButton(btn.Text);
        }

        #region 카테고리 버튼
        private void SetMenuButton(String Kind)//카테고리별 메뉴버튼 생성 및 추가
        {
            RemoveAllitem();
            foreach (Food food in mf.dm.getlstFood())
            {
                if (food.category.Equals(Kind) || Kind.Equals("전체"))
                {
                    TextBox tbox = new TextBox();
                    Button button = new Button();

                    tbox.ForeColor = Color.White;//글자색
                    tbox.BackColor = Color.Black;//배경색
                    tbox.BorderStyle = BorderStyle.None;//테두리
                    tbox.Font = new Font("문체부 훈민정음체", 10);
                    tbox.Text = food.name + " - " + food.price + "원";
                    Size size = TextRenderer.MeasureText(tbox.Text, tbox.Font);//글자 크기 가져오기
                    tbox.Size = size;

                    button.Controls.Add(tbox);
                    button.Name = food.name;
                    button.BackgroundImageLayout = ImageLayout.Stretch;//버튼 크기에 이미지 맞추기
                    button.Image = food.thumbnail;
                    button.Size = food.thumbnail.Size;//사진 크기에 맞추기(사진은 불러올 때 240X240으로 불러옴)
                    button.Click += new EventHandler(Menu_Click);//클릭 이벤트 달기

                    MenuBtnPanel.Controls.Add(button);
                }
            }
        }

        private void RemoveAllitem()//패널비우기
        {
            MenuBtnPanel.Controls.Clear();
        }
        #endregion

        private void Menu_Click(object sender, EventArgs e)//메뉴버튼
        {
            Button button = (Button)sender;

            AddOrder(button.Name);
            ItemFocus(lstOrder_Temp.IndexOf(lstOrderTemp_getFood(button.Name)));
            MessageBox.Show("" + lstOrder_Temp.IndexOf(lstOrderTemp_getFood(button.Name)));

            FoodThumbnail.BackgroundImage = button.Image;
        }

        String barcodeString = string.Empty;
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            ActiveControl = null;
            if (msg.Msg == 0x100)
            {
                string log = string.Format("ProcessCmdKey KeyData: {0}", keyData);
                if (keyData == Keys.Return)
                {
                    Food food = getMenuInfo(barcodeString, "barcode");
                    if (food != null)
                    {
                        AddOrder(food.name);
                    }
                    else
                    {
                        MessageBox.Show("등록되지 않은 상품입니다.");
                    }
                    barcodeString = string.Empty;
                }
                else
                {
                    barcodeString += char.ConvertFromUtf32((int)keyData);
                }

                Debug.WriteLine(log);
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }//바코드 이벤트
        
        private Food getMenuInfo(String str, String Kind)
        {
            Food food = null;
            if (Kind.Equals("name"))
                food = mf.dm.getlstFood().Find(item => item.name == str);
            else
                food = mf.dm.getlstFood().Find(item => item.barcode == str);
            return new Food(food.name, food.category, food.barcode, food.price, 0);
        }//이름이나 바코드로 메뉴정보 불러오기

        private Food lstOrderTemp_getFood(String name)
        {
            return lstOrder_Temp.Find(item => item.name == name);
        }//임시 주문서에서 정보 불러오기
        
        private void AddOrder(String foodname)
        {
            Food item = lstOrderTemp_getFood(foodname);
            if (item == null)
            {
                item = getMenuInfo(foodname, "name");
                lstOrder_Temp.Add(item);
            }
            item.orders++;
            RefreshListView();
        }//임시주문서에 주문내역 추가

        private void Order_Click(object sender, EventArgs e)//주문버튼(주문 창 닫고 진짜 주문리스트에 정보 넣기)
        {
            DateTime date = DateTime.Now;

            if (OrderListView.Items.Count != 0)
                table.setOrderTime(date.ToShortDateString() + date.ToShortTimeString());
            else
                table.setOrderTime("");

            table.setList(lstOrder_Temp);
            setButtonText();
            mf.Show();
            this.Close();
        }
        
        private void PlusMinusCancel_Click(object sender, EventArgs e)//수량 더하기 & 빼기 & 취소
        {

            Button btn = (Button)sender;
            Food item = lstOrderTemp_getFood(OrderListView.SelectedItems[0].SubItems[0].Text);
            int index;

            if (OrderListView.SelectedItems.Count != 0)
            {
                if (btn.Text.Equals("+"))    //더하기
                {
                    item.orders++;
                }
                else if (btn.Text.Equals("-"))//빼기
                {
                    if (item.orders == 1)
                        lstOrder_Temp.Remove(item);
                    else
                        item.orders--;
                }
                else    //취소
                {
                    lstOrder_Temp.Remove(item);
                    List<Food> lst = table.getList();//만약 테이블의 주문서에 있을경우 삭제
                    item = lst.Find(food => food.name == OrderListView.SelectedItems[0].SubItems[0].Text);

                    if (item != null)
                    {
                        lst.Remove(item);
                        table.setList(lst);
                    }
                    if (lstOrder_Temp.Count == 0)
                        table.setOrderTime("");

                    setOrderTimeText();
                    setButtonText();
                    FoodThumbnail.BackgroundImage = null;
                }
                index = OrderListView.FocusedItem.Index;
                RefreshListView();
                ItemFocus(index);
            }
        }

        private void ItemFocus(int index)
        {
            ListViewItem focusitem = null;
            if (OrderListView.Items.Count != 0)
                focusitem = OrderListView.Items[index < OrderListView.Items.Count ? index : OrderListView.Items.Count - 1];

            if (focusitem != null)
            {
                focusitem.Focused = true;
                focusitem.Selected = true;
            }
        }//수량 +, -클릭 후 포커스 다시 지정

        private void AllCancel_Click(object sender, EventArgs e)//전체취소
        {
            lstOrder_Temp.Clear();
            table.setList(lstOrder_Temp);
            table.setOrderTime("");
            setOrderTimeText();
            FoodThumbnail.BackgroundImage = null;
            setButtonText();
            RefreshListView();
        }

        private void Payment_Click(object sender, EventArgs e)//결제
        {
            if(table.getList().Count == 0)
            {
                MessageBox.Show("결제할 상품이 존재하지 않습니다.");
                return;
            }
            else if (!CardRadio.Checked && !CashRadio.Checked)
            {
                MessageBox.Show("결제수단을 선택해주세요.");
                return;
            }

            String str = "";
            int pay = 0;

            foreach(Food food in table.getList())
            {
                str += food.name + " | " + food.orders + "\n";
                pay += food.price * food.orders;
            }

            DialogResult dr = MessageBox.Show(str + "총금액 : " + pay + "원\n" + (CardRadio.Checked ? "카드로 ":"현금으로 ") + "결제하시겠습니까?", "알림", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.OK)//OK를 누를 때
            {
                foreach (Food food in table.getList())
                {
                    Food temp = mf.sales.getlstFood().Find(item => item.name == food.name);
                    if (temp == null)
                        mf.sales.getlstFood().Add(food);
                    else
                        temp.orders += food.orders;
                }

                table.setList(new List<Food>());
                lstOrder_Temp = table.getList();
                setOrderTimeText();
                RefreshListView();
                setButtonText();
                //mf.sales.AddSales(tnum, pay);
                addPay(tnum, pay, CardRadio.Checked ? "card" : "cash");
                table.setOrderTime("");
                setOrderTimeText();
                MessageBox.Show("결제가 완료되었습니다.");
            }
            else
            {
                MessageBox.Show("결제가 취소되었습니다.");
            }
        }
        private void addPay(int tnum,int pay, String Kind)
        {
            mf.sales.AddSales(tnum, pay, Kind);
        }

        private void OrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mf.Show();
        }
        #endregion

        #region 테이블, 주문시간 텍스트
        private void setOrderTimeText()//주문폼 주문시간 설정
        {
            OrderInfo.Text = tnum + " 번 테이블  주문시간:" + table.getOrderTime();
        }

        private void setButtonText()//테이블버튼 텍스트 설정
        {
            Button button = (Button)mf.Controls.Find("Table" + tnum, true).FirstOrDefault();
            button.Text = "Table" + tnum + "\n";
            foreach(Food food in table.getList())
            {
                button.Text +=  food.name + " × " + food.orders + "\n";
            }
        }
        #endregion
    }
}
