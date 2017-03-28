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

        public ReservationView()
        {
            InitializeComponent();
            theController = new ReservationController(this);
            theController.SetColumnHeader(this.calendarPanel);
            theController.SetRowHeader(this.calendarPanel);
            theController.SetTableContent(this.calendarPanel);
            foreach(Control control in this.calendarPanel.Controls)
            {
                control.MouseClick += ControlLbl_Click;
            }
        }

        private void ControlLbl_Click(object sender, MouseEventArgs e)
        {
            if(sender is ReservationLabel)
            {
                currentReservLbl = sender as ReservationLabel;
                currentReservation = currentReservLbl.reservation;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            currentReservation.GuestName = txtCustomer.Text;
            currentReservation.StartDate = dateStart.Value;
            currentReservation.EndDate = dateEnd.Value;
            string message;
            if(theController.ValidateReservation(currentReservation, out message))
            {
                theController.ModifyReservation(currentReservation);
                MessageBox.Show(message);
                theController.SetReservLabelToPanel(this.calendarPanel, this.currentReservLbl);
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("All reservations will be cleared. This operation is not reversible. Are you sure?", "Warning", MessageBoxButtons.OKCancel)
                == DialogResult.OK)
            {
                theController.ClearTableContent(this.calendarPanel);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete this reservation?", "Warning", MessageBoxButtons.OKCancel) 
                == DialogResult.OK)
            {
                theController.DeleteReservation(this.calendarPanel, currentReservLbl);
            }
        }

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

            this.txtCustomer.Enabled = true;
            this.dateEnd.Enabled = true;
            this.dateStart.Enabled = true;
            this.btnSave.Enabled = true;
            this.btnDelete.Enabled = true;
        }
    }
}
