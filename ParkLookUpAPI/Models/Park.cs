using System.ComponentModel.DataAnnotations;

namespace ParkLookUpAPI.Models
{
  public class Park
  {
    public int ParkId {get; set;}
     [Required]
    public string Name {get; set;}
     [Required]
    public string State {get; set;}
    [Required]
    public int Area {get; set;}
    [Required]
    public string City {get; set;}
    [Required]
    public bool IsOpen {get; set;} 
    // [Required]
  }
}