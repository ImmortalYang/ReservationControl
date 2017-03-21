using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationSystemControl
{
    public partial class ReservationView: System.Windows.Forms.UserControl
    {
        private ReservationController theController;

        public ReservationView()
        {
            InitializeComponent();
            theController = new ReservationController(this);
            SetColumnHeader(startDate: DateTime.Now);
            SetRowHeader();
            SetTableContent();
        }

        private void SetColumnHeader(DateTime startDate)
        {
            int row = 0;
            DateTime date = startDate;
            for(int col = 1; col < this.calendarPanel.ColumnCount; col++)
            {
                this.calendarPanel.Controls.Add(new DateTimeLabel(date)
                {
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                }, col, row);
                date = date.AddDays(1);
            }
        }

        private void SetRowHeader()
        {
            List<Resource> resourceList = this.theController.loadResources();
            int col = 0;
            int maxRow = calendarPanel.RowCount < resourceList.Count + 1 ? calendarPanel.RowCount : resourceList.Count + 1;
            for(int row = 1; row < maxRow; row++)
            {
                this.calendarPanel.Controls.Add(new ResourceLabel(resourceList[row - 1])
                {
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                }, col, row);
            }
        }

        private void SetTableContent()
        {
            //Add a reservation label to each cell
            for (int row = 1; row < this.calendarPanel.RowCount; row++)
            {
                for (int col = 1; col < this.calendarPanel.ColumnCount; col++)
                {
                    int resourceID = ( (ResourceLabel)this.calendarPanel.GetControlFromPosition(0, row)).resource.ResourceID;
                    DateTime startDate = ((DateTimeLabel)this.calendarPanel.GetControlFromPosition(col, 0)).date;
                    Reservation reserv = new Reservation(resourceID: resourceID, startDate: startDate);
                    this.calendarPanel.Controls.Add(new ReservationLabel(reserv)
                    {
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleCenter
                    }, col, row);
                }
            }
        }


    }
}
