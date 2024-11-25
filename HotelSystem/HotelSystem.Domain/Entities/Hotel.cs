using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Domain.Entities
{
    public class Hotel
    {
        public Hotel() { }
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
