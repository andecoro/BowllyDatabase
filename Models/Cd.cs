using System;
using System.Collections.Generic;

namespace BowllyForever.Models
{
    public partial class Cd
    {
        public int Cdid { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public string RecordCo { get; set; }
        public string Label { get; set; }
        public string CatNo { get; set; }
        public string Location { get; set; }
        public int? Released { get; set; }
        public string Front { get; set; }
        public string Back { get; set; }
        public string Inside { get; set; }
    }
}
