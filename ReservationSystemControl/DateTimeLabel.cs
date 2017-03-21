using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ReservationSystemControl
{
    public class DateTimeLabel: Label
    {
        public DateTime date;

        public DateTimeLabel(DateTime date): base()
        {
            this.date = date;
            this.Dock = DockStyle.Fill;
            this.Text = this.ToString();
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.BackColor = Color.Azure;
        }

        public override string ToString()
        {
            return this.date.ToShortDateString() + "\r\n" + this.date.DayOfWeek.ToString();
        }
    }
}
