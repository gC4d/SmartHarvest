using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHarvest.Data.Service.Domain.Entities
{
    public class SensorData : BaseEntity
    {
        public decimal Temperature { get; private set; }
        public decimal Humidity { get; private set; }
        public DateTime CollectionDate { get; private set; }

        public SensorData(decimal temperature, decimal humidity, DateTime collectionDate)
        {
            Temperature = temperature;
            Humidity = humidity;
            CollectionDate = collectionDate;
        }
    }
}
