using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCrown.Data
{
    public class Reservation
    {
       
        [Required]
        public int Id { get; set; }
        [Required]
        public int RoomId { get; set; }
        [Required]
        public int RoomNumber { get; set; }
        [Required]
        public DateTime CheckInDate { get; set; }
        [Required]
        public DateTime CheckOutDate { get; set; }
        public DateTime CheckedInTime { get; set; }
        public DateTime CheckedOutTime { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<ReservationService> ReservationServices { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
    }
}
