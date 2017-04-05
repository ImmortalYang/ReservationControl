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
        private ReservationLabel currentReservLbl;
        private Reservation currentReservation;
        //The first column of date in the calendar
        private DateTime currentCalendarDate = DateTime.Today;

        /// <summary>
        /// Initialize an instance of ReservationView
        /// </summary>
        public ReservationView()
        {
            InitializeComponent();
            //Initialize the calendar
            theController = new ReservationController(this);
            theController.SetColumnHeader(this.calendarPanel, currentCalendarDate);
            theController.SetRowHeader(this.calendarPanel);
            theController.SetTableContent(this.calendarPanel);
            foreach(Control control in this.calendarPanel.Controls)
            {
                control.MouseClick += ControlLbl_Click;
            }
        }

        /// <summary>
        /// Event triggered when a control on the table is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ControlLbl_Click(object sender, MouseEventArgs e)
        {
            //Labels apart from reservation labels should not respond
            if(sender is ReservationLabel)
            {
                currentReservLbl = sender as ReservationLabel;
                currentReservation = currentReservLbl.reservation;
                //Display the selected reservation information in the edit panel
                this.lblResource.Text = theController.GetResourceNameFromID(currentReservation.ResourceID);
                this.txtCustomer.Text = currentReservation.GuestName;
                this.txtCustomer.Enabled = true;
                this.dateStart.Value = currentReservation.StartDate;
                this.dateStart.Enabled = true;
                this.dateEnd.Value = currentReservation.EndDate;
                this.dateEnd.Enabled = true;
                this.btnSave.Enabled = true;
                this.btnDelete.Enabled = true;
            }
        }

        /// <summary>
        /// The save button on the edit panel is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            Reservation tempNewReserv = new Reservation(currentReservation);
            tempNewReserv.GuestName = txtCustomer.Text;
            tempNewReserv.StartDate = dateStart.Value;
            tempNewReserv.EndDate = dateEnd.Value;
            string message;
            //Validate current reservation
            if(theController.ValidateReservation(tempNewReserv, out message))
            {
                //success
                MessageBox.Show(message);
                currentReservation = tempNewReserv;
                currentReservLbl.reservation = currentReservation;
                //change the calendar table
                theController.SetReservLabelToPanel(this.calendarPanel, this.currentReservLbl);
                //change the data
                theController.ModifyReservation(currentReservation);
            }
            else
            {
                //fail
                MessageBox.Show(message);
            }
        }

        /// <summary>
        /// The clear button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("All reservations will be cleared. This operation is not reversible. Are you sure?", "Warning", MessageBoxButtons.OKCancel)
                == DialogResult.OK)
            {
                //Clear labels
                theController.ClearTableContent(this.calendarPanel);
                //Clear data
                theController.ClearReservations();
                this.ClearEditPanel();
            }
        }

        /// <summary>
        /// The delete button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete this reservation?", "Warning", MessageBoxButtons.OKCancel) 
                == DialogResult.OK)
            {
                theController.DeleteReservation(this.calendarPanel, currentReservLbl);
            }    
        }

        /// <summary>
        /// An empty cell on the table is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calendarPanel_MouseClick(object sender, MouseEventArgs e)
        {
            Point? position = calendarPanel.GetRowColIndex(new Point(e.X, e.Y));
            if (position == null || position.Value.X == 0 || position.Value.Y == 0) return;
            int resourceID = position.Value.Y - 1;
            DateTimeLabel dtLbl = calendarPanel.GetControlFromPosition(position.Value.X, 0) as DateTimeLabel;
            DateTime startDate = dtLbl.date;
            DateTime endDate = startDate.AddDays(1);
            this.lblResource.Text = theController.GetResourceNameFromID(resourceID);
            this.txtCustomer.Text = "";
            this.dateStart.Value = startDate;
            this.dateEnd.Value = endDate;
            this.currentReservation = new Reservation(resourceID, startDate, endDate);
            this.currentReservLbl = new ReservationLabel(currentReservation);
            currentReservLbl.MouseClick += this.ControlLbl_Click;
            //Enable editing
            this.txtCustomer.Enabled = true;
            this.dateEnd.Enabled = true;
            this.dateStart.Enabled = true;
            this.btnSave.Enabled = true;
            this.btnDelete.Enabled = true;
        }

        /// <summary>
        /// Scroll the calendar by specified number of days
        /// </summary>
        /// <param name="days">Number of days, can be positive and negative</param>
        private void ScrollCalendarView(int days)
        {
            this.calendarPanel.SuspendLayout();
            this.currentCalendarDate = this.currentCalendarDate.AddDays(days);
            theController.SetColumnHeader(this.calendarPanel, this.currentCalendarDate);
            theController.ClearTableContent(this.calendarPanel);
            theController.SetTableContent(this.calendarPanel);
            foreach (Control control in this.calendarPanel.Controls)
            {
                control.MouseClick += ControlLbl_Click;
            }
            this.calendarPanel.ResumeLayout();
        }

        /// <summary>
        /// Scroll the calendar one day backward
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrevDay_Click(object sender, EventArgs e)
        {
            this.ScrollCalendarView(days: -1);
        }

        /// <summary>
        /// Scroll the calendar one day forward
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNextDay_Click(object sender, EventArgs e)
        {
            this.ScrollCalendarView(days: 1);
        }

        /// <summary>
        /// Scroll the calendar 7 days backward
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrevWeek_Click(object sender, EventArgs e)
        {
            this.ScrollCalendarView(days: -7);
        }

        /// <summary>
        /// Scroll the calendar 7 days forward
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNextWeek_Click(object sender, EventArgs e)
        {
            this.ScrollCalendarView(days: 7);
        }

        /// <summary>
        /// Clear the edit panel
        /// </summary>
        public void ClearEditPanel()
        {
            this.txtCustomer.Text = "";
            this.dateStart.Value = DateTime.Today;
            this.dateEnd.Value = DateTime.Today.AddDays(1);
            this.txtCustomer.Enabled = false;
            this.dateEnd.Enabled = false;
            this.dateStart.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnDelete.Enabled = false;
            this.currentReservation = null;
            this.currentReservLbl = null;
        }
    }
}
