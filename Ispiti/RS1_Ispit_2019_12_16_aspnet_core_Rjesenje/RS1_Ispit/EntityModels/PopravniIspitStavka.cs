﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.EntityModels
{
    public class PopravniIspitStavka
    {
        public int Id { get; set; }

        public OdjeljenjeStavka OdjeljenjeStavka { get; set; }
        public int OdjeljenjeStavkaId { get; set; }

        public PopravniIspit PopravniIspit { get; set; }
        public int PopravniIspitId { get; set; }

        public double? Bodovi { get; set; }
        public bool Prisutan { get; set; }
    }
}
