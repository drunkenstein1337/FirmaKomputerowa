//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FirmaKomputerowa
{
    using System;
    using System.Collections.Generic;
    
    public partial class Laptopy
    {
        public int LaptopyID { get; set; }
        public int SN { get; set; }
        public double Procesor { get; set; }
        public int Pamiec_RAM { get; set; }
        public int Dysk_SSD { get; set; }
        public int Dysk_HDD { get; set; }
        public int Ekran { get; set; }
        public double Cena { get; set; }
    
        public virtual Produkty Produkty { get; set; }
    }
}
