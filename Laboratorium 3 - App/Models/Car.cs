using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium_3___App.Models
{
    public class Car
    {
        // model, producent, pojemność silnika, moc, rodzaj silnika, nr rejestracyjny, właściciel
        [HiddenInput] public int Id { get; set; }

        [Required(ErrorMessage = "Podaj model")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Podaj producenta")]
        public string Producer { get; set; }

        public string EngineCapacity { get; set; }

        [Required(ErrorMessage = "Podaj moc silnika")]
        public string Power { get; set; }

        [Required(ErrorMessage = "Podaj typ silnika")]
        public string EngineType { get; set; }

        [Required(ErrorMessage = "Podaj nr rejestracyjny")]
        public string LicencePlate { get; set; }

        [Required(ErrorMessage = "Podaj właściciela")]
        public string Owner { get; set; }
    }
}