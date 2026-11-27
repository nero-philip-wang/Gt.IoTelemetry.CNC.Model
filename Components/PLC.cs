namespace Gt.IoTelemetry.CNC.Model
{
    /// <summary>PLC 侧开关量信号：卡盘、安全门、急停、冷却等外围状态。</summary>
    public class PLC
    {
        /// <summary>卡盘是否夹紧（true = 已夹紧）。</summary>
        [MTDataItem]
        public bool? ChuckClamp { get; set; }

        /// <summary>安全门是否关闭（true = 已关闭）。</summary>
        [MTDataItem]
        public bool? DoorClosed { get; set; }

        /// <summary>急停是否触发（true = 急停激活）。</summary>
        [MTDataItem]
        public bool? EmergencyStop { get; set; }

        /// <summary>冷却液是否开启。</summary>
        [MTDataItem]
        public bool? CoolantOn { get; set; }
    }
}