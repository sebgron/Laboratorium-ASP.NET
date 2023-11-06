using System.ComponentModel.DataAnnotations;

namespace Laboratorium_3___App.Models;

public enum CarEngineTypes
{
    [Display(Name = "Diesela")]Diesla = 1, 
    [Display(Name = "Benzynowy")]Benzynowy = 2, 
    [Display(Name = "Hybrydowy")]Hybrydowy = 3,
    [Display(Name = "Elektryczny")]Elektryczny = 4 

}