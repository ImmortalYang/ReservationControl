using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ReservationSystemControl
{
    /// <summary>
    /// A subclass of label associating a DateTime
    /// </summary>
    public class DateTimeLabel: Label
    {
        public DateTime date;
        public DateTimeLabel() : base()
        {
            this.Dock = DockStyle.Fill;
            this.Text = this.ToString();
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.BackColor = Color.Azure;
        }

        public DateTimeLabel(DateTime date): this()
        {
            this.date = date;  
        }

        public override string ToString()
        {
            if (this.date != null)
                return this.date.ToShortDateString() + "\r\n" + this.date.DayOfWeek.ToString();
            else return base.ToString();
        }
    }
}
