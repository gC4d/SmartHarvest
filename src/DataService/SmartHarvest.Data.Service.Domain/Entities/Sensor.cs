using SmartHarvest.Data.Service.Domain.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHarvest.Data.Service.Domain.Entities
{
    public class Sensor : BaseEntity
    {
        public string Name { get; private set ; } 
        public string Port { get; private set ; }

        public Sensor(IIdGenerator idGenerator, string name, string port) 
        {
            Id = idGenerator.GenerateId();
            Name = name;
            Port = port;
        }
    }
}
