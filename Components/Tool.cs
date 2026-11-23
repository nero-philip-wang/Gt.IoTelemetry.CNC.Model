namespace Gt.IoTelemetry.CNC.Model
{
    /// <summary>刀库与刀具管理信息。</summary>
    public class Tool
    {
        /// <summary>当前刀位号（从 1 开始）。</summary>
        public int? CurrentNo { get; set; }

        /// <summary>下一把刀的刀位号（换刀预约）。</summary>
        public int? NextNo { get; set; }

        /// <summary>当前刀具剩余寿命（% 或剩余分钟数，取决于机床定义）。</summary>
        public double? LifeRemain { get; set; }

        /// <summary>当前刀具长度补偿值（mm）。</summary>
        public double? LengthOffset { get; set; }

        /// <summary>当前刀具半径补偿值（mm）。</summary>
        public double? RadiusOffset { get; set; }
    }
}
