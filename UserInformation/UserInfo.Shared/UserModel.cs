using System;
using System.Collections.Generic;
using System.Text;

namespace UserInfo.Shared
{
    public class UserModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherInfo { get; set; }
        public string MotherInfo { get; set; }
    }
}
