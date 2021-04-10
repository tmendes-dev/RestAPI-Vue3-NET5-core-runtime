using System;
using System.Collections.Generic;

namespace Domain.Aggregates
{
    public class DataObject
    {
        public DataObject()
        {
        }

        public DataObject(int iD, string description, DateTime date, List<dynamic> data)
        {
            ID = iD;
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Date = date;
            Data = data ?? throw new ArgumentNullException(nameof(data));
        }

        public int ID { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public List<dynamic> Data { get; set; }
    }
}