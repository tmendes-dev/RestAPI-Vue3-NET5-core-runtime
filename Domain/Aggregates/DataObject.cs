using System;
using System.Collections.Generic;

namespace Domain.Aggregates
{
    public class DataObject
    {
        public DataObject()
        {
        }

        public DataObject(int iD, string description, DateTime date, decimal value)
        {
            ID = iD;
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Date = date;
            Value = value;
        }

        public int ID { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public decimal Value { get; set; }
    }
}