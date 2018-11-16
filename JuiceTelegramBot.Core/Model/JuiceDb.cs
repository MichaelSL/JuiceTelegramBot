﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JuiceTelegramBot.Core.Model
{
    public class JuiceDb
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public bool IsCustom { get; set; }
        public bool Approved { get; set; }
        public DateTime JuiceDateTime { get; set; }
        public string UserName { get; set; }

        public ICollection<OrderDb> Orders { get; set; }

    }
}
