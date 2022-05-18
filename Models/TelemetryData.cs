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

    public override string ToString() => $"Telemetry[Mode: {Mode}, Temperature: {Temperature}, Weight: {Weight}]";
}