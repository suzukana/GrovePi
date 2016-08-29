using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrovePi.Sensors
{
    public interface IPIRMotionSensor
    {
        SensorStatus CurrentState { get; }
    }

    internal class PIRMotionSensor : Sensor<IPIRMotionSensor>, IPIRMotionSensor
    {
        internal PIRMotionSensor(IGrovePi device, Pin pin) : base(device, pin, PinMode.Input)
        {
        }
    }
}
