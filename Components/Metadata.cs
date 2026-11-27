namespace Gt.IoTelemetry.CNC.Model;

/// <summary>机床元数据：型号、版本与轴配置等静态描述信息。</summary>
public class Metadata
{
    /// <summary>机床系列名称（型号），如 "VMC-850"。</summary>
    [MTAttribute]
    public string SeriesName { get; set; } = string.Empty;

    /// <summary>数控系统或机型版本号。</summary>
    [MTAttribute]
    public string Version { get; set; } = string.Empty;

    /// <summary>受控轴总数（不含主轴）。</summary>
    [MTAttribute]
    public int AxisNo { get; set; }

    /// <summary>各受控轴名称列表，如 ["X", "Y", "Z"]。</summary>
    [MTAttribute]
    public string[] AxisNameList { get; set; } = Array.Empty<string>();
}