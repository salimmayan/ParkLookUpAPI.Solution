namespace ParkLookUpAPI.Models
{
  public class Park
  {
    public int ParkId {get; set;}
    public string Name {get; set;}
    public string State {get; set;}
    public int Area {get; set;}
    public string City {get; set;}
    public bool Open {get; set;} 
  }
}