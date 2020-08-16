using System;
using System.Collections.Generic;
using System.Text;

namespace UserInfo.Data.Entities.Base
{
    interface IRemovable
    {
        bool IsDeleted { get; set; }
    }
}
