using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_ticket_sales_management.Utils
{
    public class BaseColor
    {
        public static Color XanhDam = Color.FromArgb(3, 4, 94);
        public static Color Den = Color.FromArgb(1, 2, 39);
        public static Color Xam = Color.FromArgb(124, 124, 124);
    }

    public class ColorCodes
    {
        public static List<String> ColorList = new List<string>
            {
                "#0000FF", // Xanh dương
                "#008000", // Xanh lá cây
                "#00FF00", // Xanh lá cây nhạt
                "#006400", // Xanh lá cây đậm
                "#00FFFF", // Xanh ngọc
                "#008080", // Xanh lục
                "#FFB6C1", // Hồng nhạt
                "#FF69B4", // Hồng tươi
                "#FF1493", // Hồng đậm
                "#FFA500", // Cam
                "#A52A2A", // Nâu nhạt
                "#8B4513", // Nâu đậm
                "#D8BFD8", // Tím nhạt
                "#800080"  // Tím đậm
            };
    }
}
