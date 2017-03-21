using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationSystemControl
{
    class ReservationController
    {
        //private ReservationView calendarView;
        private TableLayoutPanel calendarPanel;
        private List<Reservation> reservationList;
        private List<Resource> resourceList;

        public ReservationController(ReservationView newView)
        {
            //this.calendarView = newView;
            this.calendarPanel = newView.calendarPanel;
            this.reservationList = this.loadReservations();
            this.resourceList = this.loadResources();
        }

        public List<Resource> loadResources()
        {
            List<Resource> resourceList = new List<Resource>();
            resourceList.Add(new Resource("Room1", 79));
            resourceList.Add(new Resource("Room2", 99));
            resourceList.Add(new Resource("Room3", 119));
            return resourceList;
        }

        public List<Reservation> loadReservations()
        {
            List<Reservation> list = new List<Reservation>();
            //Read reservations from file
            list.Add(new Reservation(id: 0, resourceID: 1, startDate: DateTime.Today, guestName: "John Zhang") { EndDate = DateTime.Today.AddDays(6) });
            list.Add(new Reservation(id: 1, resourceID: 0, startDate: new DateTime(2017, 3, 23), guestName: "John Key"));
            list.Add(new Reservation(id: 2, resourceID: 2, startDate: new DateTime(2017, 3, 25), guestName: "Bill English"));
            return list;
        }

        /// <summary>
        /// Set the column header of tableLayoutPanel
        /// </summary>
        /// <param name="startDate"></param>
        public void SetColumnHeader(DateTime startDate)
        {
            int row = 0;
            DateTime date = startDate;
            for (int col = 1; col < this.calendarPanel.ColumnCount; col++)
            {
                this.calendarPanel.Controls.Add(new DateTimeLabel(date), col, row);
                date = date.AddDays(1);
            }
        }

        /// <summary>
        /// Set the row header of tableLayoutPanel
        /// </summary>
        public void SetRowHeader()
        {
            int col = 0;
            int maxRow = calendarPanel.RowCount < resourceList.Count + 1 ? calendarPanel.RowCount : resourceList.Count + 1;
            for (int row = 1; row < maxRow; row++)
            {
                this.calendarPanel.Controls.Add(new ResourceLabel(resourceList[row - 1]), col, row);
            }
        }

        /// <summary>
        /// Set table content of tableLayoutControl
        /// </summary>
        public void SetTableContent()
        {
            //Add a reservation label to each cell
            
            foreach(Reservation reserv in reservationList)
            {
                int reservCol = FindColumnByDate(reserv.StartDate);
                if(reservCol != -1)
                {
                    int reservRow = FindRowByResourceID(reserv.ResourceID);
                    if(reservRow != -1)
                    {
                        ReservationLabel reservLbl = new ReservationLabel(reserv);
                        int colspan = (reserv.EndDate - reserv.StartDate).Days;
                        int maxColspan = this.calendarPanel.ColumnCount - reservCol;
                        if (colspan > maxColspan) colspan = maxColspan;
                        this.calendarPanel.Controls.Add(reservLbl, reservCol, reservRow);
                        this.calendarPanel.SetColumnSpan(reservLbl, colspan);
                    }
                }
            }
        }

        private int FindColumnByDate(DateTime date)
        {
            for(int col = 1; col < this.calendarPanel.ColumnCount; col++)
            {
                DateTimeLabel dtLbl = (DateTimeLabel)this.calendarPanel.GetControlFromPosition(col, 0);
                DateTime lblDate = dtLbl.date;
                if (lblDate.Date == date.Date) return col;
            }
            return -1;
        }

        private int FindRowByResourceID(int resourceID)
        {
            for(int row = 1; row < this.calendarPanel.RowCount; row++)
            {
                ResourceLabel resourceLbl = (ResourceLabel)this.calendarPanel.GetControlFromPosition(0, row);
                if (resourceLbl.resource.ResourceID == resourceID) return row;
            }
            return -1;
        }

    }
}
