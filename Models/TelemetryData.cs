namespace Telemetry.Models;

/// <summary>
/// Class used for parsing data received from the robot
///
/// TODO: Add more data to log
/// </summary>
public class TelemetryData
{
    public OperationMode? Mode { get; set; }

    public int? Temperature { get; set; }

    public float? Weight { get; set; }
    
    public int? Speed { get; set; }

    public int? Battery { get; set; }
    
    public bool? VacuumCleaner { get; set; }
    
    public override string ToString() => $"Telemetry[Mode: {Mode}, Temperature: {Temperature}, Weight: {Weight}, Speed: {Speed}, Battery: {Battery}, VacuumCleaner {VacuumCleaner}";
}