﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace bull.Models
{
    public class DesmameModel
    {
        [Key]
        public int ID { get; set; }

        public string NomePagina { get; set; }
    };
}
