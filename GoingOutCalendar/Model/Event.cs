using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoingOutCalendar.Model
{
    public class Event

    {
        public string Location { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }

        public string Adress { get; set; }
        public string Description { get; set; }
        public string ID { get; set; }

        public Event
        (
            string location,
            string date,
            string time,
            string adress,
            string description,
            string id
        )
        {
            Location = location;
            Date = date;
            Time = time;
            Adress = Adress;
            Description = description;
            ID = id;
        }
        public Event()
        {
        }


        public static Event _event;

        public void SetEvent()
        {
        }


        public override string ToString()
        {
            return ID + Time + Date + Description + Location + Adress;
        }





        public string GetID()
        {
            return _event.ID;
        }

        public string GetLocation()
        {
            return _event.Location;
        }

        public string GetTime()
        {
            return _event.Time;
        }

        public string GetAdress()
        {
            return _event.Adress;
        }

        public string GetDescription()
        {
            return _event.Description;
        }
    }

}

