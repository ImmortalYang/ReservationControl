using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationSystemControl
{
    public static class Util
    {
        /// <summary>
        /// Use GetColumnWidths and GetRowHeights methods to calculate the cell row and column index from a given point.
        /// This method is copied from http://stackoverflow.com/questions/15449504/how-do-i-determine-the-cell-being-clicked-on-in-a-tablelayoutpanel
        /// The original version was not an extention method.
        /// Documentation is not included from original code.
        /// </summary>
        /// <param name="tlp">table layout panel</param>
        /// <param name="point">the point from which the row and col index is calculated</param>
        /// <returns></returns>
        public static Point? GetRowColIndex(this TableLayoutPanel tlp, Point point)
        {
            if (point.X > tlp.Width || point.Y > tlp.Height)
                return null;

            int w = tlp.Width;
            int h = tlp.Height;
            int[] widths = tlp.GetColumnWidths();

            int i;
            for (i = widths.Length - 1; i >= 0 && point.X < w; i--)
                w -= widths[i];
            int col = i + 1;

            int[] heights = tlp.GetRowHeights();
            for (i = heights.Length - 1; i >= 0 && point.Y < h; i--)
                h -= heights[i];

            int row = i + 1;

            return new Point(col, row);
        }
    }
}
