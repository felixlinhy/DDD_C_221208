namespace Together.Domain.Entity;

public class EventAddResult{
    public Guid Id {get; set}= Guid.NewGuid();
    public string? Name {get; set;};
    public string? Coordinator {get; set;} = null;
    public string? Place {get;set;}=null;
    public float Lat;
    public float Lng;
    public int Fee;
}