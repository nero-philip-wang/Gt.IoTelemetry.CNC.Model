// netstandard2.0 缺少 IsExternalInit 类型定义，此处手动补齐以支持 record / init 访问器
namespace System.Runtime.CompilerServices;

/// <summary>编译器所需的 IsExternalInit 占位类型。</summary>
public static class IsExternalInit
{
}
