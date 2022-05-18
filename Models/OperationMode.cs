namespace Telemetry.Models;

/// <summary>
/// Mode in which the Robot is currently
/// </summary>
public enum OperationMode
{
    /// <summary>
    /// Robot is looking for objects
    /// </summary>
    Autonomous,

    /// <summary>
    /// Robot is being controlled by the controller
    /// </summary>
    Controlled,

    /// <summary>
    /// Robot is driving over obstacle course
    /// </summary>
    ObstacleCourse,

    /// <summary>
    /// Robot is dancing
    /// 
    /// TODO: Distinguish between solo and group dance
    /// </summary>
    Dancing
}