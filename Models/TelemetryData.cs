namespace Telemetry.Models;

/// <summary>
/// Class used for parsing data received from the robot
///
/// </summary>
/// All Telemetry data
public class TelemetryData
{
    // Mode in which the robot operates
    public OperationMode? Mode { get; set; }

    // The temperature of the Raspberry Pi
    public int? Temperature { get; set; }

    // The measured weight that is placed on the loadcells
    public float? Weight { get; set; }
    
    // The speed of the robot in meters per second
    public int? Speed { get; set; }

    // The remaining battery capacity
    public int? Battery { get; set; }
    
    // The state of the vacuumcleaner
    public bool? VacuumCleaner { get; set; }
    
    // Data String
    public override string ToString() => $"Telemetry[Mode: {Mode}, Temperature: {Temperature}, Weight: {Weight}, Speed: {Speed}, Battery: {Battery}, VacuumCleaner {VacuumCleaner}";
}