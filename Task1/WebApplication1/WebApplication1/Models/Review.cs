﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Review
    {      
            public int Id { get; set; }

            public DateTime Date { get; set; }

            public string Text { get; set; }

            public string Author { get; set; }
    }
}