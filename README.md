# CNC.Model

CNC（数控机床）遥测数据模型类库。定义机床运行态的统一数据结构，用于 IoT 采集、边缘网关与上位系统之间的数据交换。

## 特性

- 面向 `net8.0` / `net10.0`，可被 .NET 8 / .NET 10 项目引用
- 全部模型使用 `record` + `init`，不可变、便于序列化
- 属性分为两类，通过特性标记区分：
  - `[MTDataItem]` —— 动态遥测采样值（位置、转速、负载、温度等），随加工过程实时变化
  - `[MTAttribute]` —— 静态描述信息（轴名、行程范围、接口标准等），低频变化
- 所有可空属性（`T?`）表示"该数据项当前不可用或未采集"，反序列化时无需提供全部字段

## 模型结构

```
GenericCncMachine（机床聚合根，继承 TelemetryComponent）
├── Metadata        机床元数据：型号、版本、轴配置（静态）
├── HMI             人机界面状态：键盘、屏幕
├── Controller      控制器运行态：执行状态、模式、倍率、报警
├── Program         当前加工程序：程序名/路径/行号
├── Spindle         主轴：转速、负载、电流、轴承温度、振动
├── Tool            刀具与刀库：刀位号、剩余寿命、长度/半径补偿
├── PLC             PLC 开关量：卡盘、安全门、急停、冷却液
├── AxisX/Y/Z       直线轴遥测：位置、速度、伺服电流、跟随误差
├── AxisA/B/C       旋转轴遥测（未配置的轴内容为空）
└── Sensors         外挂传感器列表：测点、单位、读数
```

`TelemetryComponent` 是所有可遥测组件的基类，统一携带：

| 属性 | 说明 |
| --- | --- |
| `Status` | 组件健康状态（`Normal` / `Warning` / `Fault` / `Unavailable`），对应 MTConnect Condition 严重级别 |
| `Timestamp` | 采样时间戳（秒级 Unix 时间） |
| `TimeOffset` | 相对采样基准时刻的偏移（毫秒），用于同一周期内时间对齐 |

## 使用示例

```csharp
using Gt.IoTelemetry.CNC.Model;

var machine = new GenericCncMachine
{
    DeviceId = "cnc-001",
    DeviceName = "车间一号机",
    Metadata = new Metadata
    {
        SeriesName = "VMC-850",
        Version = "FANUC 0i-MF",
        AxisNo = 3,
        AxisNameList = new[] { "X", "Y", "Z" }
    },
    Controller = new Controller
    {
        Execution = ExecutionState.Active,
        Mode = ControllerMode.Automatic,
        FeedOverride = 100
    },
    Program = new Program
    {
        ProgramName = "O1001",
        CurrentLineNo = 128,
        TotalLineNo = 456
    },
    Spindle = new Spindle
    {
        ActualSpeed = 8000,
        LoadPercent = 45.5,
        BearingTemperature = 38.2
    },
    AxisX = new Axis
    {
        Name = AxisName.X,
        Kind = AxisKind.Linear,
        Position = 125.6,
        IsHomed = true
    },
    Timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds()
};
```

## 构建

```bash
dotnet build
```

## 目录说明

```
├── Attribute/               MTAttribute / MTDataItem 标记特性
├── Components/              机床各组成部分的遥测模型
├── GenericCncMachine.cs     机床聚合根
└── Gt.IoTelemetry.CNC.Model.csproj
```

## 备注

- 项目使用 `<LangVersion>latest</LangVersion>`，代码使用了 C# 10 的文件级命名空间等特性。
