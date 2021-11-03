﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace CardsFullStack.Models
{
    [Table("Deck")]
    public class Deck
    {
        [ExplicitKey]
        public string deck_id { get; set; }
        public bool is_current { get; set; }
        public string username { get; set; }
        public DateTime created_at { get; set; }

    }
}
