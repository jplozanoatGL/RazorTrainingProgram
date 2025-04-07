public class WeatherReport
{
    public int Id { get; set; }
    public string City { get; set; }
    public string Condition { get; set; }
    public float Temperature { get; set; }
    public DateTime ReportDate { get; set; } = DateTime.Now;
}