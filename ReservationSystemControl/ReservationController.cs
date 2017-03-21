using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystemControl
{
    class ReservationController
    {
        private ReservationView calendarView;
        private List<Reservation> reservationList;

        public ReservationController(ReservationView newView)
        {
            this.calendarView = newView;
            this.reservationList = this.loadReservations();
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
            list.Add(new Reservation(1, DateTime.Now, 0, "John"));
            return list;
        }
    }
}
