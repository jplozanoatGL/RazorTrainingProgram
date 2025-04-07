using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class ReportModel : PageModel
{
    public List<WeatherReport> WeatherReports { get; set; }

    public void OnGet()
    {
        // TODO: Initialize WeatherReports with sample data
        WeatherReports = new List<WeatherReport>
        {
            new WeatherReport { Id = 1, City="La Plata", ReportDate =  DateTime.Now, Temperature = 25, Condition = "Sunny" },
            new WeatherReport { Id = 2, City="Buenos Aires", ReportDate =  DateTime.Now, Temperature = 22, Condition = "Cloudy" },
            new WeatherReport { Id = 3, City="Rosario", ReportDate =  DateTime.Now, Temperature = 20, Condition = "Rainy" }
        };
    }
}