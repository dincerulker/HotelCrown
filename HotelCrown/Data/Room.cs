using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCrown.Data
{
    public class Room
    {

        public int Id { get; set; }
        [Required]
        public string RoomName { get; set; }
        [Required]
        public int Capacity { get; set; }
        [Required]
        public decimal Price { get; set; }
        public virtual ICollection<Feature> Features { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
