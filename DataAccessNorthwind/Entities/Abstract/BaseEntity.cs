using DataAccessProjects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessProjects.Entities.Abstract
{
    public abstract class BaseEntity<T>
    {
        public abstract T Id { get; set; }


        private DateTime _createTime = DateTime.Now;
        public DateTime CreateTime { get => _createTime; }


        public DateTime? ModifiedTime { get; set; }
        public DateTime? PassiveTime { get; set; }



        private Status _status = Status.Active;
        public Status Status { get => _status; set => _status = value; }
    }
}
