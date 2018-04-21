using System;
using System.Collections.Generic;

namespace BowllyForever.Models
{
    public partial class Cassette
    {
        public int CassetteId { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public string RecordCo { get; set; }
        public string Label { get; set; }
        public string CatNo { get; set; }
        public string Location { get; set; }
        public int? Released { get; set; }
        public string Front { get; set; }
        public string Back { get; set; }
    }
}
