using System;
using System.Collections.Generic;
using System.Text;
using UserInfo.Data.Entities.Base;

namespace UserInfo.Data.Entities
{
    public class User : BaseEntity, ITrackable
    {
        public long UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherInfo { get; set; }
        public string MotherInfo { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdateAt { get; set; }
    }
}
