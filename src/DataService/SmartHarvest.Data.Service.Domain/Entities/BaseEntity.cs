using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHarvest.Data.Service.Domain.Entities
{
    abstract public class BaseEntity
    {
        public string Id { get; protected set; }
    }
}
