using Talk.EventStore;
using Talk.Messages.Sensor;

namespace Talk.EsBase.Commands.Modules.Sensors
{
    public static class EventMapping
    {
        public static void Map()
        {
            TypeMapper.Map<Events.SensorInstalled>("SensorInstalled");
            TypeMapper.Map<Events.SensorTelemetryReceived>("SensorTelemetryReceived");
        }
    }
}