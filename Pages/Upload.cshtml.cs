using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Telemetry.Models;

namespace Telemetry.pages;

[IgnoreAntiforgeryToken]
public class Upload : PageModel
{
    public static TelemetryData? Last { get; private set; }
    
    /// <summary>
    /// Telemetry data received during post request
    /// </summary>
    [BindProperty] public TelemetryData? Data { get; set; }

    /// <summary>
    /// Called by the Robot to upload telemetry data
    /// </summary>
    /// <returns></returns>
    public async Task<IActionResult> OnPostAsync()
    {
        // Check if data is set
        if (Data == null) return StatusCode(400);
        Last = Data;
        
        // TODO: Write to database
        Console.WriteLine("Data: {0}", Data);

        return StatusCode(200);
    }
}