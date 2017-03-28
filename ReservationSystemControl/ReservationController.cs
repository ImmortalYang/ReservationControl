using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace ReservationSystemControl
{
    public class ReservationController
    {
        private ReservationView calendarView;
        public List<Reservation> reservationList;
        public List<Resource> resourceList;

        public ReservationController(ReservationView newView)
        {
            this.calendarView = newView;
            reservationList = this.loadReservations();
            resourceList = this.loadResources();
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
            list.Add(new Reservation(resourceID: 1, startDate: new DateTime(2017, 3, 29), endDate: new DateTime(2017, 4, 2), guestName: "John Zhang"));
            list.Add(new Reservation(resourceID: 0, startDate: new DateTime(2017, 3, 29), endDate: new DateTime(2017, 4, 1), guestName: "John Key"));
            list.Add(new Reservation(resourceID: 2, startDate: new DateTime(2017, 3, 28), endDate: new DateTime(2017, 4, 3), guestName: "Bill English"));
            return list;
        }

        /// <summary>
        /// Set the column header of tableLayoutPanel
        /// </summary>
        /// <param name="startDate">The date value of the first column</param>
        public void SetColumnHeader(TableLayoutPanel calendarPanel)
        {
            int row = 0;
            DateTime date = DateTime.Today;
            for (int col = 1; col < calendarPanel.ColumnCount; col++)
            {
                calendarPanel.Controls.Add(new DateTimeLabel(date), col, row);
                date = date.AddDays(1);
            }
        }

        /// <summary>
        /// Set the row header of tableLayoutPanel
        /// </summary>
        public void SetRowHeader(TableLayoutPanel calendarPanel)
        {
            int col = 0;
            int maxRow = calendarPanel.RowCount < resourceList.Count + 1 ? calendarPanel.RowCount : resourceList.Count + 1;
            for (int row = 1; row < maxRow; row++)
            {
                calendarPanel.Controls.Add(new ResourceLabel(resourceList[row - 1]), col, row);
            }
        }

        /// <summary>
        /// Set table content of tableLayoutControl
        /// </summary>
        public void SetTableContent(TableLayoutPanel calendarPanel)
        {
            //Add a reservation label to each cell
            
            foreach(Reservation reserv in reservationList)
            {
                SetReservLabelToPanel(calendarPanel, new ReservationLabel(reserv));
            }
        }

        /// <summary>
        /// Set the designated reservation label to the correspondent cell of table layout.
        /// </summary>
        /// <param name="calendarPanel"></param>
        /// <param name="reserv"></param>
        public void SetReservLabelToPanel(TableLayoutPanel calendarPanel, ReservationLabel reservLbl)
        {
            Reservation reserv = reservLbl.reservation;
            int? reservID = reserv.ReservationID;
            //Find the row number of the resource of the reservation
            int reservRow = FindRowByResourceID(calendarPanel, reserv.ResourceID);
            if (reservRow != -1)
            {
                int columnOfStartDate = FindColumnByDate(calendarPanel, reserv.StartDate); 
                int columnOfEndDate = FindColumnByDate(calendarPanel, reserv.EndDate);
                //if the reservation date is not in the current view
                if (columnOfStartDate == calendarPanel.ColumnCount 
                    || columnOfEndDate == 1)
                {
                    //if an existing reservation is modified out of view then remove the label
                    if(calendarPanel.Controls.Contains(reservLbl))
                    {
                        calendarPanel.Controls.Remove(reservLbl);
                    }
                    return;
                }
                //How many columns does the reservation label occupy
                int colspan = columnOfEndDate - columnOfStartDate;
                if (colspan == 0) return;

                //Add the reservation label to the correct position in the view
                //Suspend layout to prevent the table from being messed up when redrawing reservation label
                calendarPanel.SuspendLayout();
                calendarPanel.SetColumnSpan(reservLbl, colspan);
                if (calendarPanel.Controls.Contains(reservLbl))
                { //existing reservation
                    calendarPanel.SetCellPosition(reservLbl, new TableLayoutPanelCellPosition(columnOfStartDate, reservRow));
                }
                else //new reservation
                {
                    if(reservID == null)
                        reserv.ReservationID = Reservation.maxID++;
                    AddReservation(reserv);
                    //Save the ID to Name property of reservation label as key for search in the future
                    reservLbl.Name = reserv.ReservationID.ToString();
                    calendarPanel.Controls.Add(reservLbl, columnOfStartDate, reservRow);
                }
                reservLbl.Text = reservLbl.ToString();
                //Resume layout to display result on calendar table
                calendarPanel.ResumeLayout();  
            }

        }

        /// <summary>
        /// Delete a reservation label from the calendar view and delete the underlying data as well.
        /// </summary>
        /// <param name="calendarPanel"></param>
        /// <param name="reservLbl"></param>
        public void DeleteReservation(TableLayoutPanel calendarPanel, ReservationLabel reservLbl)
        {
            if (!calendarPanel.Controls.Contains(reservLbl))
            {
                MessageBox.Show("Please save the reservation first.", "Error");
                return;
            }
            this.reservationList.Remove(reservLbl.reservation);
            calendarPanel.Controls.Remove(reservLbl);
        }

        /// <summary>
        /// Clear all reservations from the table and in the data.
        /// </summary>
        /// <param name="calendarPanel"></param>
        public void ClearTableContent(TableLayoutPanel calendarPanel)
        {
            var controlCollection = calendarPanel.Controls;
            //Have to iterate backward manaully because TableLayoutControlCollection is outdated
            for(int i = controlCollection.Count - 1; i >=0; --i)
            {
                if (controlCollection[i] is ReservationLabel)
                    controlCollection.RemoveAt(i);
            }
            this.reservationList.Clear();
        }

        /// <summary>
        /// Find out the column number correspond to a specific date. 
        /// </summary>
        /// <param name="calendarPanel"></param>
        /// <param name="date"></param>
        /// <returns>The column number. If date is not in any column, then return 1 if date too small, return max column number if date is too large. </returns>
        private int FindColumnByDate(TableLayoutPanel calendarPanel, DateTime date)
        {
            for(int col = 1; col < calendarPanel.ColumnCount; col++)
            {
                DateTimeLabel dtLbl = (DateTimeLabel)calendarPanel.GetControlFromPosition(col, 0);
                DateTime lblDate = dtLbl.date;
                if (date.Date > lblDate.Date) continue;
                if (date.Date == lblDate.Date) return col;
                if (date.Date < lblDate.Date) return 1;    
            }
            return calendarPanel.ColumnCount;
        }

        /// <summary>
        /// Find out the row number correspond to a specific resource
        /// </summary>
        /// <param name="calendarPanel"></param>
        /// <param name="resourceID"></param>
        /// <returns>The row number. -1 if not found</returns>
        private int FindRowByResourceID(TableLayoutPanel calendarPanel, int resourceID)
        {
            for(int row = 1; row < calendarPanel.RowCount; row++)
            {
                ResourceLabel resourceLbl = (ResourceLabel)calendarPanel.GetControlFromPosition(0, row);
                if (resourceLbl.resource.ResourceID == resourceID) return row;
            }
            return -1;
        }

        /// <summary>
        /// Decide whether a user input reservation is valid.
        /// </summary>
        /// <param name="reserv"></param>
        /// <param name="message">A string description of the validation result. Provide a hint if reservation is invalid.</param>
        /// <returns>True if valid. False if invalid.</returns>
        public bool ValidateReservation(Reservation reserv, out string message)
        {
            if(reserv.GuestName == "")
            {
                message = "Please enter guest name.";
                return false;
            }
            if(reserv.EndDate <= reserv.StartDate)
            {
                message = "Start date must precede to end date.";
                return false;
            }
            //Use linq to check conflicts with other reservations
            if(this.reservationList
                .Where(r => r.ReservationID != reserv.ReservationID && r.ResourceID == reserv.ResourceID)
                .SkipWhile(r => r.StartDate>=reserv.EndDate || r.EndDate <= reserv.StartDate)
                .Any())
            {
                message = "Date conflict with other reservation";
                return false;
            }

            message = "Success";
            return true;
            
        }

        public void AddReservation(Reservation reserv)
        {
            if(!reservationList.Contains(reserv))
                reservationList.Add(reserv);
        }

        public string GetResourceNameFromID(int resourceID)
        {
            return this.resourceList
                .SingleOrDefault(r => r.ResourceID == resourceID)
                .Name;
        }

    }
}
