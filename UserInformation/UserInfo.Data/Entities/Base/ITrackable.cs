using System;
using System.Collections.Generic;
using System.Text;

namespace UserInfo.Data.Entities.Base
{
    public interface ITrackable
    {
        DateTime CreatedAt { get; set; }
        DateTime LastUpdateAt { get; set; }
    }
}
