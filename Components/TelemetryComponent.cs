namespace Gt.IoTelemetry.CNC.Model;

/// <summary>所有可遥测组件的基类：统一携带健康状态与时间信息。</summary>
public abstract record TelemetryComponent
{
    /// <summary>组件健康状态（正常 / 告警 / 故障 / 不可用）。</summary>
    [MTDataItem]
    public ComponentStatus? Status { get; init; }

    /// <summary>当前时间戳（秒级精度，Unix 时间）。</summary>
    [MTDataItem]
    public long? Timestamp { get; init; }

    /// <summary>相对采样基准时刻的偏移量（毫秒），用于同一采样周期内的时间对齐。</summary>
    [MTAttribute]
    public long? TimeOffset { get; init; }
}

/// <summary>组件健康状态，对应 MTConnect Condition 的严重级别。</summary>
public enum ComponentStatus
{
    /// <summary>正常。</summary>
    Normal,

    /// <summary>告警（尚可运行，需要关注）。</summary>
    Warning,

    /// <summary>故障（已影响运行，需要处理）。</summary>
    Fault,

    /// <summary>不可用（无数据或组件离线）。</summary>
    Unavailable
}
