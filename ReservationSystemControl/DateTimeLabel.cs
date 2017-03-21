using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationSystemControl
{
    public class DateTimeLabel: Label
    {
        public DateTime date;

        public DateTimeLabel(DateTime date): base()
        {
            this.date = date;
            this.Text = this.ToString();
        }

        public override string ToString()
        {
            return this.date.ToShortDateString() + "\r\n" + this.date.DayOfWeek.ToString();
        }
    }
}
