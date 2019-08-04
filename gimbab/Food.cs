using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gimbab
{
    public class Food
    {
        public String name { get; set; }
        public String category { get; set; }
        public String barcode { get; set; }
        public int price { get; set; }
        public int orders { get; set; }
        public Image thumbnail { get; set; }
        
        public Food(String name, String category, String barcode, int price, int orders)
        {
            this.name = name;
            this.category = category;
            this.barcode = barcode;
            this.price = price;
            this.thumbnail = GetImage(name);
            this.orders = orders;
        }

        #region 이미지 가져오기
        private Image GetImage(String foodname)
        {
            Image Image;
            String Path = System.IO.Directory.GetCurrentDirectory() + @"\FoodImage\" + foodname + ".jpg";

            FileInfo Fi = new FileInfo(Path);

            if (!Fi.Exists)
            {
                
                Path = Path.Replace("jpg", "png");
                Fi = new FileInfo(Path);
                if (!Fi.Exists)
                    Path = Path.Replace(foodname + ".png", "noimage.jpg");
            }
            Image = new Bitmap(Image.FromFile(Path), new Size(240, 240));
            return Image;
        }
        #endregion
    }
}
