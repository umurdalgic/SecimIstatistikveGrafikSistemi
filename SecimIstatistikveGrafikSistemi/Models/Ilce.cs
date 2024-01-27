using System;
using System.Collections.Generic;

namespace SecimIstatistikveGrafikSistemi.Models
{
    public partial class Ilce
    {
        public byte Id { get; set; }
        public string? IlceAd { get; set; }
        public short? Aparti { get; set; }
        public short? Bparti { get; set; }
        public short? Cparti { get; set; }
        public short? Dparti { get; set; }
        public short? Eparti { get; set; }
    }
}
