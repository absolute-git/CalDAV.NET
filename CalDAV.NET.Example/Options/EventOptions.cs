using CommandLine;

namespace CalDAV.NET.Example.Options
{
    public class EventOptions : CalendarOptions
    {
        [Value(0, MetaName = "event", Required = true)]
        public string Event { get; set; }
    }
}
