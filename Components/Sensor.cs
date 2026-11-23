namespace Gt.IoTelemetry.CNC.Model;

/// <summary>外部传感器基类。</summary>
public record Sensor : TelemetryComponent
{
    /// <summary>测量单位，如 "℃"、"m/s²"、"bar"。</summary>
    [MTAttribute]
    public string? Unit { get; init; }

    /// <summary>测点位置描述，如 "CncMachine.AxisY.Servo"。</summary>
    [MTAttribute]
    public string? MountLocation { get; init; }

    /// <summary>最近一次读数。</summary>
    [MTDataItem]
    public double? Value { get; init; }
}
