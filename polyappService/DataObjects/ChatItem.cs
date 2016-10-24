using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace polyappService.DataObjects
{
    public class ChatItem : EntityData
    {
        public string Message { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}