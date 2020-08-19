using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class ExtensionMethods
    {
        //TransformPoint Translates a Point value from a certain area(OrigionalSize) to another area (WantedSize)
        //Parameters Size OrigionalSize and Size Wanted size defining the sizes of the forms
        public static Point TransformPoint(this Point point,Size OrigionalSize,Size WantedSize)
        {
            //Calculate scale difference
            System.Windows.Forms.MessageBox.Show("Wanted Size" + WantedSize.Width + ". Origional Size" + OrigionalSize.Width);
            float x = (float)WantedSize.Width / (float)OrigionalSize.Width;
            float y = WantedSize.Height / OrigionalSize.Height;
            Point convertedPoint = new Point(Convert.ToInt32(point.X*x), Convert.ToInt32(point.Y*y));
            return convertedPoint;
        }
        //TransformPoint Translates a Point value from a certain area(OrigionalSize) to another area (WantedSize)
        //Parameters Float[] scale defining that scale where scale[0] is x and scale[1] is y
        public static Point TransformPoint(this Point point, float[] scale)
        {
            Point convertedPoint = new Point(Convert.ToInt32(point.X * scale[0]), Convert.ToInt32(point.Y * scale[1]));
            return convertedPoint;
        }
    }
}
