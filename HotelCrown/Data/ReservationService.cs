using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCrown.Data
{
    public class ReservationService
    {
        public int Id { get; set; }
        public int ReservationId { get; set; }
        public int ServiceId { get; set; }
        public int ServiceNumber { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public virtual ICollection<Service> Services { get; set; }
        public ICollection<Reservation> Reservations { get; set; }

    }
}
