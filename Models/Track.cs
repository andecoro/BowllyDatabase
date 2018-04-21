using System;
using System.Collections.Generic;

namespace BowllyForever.Models
{
    public partial class Track
    {
        public int TrackId { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Label { get; set; }
        public string CatNo { get; set; }
        public string Matrix { get; set; }
        [System.ComponentModel.DataAnnotations.DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = false)]
        public DateTime? Date { get; set; }
        public string Location { get; set; }
        public string Comments { get; set; }
        public string Words { get; set; }
        public string Music { get; set; }
        public string Youtube { get; set; }
        public string Image { get; set; }
        public string Mp3 { get; set; }
    }
}
