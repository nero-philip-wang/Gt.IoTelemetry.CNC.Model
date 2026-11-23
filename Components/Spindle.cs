namespace Gt.IoTelemetry.CNC.Model;

/// <summary>主轴：切削动力源，不计入"五轴"计数。</summary>
public record Spindle : TelemetryComponent
{
    /// <summary>指令转速（rpm）。</summary>
    [MTDataItem]
    public double? CommandedSpeed { get; init; }

    /// <summary>实际转速（rpm）。</summary>
    [MTDataItem]
    public double? ActualSpeed { get; init; }

    /// <summary>主轴负载百分比（%），刀具磨损与切削异常的关键信号。</summary>
    [MTDataItem]
    public double? LoadPercent { get; init; }

    /// <summary>主轴电机电流（A）。</summary>
    [MTDataItem]
    public double? Current { get; init; }

    /// <summary>主轴驱动电压（V）。</summary>
    [MTDataItem]
    public double? Voltage { get; init; }

    /// <summary>轴承温度（℃），热变形与轴承健康指标。</summary>
    [MTDataItem]
    public double? BearingTemperature { get; init; }

    /// <summary>振动 RMS（m/s²），对刀具破损、颤振、轴承故障敏感。</summary>
    [MTDataItem]
    public double? VibrationRms { get; init; }

    /// <summary>刀具接口标准。</summary>
    [MTAttribute]
    public ToolInterface? ToolInterface { get; init; }
}

/// <summary>刀具接口标准。</summary>
public enum ToolInterface
{
    /// <summary>BT 锥柄（日本标准）。</summary>
    BT,

    /// <summary>HSK 短锥空心柄（高速主轴常用）。</summary>
    HSK,

    /// <summary>CAT 锥柄（美国标准，V-flange）。</summary>
    CAT
}
