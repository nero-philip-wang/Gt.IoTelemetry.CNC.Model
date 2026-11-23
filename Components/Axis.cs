namespace Gt.IoTelemetry.CNC.Model;

/// <summary>进给轴基类。直线轴与旋转轴共享的位置/伺服遥测。</summary>
public record Axis : TelemetryComponent
{
    /// <summary>轴类型：直线或旋转。</summary>
    [MTAttribute]
    public AxisKind? Kind { get; init; }

    /// <summary>轴名："X" / "Y" / "Z" / "A" / "B" / "C"。</summary>
    [MTAttribute]
    public AxisName? Name { get; init; }

    /// <summary>轴所属坐标系。</summary>
    [MTAttribute]
    public string? CoordinateSystem { get; init; }

    /// <summary>当前位置（直线轴单位 mm，旋转轴单位 degree）。</summary>
    [MTDataItem]
    public double? Position { get; init; }

    /// <summary>轴是否已回参考点。</summary>
    [MTDataItem]
    public bool? IsHomed { get; init; }

    /// <summary>轴位置范围的最小值（直线轴单位 mm，旋转轴单位 degree）。</summary>
    [MTAttribute]
    public double? PositionMin { get; init; }

    /// <summary>轴位置范围的最大值（直线轴单位 mm，旋转轴单位 degree）。</summary>
    [MTAttribute]
    public double? PositionMax { get; init; }

    /// <summary>当前速度（mm/min 或 deg/min）。</summary>
    [MTDataItem]
    public double? Velocity { get; init; }

    /// <summary>当前加速度（mm/s² 或 deg/s²）。</summary>
    [MTDataItem]
    public double? Acceleration { get; init; }

    /// <summary>伺服电机电流（A），反映负载与切削阻力。</summary>
    [MTDataItem]
    public double? ServoCurrent { get; init; }

    /// <summary>伺服负载百分比（%）。</summary>
    [MTDataItem]
    public double? LoadPercent { get; init; }

    /// <summary>跟随误差：指令位置与实际位置之差，反映动态响应。</summary>
    [MTDataItem]
    public double? FollowingError { get; init; }
}

/// <summary>轴类型。</summary>
public enum AxisKind
{
    /// <summary>直线轴（X / Y / Z）。</summary>
    Linear,

    /// <summary>旋转轴（A / B / C）。</summary>
    Rotary
}

/// <summary>轴名。</summary>
public enum AxisName
{
    /// <summary>X 直线轴。</summary>
    X,

    /// <summary>Y 直线轴。</summary>
    Y,

    /// <summary>Z 直线轴。</summary>
    Z,

    /// <summary>绕 X 旋转轴。</summary>
    A,

    /// <summary>绕 Y 旋转轴。</summary>
    B,

    /// <summary>绕 Z 旋转轴。</summary>
    C
}
