using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RezerwacjaBiletow.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Miejsce")]
        public int Seat { get; set; }


        public string UserID { get; set; }
        public int EventID{ get; set; }


        public virtual Event Event { get; set;}
        


    }
}