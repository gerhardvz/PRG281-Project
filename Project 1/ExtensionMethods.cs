using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class PointExtension
    {
        //TransformPoint Translates a Point value from a certain area(OrigionalSize) to another area (WantedSize)
        //Parameters Size OrigionalSize and Size Wanted size defining the sizes of the forms
        public static Point TransformPoint(this Point point,Size OrigionalSize,Size WantedSize)
        {
            //Calculate scale difference
           // System.Windows.Forms.MessageBox.Show("Wanted Size" + WantedSize.Width + ". Origional Size" + OrigionalSize.Width);
            float x = (float)WantedSize.Width / (float)OrigionalSize.Width;
            float y = (float)WantedSize.Height / (float)OrigionalSize.Height;
            Debug.WriteLine("");
            Debug.WriteLine("Wanted Size:" + WantedSize.ToString());
            Debug.WriteLine("Origional Size:" + OrigionalSize.ToString());
            Debug.WriteLine("Scale: X= " + x.ToString() + " Y=" + y.ToString());
            Point convertedPoint = new Point(Convert.ToInt32((float)point.X*x), Convert.ToInt32((float)point.Y*y));
            Debug.WriteLine("Transform Result:" + convertedPoint.ToString());
            //point.X = Convert.ToInt32(point.X * x);
           // point.Y = Convert.ToInt32(point.Y * y);
            return new Point(Convert.ToInt32((float)point.X * x), Convert.ToInt32((float)point.Y * y));
        }
        //TransformPoint Translates a Point value from a certain area(OrigionalSize) to another area (WantedSize)
        //Parameters Float[] scale defining that scale where scale[0] is x and scale[1] is y
        public static Point TransformPoint(this Point point, float[] scale)
        {
            Point convertedPoint = new Point(Convert.ToInt32((float)point.X * scale[0]), Convert.ToInt32((float)point.Y * scale[1]));
            Debug.WriteLine("Transform Result:" + convertedPoint.ToString());
            return convertedPoint;
        }
        
    }
}
