namespace Gt.IoTelemetry.CNC.Model;

/// <summary>
/// 机床静态属性标记：标识不会随加工过程高频变化的设备描述信息，
/// 如轴名、轴类型、行程范围、刀具接口等。对应 MTConnect 的 Description / Configuration 类数据。
/// </summary>
[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
public class MTAttributeAttribute : Attribute
{
}
