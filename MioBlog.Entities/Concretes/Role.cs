using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MioBlog.Core.Entities;

namespace MioBlog.Entities.Concretes
{
    public class Role : IEntity
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        
    }
}
