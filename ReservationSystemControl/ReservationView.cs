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
            this.theController.SetColumnHeader(startDate: DateTime.Now);
            this.theController.SetRowHeader();
            this.theController.SetTableContent();
        }

    }
}
