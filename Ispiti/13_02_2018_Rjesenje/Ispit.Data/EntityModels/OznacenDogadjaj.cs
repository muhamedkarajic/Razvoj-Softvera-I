﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ispit.Data.EntityModels
{
    public class OznacenDogadjaj
    {
        [Key]
        public int ID { get; set; }
        public DateTime DatumDodavanja { get; set; }


        [ForeignKey(nameof(Student))]
        public int StudentID { get; set; }
        public Student Student { get; set; }


        [ForeignKey(nameof(Dogadjaj))]
        public int DogadjajID { get; set; }
        public Dogadjaj Dogadjaj { get; set; }
        
        public OznacenDogadjaj(int studentID, int dogadjajID)
        {
            DatumDodavanja = DateTime.Now;
            StudentID = studentID;
            DogadjajID = dogadjajID;
        }
        public OznacenDogadjaj() { }
    }
}
