using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCrown.Data
{
    
    public class Feature
    {
        
        public int Id { get; set; }
        [Required]
        public string FeatureName { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
    }
}
