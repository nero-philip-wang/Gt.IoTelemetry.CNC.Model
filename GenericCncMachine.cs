namespace Gt.IoTelemetry.CNC.Model;

/// <summary>机床抽象基类：聚合所有遥测单元。</summary>
public record GenericCncMachine : TelemetryComponent
{
    /// <summary>设备唯一标识（IoT 平台侧的设备 ID）。</summary>
    [MTAttribute]
    public string DeviceId { get; init; } = string.Empty;

    /// <summary>设备显示名称。</summary>
    [MTAttribute]
    public string DeviceName { get; init; } = string.Empty;

    /// <summary>机床元数据：型号、版本与轴配置等静态信息。</summary>
    [MTAttribute]
    public Metadata Metadata { get; init; } = new Metadata();

    /// <summary>人机界面（HMI）状态。</summary>
    public HMI HMI { get; init; } = new HMI();

    /// <summary>数控系统控制器运行态。</summary>
    public Controller Controller { get; init; } = new Controller();

    /// <summary>当前执行的加工程序信息。</summary>
    public Program Program { get; init; } = new Program();

    /// <summary>主轴遥测。</summary>
    public Spindle Spindle { get; init; } = new Spindle();

    /// <summary>刀具与刀库信息。</summary>
    public Tool Tool { get; init; } = new Tool();

    /// <summary>PLC 开关量信号。</summary>
    public PLC PLC { get; init; } = new PLC();

    /// <summary>X 直线轴。</summary>
    public Axis AxisX { get; init; } = new Axis();

    /// <summary>Y 直线轴。</summary>
    public Axis AxisY { get; init; } = new Axis();

    /// <summary>Z 直线轴。</summary>
    public Axis AxisZ { get; init; } = new Axis();

    /// <summary>A 旋转轴（绕 X），未配置时字段仍在、内容为空。</summary>
    public Axis? AxisA { get; init; }

    /// <summary>B 旋转轴（绕 Y），未配置时字段仍在、内容为空。</summary>
    public Axis? AxisB { get; init; }

    /// <summary>C 旋转轴（绕 Z），未配置时字段仍在、内容为空。</summary>
    public Axis? AxisC { get; init; }

    /// <summary>外挂传感器列表（振动、温度等额外测点）。</summary>
    public IReadOnlyList<Sensor> Sensors { get; init; } = new List<Sensor>();
}
