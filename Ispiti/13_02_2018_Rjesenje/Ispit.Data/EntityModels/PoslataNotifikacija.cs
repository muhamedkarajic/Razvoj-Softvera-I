﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Ispit.Data.EntityModels
{
    public class PoslataNotifikacija
    {
        public int Id { get; set; }

        [ForeignKey(nameof(StanjeObaveze))]
        public int StanjeObavezeID { get; set; }
        public StanjeObaveze StanjeObaveze { get; set; }

        public DateTime DatumSlanja { get; set; }
        public bool IsProcitano { get; set; }

        public PoslataNotifikacija() { }

        public PoslataNotifikacija(int stanjeObavezeID)
        {
            StanjeObavezeID = stanjeObavezeID;
            IsProcitano = false;
            DatumSlanja = DateTime.Now;
        }
    }
}
