using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationSystemControl
{
    public class CalendarPanel: TableLayoutPanel
    {
        private ReservationLabel currentReservLbl;

        public CalendarPanel(): base()
        {
            this.ColumnCount = 15;
            this.RowCount = 11;
            this.InitColumnHeader();
            this.InitRowHeader();
        }

        private void InitColumnHeader()
        {
            int row = 0;
            DateTime date = DateTime.Today;
            for (int col = 1; col < this.ColumnCount; col++)
            {
                DateTimeLabel dtLbl = new DateTimeLabel(date);
                this.Controls.Add(dtLbl, col, row);
                date = date.AddDays(1);
            }
        }

        private void InitRowHeader()
        {
            int col = 0;
            for (int row = 1; row < this.RowCount; row++)
            {
                ResourceLabel rscLbl = new ResourceLabel();
                this.Controls.Add(rscLbl, col, row);
            }
        }
    }
}
