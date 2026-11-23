namespace Gt.IoTelemetry.CNC.Model;

/// <summary>人机界面：提供用户交互和反馈。</summary>
public record HMI : TelemetryComponent
{
    /// <summary>键盘/操作面板状态。</summary>
    public KeyboardStatus? KeyboardStatus { get; init; }

    /// <summary>显示屏状态。</summary>
    public ScreenStatus? ScreenStatus { get; init; }
}

/// <summary>键盘/操作面板状态。</summary>
public enum KeyboardStatus
{
    /// <summary>正常。</summary>
    Normal,

    /// <summary>按键卡滞。</summary>
    Stuck
}

/// <summary>显示屏状态。</summary>
public enum ScreenStatus
{
    /// <summary>显示正常。</summary>
    Normal,

    /// <summary>屏幕闪烁。</summary>
    ScreenFlicker,

    /// <summary>黑屏。</summary>
    BlackScreen,

    /// <summary>乱码。</summary>
    UnreadableCharacters,

    /// <summary>系统崩溃。</summary>
    Crash,

    /// <summary>死机卡滞。</summary>
    Stuck
}
