﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProcessTracing.Services.ViewModels
{
   
    public class ListViewModel
    {
        public string Id { get; set;}
        public string Name { get; set; }
        public bool Closed { get; set; }
        public string IdBoard { get; set; }
        public float Pod { get; set; }
        public bool Subscribed { get; set; }
    }
}