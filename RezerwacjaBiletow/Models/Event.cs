using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RezerwacjaBiletow.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Wydarzenie")]
        public string Title { get; set; }
        [DisplayName("Opis")]
        public string Description { get; set; }
        [Required]
        [DisplayName("Miejsce")]
        public string Place { get; set; }
        [Required]
        [DisplayName("Liczba miejsc")]
        public int Seats { get; set; }
        [Required]
        [DisplayName("Cena")]
        public double Price { get; set; }


        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("Data")]
        public DateTime Date { get; set; }
        
        [DisplayName("Zarezerwowane bilety")]
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}