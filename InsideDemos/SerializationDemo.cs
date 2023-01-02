using InsideDotNet.DataContracts;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.IO;

namespace InsideDotNet.InsideDemos
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

        public EventTypes DeserializeEventById()
        {
            string json = @"{
                              'EventTypeId': 2,
                              'EventTypeName': 'Event_Type_Suspicious_Vehicle',
                              'ParentId': -1,
                              'TermId': 40,
                              'DateCreated': '2011-02-03T13:24:39.013',
                              'DateModified': '2011-02-03T13:24:39.013',
                              'ChangedBy': '-1',
                              'CITguid': '5A96B7D5-9A79-4466-BB2D-4FD69D4C32EB',
                              'ConfigVersion': -1
                            }";

            EventTypes events = JsonConvert.DeserializeObject<EventTypes>(json);

            return events;
        }


        public string SerializeEvents(EventItems events)
        {
            var eventsString = JsonConvert.SerializeObject(events, Formatting.Indented);
            return eventsString;
        }

        public string SerializeEventById(EventTypes eventObj)
        {
            var eventsString = JsonConvert.SerializeObject(eventObj, Formatting.Indented);
            return eventsString;
        }
    }
}