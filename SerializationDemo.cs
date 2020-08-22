using InsideDotNet.DataContracts;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.IO;

namespace InsideDotNet
{
    public class EventItems
    {
        public ObservableCollection<EventTypes> EventTypes { get; set; }
    }

    public class SerializationDemo
    {
        public EventItems DeserializeEvents()
        {
            using (StreamReader reader = new StreamReader(@"DataModels\event-types.json"))
            {
                string jsonString = reader.ReadToEnd();
                var events = (EventItems)JsonConvert.DeserializeObject(jsonString, typeof(EventItems));

                return events;
            }
        }

        public string SerializeEvents(EventItems events)
        {
            var eventsString = JsonConvert.SerializeObject(events);
            return eventsString;
        }
    }
}