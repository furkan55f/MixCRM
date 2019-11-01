﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MixCRM.Models
{
    public class Musteri
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        [StringLength(20), Required(ErrorMessage = "Bu alan doldurulmalıdır!")]
        public string TCKimlik { get; set; }
        public string Email { get; set; }
        public string Cinsiyet { get; set; }
        public DateTime DTarih { get; set; }
        public string Adres { get; set; }
        public int FirmaId { get; set; }
        public Firma Firma { get; set; }
    }
}
