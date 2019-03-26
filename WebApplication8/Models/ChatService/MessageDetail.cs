﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication8.Models.ChatService
{
    public class MessageDetail
    {

        public string UserName { get; set; }
        public string Message { get; set; }
        public string ConnectionId { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public int IsAdmin { set; get; }

    }
}
