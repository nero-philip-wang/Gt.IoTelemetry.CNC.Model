using Microsoft.Extensions.Logging;

namespace Gt.IoTelemetry.CNC.Model;

/// <summary>控制器：程序、模式、倍率等运行态遥测。</summary>
public record Controller : TelemetryComponent
{
    /// <summary>执行状态：运行 / 就绪 / 停止。</summary>
    [MTDataItem]
    public ExecutionState? Execution { get; init; }

    /// <summary>操作模式：自动 / 手动 / MDI。</summary>
    [MTDataItem]
    public ControllerMode? Mode { get; init; }

    /// <summary>进给倍率（%）。</summary>
    [MTDataItem]
    public double? FeedOverride { get; init; }

    /// <summary>主轴倍率（%）。</summary>
    [MTDataItem]
    public double? SpindleOverride { get; init; }

    /// <summary>当前生效的报警数量。</summary>
    [MTDataItem]
    public int? NumOfAlarms { get; init; }

    /// <summary>当前生效的报警代码列表（逗号分隔）。</summary>
    [MTDataItem]
    public string? ActiveAlarmsCode { get; init; }

    /// <summary>当前生效的报警文本描述。</summary>
    [MTDataItem]
    public string? ActiveAlarmsText { get; init; }

    /// <summary>最高报警级别。</summary>
    [MTDataItem]
    public LogLevel? MaxAlarmLevel { get; init; }
}

/// <summary>数控系统执行状态。</summary>
public enum ExecutionState
{
    /// <summary>程序执行中。</summary>
    Active,

    /// <summary>就绪（可启动）。</summary>
    Ready,

    /// <summary>已停止。</summary>
    Stopped,

    /// <summary>执行被中断（如进给保持）。</summary>
    Interrupted,

    /// <summary>紧急停止</summary>
    Emergency
}

/// <summary>数控系统操作模式。</summary>
public enum ControllerMode
{
    /// <summary>自动模式（执行加工程序）。</summary>
    Automatic,

    /// <summary>手动模式（手轮/手动进给）。</summary>
    Manual,

    /// <summary>MDI 模式（单段指令输入）。</summary>
    Mdi,

    /// <summary>编辑模式（程序编辑）。</summary>
    Edit
}