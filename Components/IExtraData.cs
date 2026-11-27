using System;
using System.Collections.Generic;
using System.Text;

namespace Gt.IoTelemetry.CNC.Model
{
    public interface IExtraData
    {
        IDictionary<string, object> ExtraData { get; }
    }
}