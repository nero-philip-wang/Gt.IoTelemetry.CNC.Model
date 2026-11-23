namespace Gt.IoTelemetry.CNC.Model;

/// <summary>
/// 机床动态数据项标记：标识随加工过程实时变化的遥测采样值，
/// 如位置、转速、负载、温度等。对应 MTConnect 的 Samples 类数据。
/// </summary>
[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
public class MTDataItemAttribute : Attribute
{
}
