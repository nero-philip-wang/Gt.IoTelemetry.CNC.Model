namespace Gt.IoTelemetry.CNC.Model;

/// <summary>加工程序：当前运行程序的执行信息。</summary>
public record Program
{
    /// <summary>当前执行的程序名。</summary>
    [MTDataItem]
    public string? ProgramName { get; init; }

    /// <summary>当前执行的程序路径。</summary>
    [MTDataItem]
    public string? ProgramPath { get; init; }

    /// <summary>当前执行行号（从1开始）。</summary>
    [MTDataItem]
    public int? CurrentLineNo { get; init; }

    /// <summary>文件总行数。</summary>
    [MTDataItem]
    public int? TotalLineNo { get; init; }

    /// <summary>当前执行行内容。</summary>
    [MTDataItem]
    public string? CurrentLine { get; init; }
}
